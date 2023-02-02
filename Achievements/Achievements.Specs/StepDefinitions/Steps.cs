using Achievements.Controllers;
using Achievements.Models;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Achievements.Specs.StepDefinitions
{
    [Binding]
    public class Steps
    {
        AuthenticationController authenticationController = new AuthenticationController();
        FamilyMembersController familyMembersController = new FamilyMembersController();
        RatingPointsController ratingPointsController = new RatingPointsController();
        RatingRulesController ratingRulesController = new RatingRulesController();

        int[] rules = new int[6];
        List<Rating> ratings = new List<Rating>();

        [Given(@"Семья из")]
        public void GivenСемьяИз(Table table)
        {
            FamilyMembersController.ClearFamilyMemberList();
            foreach(TableRow row in table.Rows)
            {
                FamilyMembersController.AddFamilyMember(new FamilyMembersController.AddFamilyMemberDTO(row["Name"].Trim(), row["Adult"].Trim() == "да", row["Email"].Trim(), row["Phone"].Trim()));
            }
        }

        [Given(@"Правила")]
        public void GivenПравила(Table table)
        {
            int[] newRules = new int[6];
            for(int i = 0; i < table.Rows.Count; i++)
            {
                string rule = table.Rows[i]["Изменеие в баллах"].Trim();
                rule.TrimStart('+');
                int points = Int32.Parse(rule);
                newRules[i] = points;
            }
            RatingRulesController.SetRatingRules(newRules);
        }

        [Given(@"в систему вошел (.*)")]
        public void GivenВСистемуВошел(string userName)
        {
            authenticationController.LogOut();
            if(FamilyMembersController.GetMemberByName(userName).IsAdult == true)
            {
                authenticationController.LogIn(userName, "iamadult");
            }
            else
            {
                authenticationController.LogIn(userName, "iamkid");
            }
        }

        [When(@"Пользователь меняет правило подсчета при выполнении задачи ребенком\((.*)\)")]
        public void WhenПользовательМеняетПравилоПодсчетаПриВыполненииЗадачиРебенком(string points)
        {
            points.TrimStart('+');
            int intPoints = Int32.Parse(points);
            ratingRulesController.ChangeRule(1, intPoints);
        }

        [When(@"Пользователь меняет правило подсчета при невыполнении задачи ребенком\((.*)\)")]
        public void WhenПользовательМеняетПравилоПодсчетаПриНевыполненииЗадачиРебенком(string points)
        {
            points.TrimStart('+');
            int intPoints = Int32.Parse(points);
            ratingRulesController.ChangeRule(0, intPoints);
        }

        [When(@"Пользователь просматривает правила подсчета рейтинга")]
        public void WhenПользовательПросматриваетПравилаПодсчетаРейтинга()
        {
            rules = ratingRulesController.Get();
        }

        [Then(@"В правилах указано, что за выполнение задачи ребенку начисляется (.*) баллов")]
        public void ThenВПравилахУказаноЧтоЗаВыполнениеЗадачиРебенкуНачисляетсяБаллов(int points)
        {
            if (rules[1] != points)
            {
                throw new Exception("Не совпало правило при выполнении задачи (" + points + " == " + rules[1]);
            }
        }

        [Then(@"В правилах указано, что за невыполнение задачи у ребенка снимается (.*) баллов")]
        public void ThenВПравилахУказаноЧтоЗаНевыполнениеЗадачиУРебенкаСнимаетсяБаллов(int points)
        {
            if (rules[0] != -points)
            {
                throw new Exception("Не совпало правило при невыполнении задачи (" + -points + " == " + rules[0]);
            }
        }

        [When(@"Пользователь меняет правило подсчета при получении ребенком оценки (\d)\((.*)\)")]
        public void WhenПользовательМеняетПравилоПодсчетаПриПолученииРебенкомОценки(int grade, string points)
        {
            points.TrimStart('+');
            int intPoints = Int32.Parse(points);
            ratingRulesController.ChangeRule(grade, intPoints);
        }

        [Then(@"В правилах указано, что за получение оценки (\d) ребенку начисляется (.*) баллов")]
        public void ThenВПравилахУказаноЧтоЗаПолучениеОценкиРебенкуНачисляетсяБаллов(int grade, int points)
        {
            if (rules[grade] != points)
            {
                throw new Exception("Не совпало правило при получении оценки " + grade + " (" + points + " == " + rules[grade]);
            }
        }

        [Then(@"В правилах указано, что за получение оценки (\d) у ребенка снимается (.*) баллов")]
        public void ThenВПравилахУказаноЧтоЗаПолучениеОценкиУРебенкаСнимаетсяБаллов(int grade, int points)
        {
            if (rules[grade] != -points)
            {
                throw new Exception("Не совпало правило при получении оценки " + grade + " (" + -points + " == " + rules[grade]);
            }
        }

        [Given(@"Рейтинги")]
        public void GivenРейтинги(Table table)
        {
            RatingPointsController.ClearKidList();
            foreach (TableRow row in table.Rows)
            {
                RatingPointsController.AddKid(FamilyMembersController.GetMemberByName(row["Ребенок"].Trim()).ID, Int32.Parse(row["Очки рейтинга"].Trim()));
            }
        }

        [When(@"Пришло сообщение, что (.*) выполнил задачу")]
        public void WhenПришлоСообщениеЧтоСынВыполнилЗадачу(string kidName)
        {
            RatingPointsController.AutomaticallyCalculateRating(FamilyMembersController.GetMemberByName(kidName).ID, 1);
        }

        [Then(@"Рейтинги")]
        public void ThenРейтинги(Table table)
        {
            if(table.Rows.Count != RatingPointsController.GetRaitingsList().Count)
            {
                throw new Exception("Не совпало количество детей в списке (" + table.Rows.Count + " == " + RatingPointsController.GetRaitingsList().Count + ")");
            }

            foreach(TableRow row in table.Rows)
            {
                int ThenRating = Int32.Parse(row["Очки рейтинга"].Trim());
                int RealRating = RatingPointsController.GetRatingByID(FamilyMembersController.GetMemberByName(row["Ребенок"].Trim()).ID).ratingPoints;
                if (RealRating != ThenRating)
                {
                    throw new Exception("Не совпал рейтинг ребенка (" + RealRating + " == " + ThenRating + ")");
                }
            }
        }

        [When(@"Пришло сообщение, что (.*) не_выполнил задачу")]
        public void WhenПришлоСообщениеЧтоСынНеВыполнилЗадачу(string kidName)
        {
            RatingPointsController.AutomaticallyCalculateRating(FamilyMembersController.GetMemberByName(kidName).ID, 0);
        }

        [When(@"Пришло сообщение, что (.*) купил приз за (.*) очков рейтинга")]
        public void WhenПришлоСообщениеЧтоСынКупилПризЗаОчковРейтинга(string kidName, int prizeCost)
        {
            RatingPointsController.CalculateRatingAfterPurchase(FamilyMembersController.GetMemberByName(kidName).ID, prizeCost);
        }

        [When(@"Пользователь начислил пользователю (.*) бонус в (.*) очков рейтинга")]
        public void WhenПользовательНачислилПользователюСынБонусВОчковРейтинга(string kidName, int points)
        {
            ratingPointsController.ManuallyAddOrRemoveRating(kidName.Trim(), points);
        }

        [When(@"Пользователь начислил пользователю (.*) штраф в (.*) очков рейтинга")]
        public void WhenПользовательНачислилПользователюДочьШтрафВОчковРейтинга(string kidName, int points)
        {
            ratingPointsController.ManuallyAddOrRemoveRating(kidName.Trim(), -points);
        }

        [When(@"Пользователь просматривает рейтинг")]
        public void WhenПользовательПросматриваетРейтиг()
        {
            ratings = ratingPointsController.Get();
        }

        [Then(@"система сообщает, что (.*) имеет рейтинг (.*)")]
        public void ThenСистемаСообщаетЧтоСынИмеетРейтиг(string kidName, int points)
        {
            int kidID = FamilyMembersController.GetMemberByName(kidName).ID;
            foreach(Rating rating in ratings)
            {
                if(rating.ID == kidID)
                {
                    if(rating.ratingPoints != points)
                    {
                        throw new Exception("Не совпал рейтинг");
                    }
                    break;
                }
            }
        }

        [Then(@"система не сообщает рейтинг пользователя (.*)")]
        public void ThenСистемаНеСообщаетРейтингПользователяДочь(string kidName)
        {
            int kidID = FamilyMembersController.GetMemberByName(kidName).ID;
            foreach (Rating rating in ratings)
            {
                if (rating.ID == kidID)
                {
                    throw new Exception("Система сообщила рейтинг пользователя, хотя не должна была");
                }
            }
        }
    }
}
