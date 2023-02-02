using Achievements.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Achievements.Controllers
{
    [ApiController]
    [Route("ratingpoints")]
    public class RatingPointsController : ControllerBase
    {
        private static readonly List<Rating> ratings = new List<Rating>
        {
            new Rating(2, 0),
            new Rating(3, 0)
        };

        public static void AddKid(int idOfKid, int points)
        {
            ratings.Add(new Rating(idOfKid, points));
        }

        public static void DeleteKid(int idOfKid)
        {
            foreach(Rating rating in ratings)
            {
                if(rating.ID == idOfKid)
                {
                    ratings.Remove(rating);
                    break;
                }
            }
        }

        public static void ClearKidList()
        {
            ratings.Clear();
        }

        public static List<Rating> GetRaitingsList()
        {
            return ratings;
        }

        public static Rating GetRatingByID(int ID)
        {
            foreach(Rating rating in ratings)
            {
                if(rating.ID == ID)
                {
                    return rating;
                }
            }
            return null;
        }

        public static void AutomaticallyCalculateRating(int idOfKid, int ruleForCounting)
        {
            int[] rules = RatingRulesController.GetRatingRules();
            foreach (Rating rating in ratings)
            {
                if (rating.ID == idOfKid)
                {
                    rating.ratingPoints += rules[ruleForCounting];
                    break;
                }
            }
        }

        public static void CalculateRatingAfterPurchase(int idOfKid, int costOfPrize)
        {
            foreach (Rating rating in ratings)
            {
                if (rating.ID == idOfKid)
                {
                    rating.ratingPoints -= costOfPrize;
                }
                break;
            }
        }

        [HttpGet(Name = "Получить список рейтингов")]
        public List<Rating> Get()
        {
            if (AuthenticationController.IsUserAuthorized())
            {
                if (AuthenticationController.IsAuthorizedAdult())
                {
                    return ratings;
                }
                else
                {
                    List<Rating> ratingOf1Kid = new List<Rating>();
                    ratingOf1Kid.Add(GetRatingByID(AuthenticationController.GetID()));
                    return ratingOf1Kid;
                }
            }
            else return null;
        }

        [HttpPost(Name = "Начислить бонус или штраф ребенку")]
        public void ManuallyAddOrRemoveRating(string nameOfKid, int pointsCount)
        {
            if (AuthenticationController.IsAuthorizedAdult())
            {
                int IDOfKid = FamilyMembersController.GetMemberByName(nameOfKid).ID;
                foreach (Rating rating in ratings)
                {
                    if (rating.ID == IDOfKid)
                    {
                        rating.ratingPoints += pointsCount;
                        break;
                    }
                }
            }
        }

        [HttpPut]
        public void InformAbounKidActivity(string nameOfKid, int GradeOrTaskCompleting)
        {
            if (AuthenticationController.IsAuthorizedAdult())
            {
                AutomaticallyCalculateRating(FamilyMembersController.GetMemberByName(nameOfKid).ID, GradeOrTaskCompleting);
            }
        }
    }
}
