﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Achievements.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Автоматический подсчет рейтинга ребенка")]
    public partial class АвтоматическийПодсчетРейтингаРебенкаFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CalculateRating.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Автоматический подсчет рейтинга ребенка", "Рейтинг ребенка изменяется автоматически при выполнении или невыполнении им задач" +
                    "и и при покупке приза", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Изменеие рейтинга при выполнении ребенком задачи")]
        public virtual void ИзменеиеРейтингаПриВыполненииРебенкомЗадачи()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Изменеие рейтинга при выполнении ребенком задачи", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Условие изменения рейтинга",
                            "Изменеие в баллах"});
                table1.AddRow(new string[] {
                            "Ребенок выполнил задачу",
                            "+10"});
                table1.AddRow(new string[] {
                            "Ребенок просрочил задачу",
                            "-5"});
                table1.AddRow(new string[] {
                            "Ребенок получил оценку 5",
                            "+15"});
                table1.AddRow(new string[] {
                            "Ребенок получил оценку 4",
                            "+5"});
                table1.AddRow(new string[] {
                            "Ребенок получил оценку 3",
                            "+0"});
                table1.AddRow(new string[] {
                            "Ребенок получил оценку 2",
                            "-10"});
#line 6
  testRunner.Given("Правила", ((string)(null)), table1, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Ребенок",
                            "Очки рейтинга"});
                table2.AddRow(new string[] {
                            "Сын",
                            "130"});
                table2.AddRow(new string[] {
                            "Дочь",
                            "150"});
#line 14
  testRunner.And("Рейтинги", ((string)(null)), table2, "And ");
#line hidden
#line 18
  testRunner.When("Пришло сообщение, что Сын выполнил задачу", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Ребенок",
                            "Очки рейтинга"});
                table3.AddRow(new string[] {
                            "Сын",
                            "140"});
                table3.AddRow(new string[] {
                            "Дочь",
                            "150"});
#line 19
  testRunner.Then("Рейтинги", ((string)(null)), table3, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Изменеие рейтинга при невыполнении ребенком задачи в срок")]
        public virtual void ИзменеиеРейтингаПриНевыполненииРебенкомЗадачиВСрок()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Изменеие рейтинга при невыполнении ребенком задачи в срок", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Условие изменения рейтинга",
                            "Изменеие в баллах"});
                table4.AddRow(new string[] {
                            "Ребенок выполнил задачу",
                            "+10"});
                table4.AddRow(new string[] {
                            "Ребенок просрочил задачу",
                            "-5"});
                table4.AddRow(new string[] {
                            "Ребенок получил оценку 5",
                            "+15"});
                table4.AddRow(new string[] {
                            "Ребенок получил оценку 4",
                            "+5"});
                table4.AddRow(new string[] {
                            "Ребенок получил оценку 3",
                            "+0"});
                table4.AddRow(new string[] {
                            "Ребенок получил оценку 2",
                            "-10"});
#line 25
  testRunner.Given("Правила", ((string)(null)), table4, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Ребенок",
                            "Очки рейтинга"});
                table5.AddRow(new string[] {
                            "Сын",
                            "130"});
                table5.AddRow(new string[] {
                            "Дочь",
                            "150"});
#line 33
  testRunner.And("Рейтинги", ((string)(null)), table5, "And ");
#line hidden
#line 37
  testRunner.When("Пришло сообщение, что Сын не выполнил задачу", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Ребенок",
                            "Очки рейтинга"});
                table6.AddRow(new string[] {
                            "Сын",
                            "135"});
                table6.AddRow(new string[] {
                            "Дочь",
                            "150"});
#line 38
  testRunner.Then("Рейтинги", ((string)(null)), table6, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Изменеие рейтинга при покупке приза")]
        public virtual void ИзменеиеРейтингаПриПокупкеПриза()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Изменеие рейтинга при покупке приза", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 43
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Условие изменения рейтинга",
                            "Изменеие в баллах"});
                table7.AddRow(new string[] {
                            "Ребенок выполнил задачу",
                            "+10"});
                table7.AddRow(new string[] {
                            "Ребенок просрочил задачу",
                            "-5"});
                table7.AddRow(new string[] {
                            "Ребенок получил оценку 5",
                            "+15"});
                table7.AddRow(new string[] {
                            "Ребенок получил оценку 4",
                            "+5"});
                table7.AddRow(new string[] {
                            "Ребенок получил оценку 3",
                            "+0"});
                table7.AddRow(new string[] {
                            "Ребенок получил оценку 2",
                            "-10"});
#line 44
  testRunner.Given("Правила", ((string)(null)), table7, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Ребенок",
                            "Очки рейтинга"});
                table8.AddRow(new string[] {
                            "Сын",
                            "130"});
                table8.AddRow(new string[] {
                            "Дочь",
                            "150"});
#line 52
  testRunner.And("Рейтинги", ((string)(null)), table8, "And ");
#line hidden
#line 56
  testRunner.When("Пришло сообщение, что Сын купил приз за 100 очков рейтинга", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Ребенок",
                            "Очки рейтинга"});
                table9.AddRow(new string[] {
                            "Сын",
                            "30"});
                table9.AddRow(new string[] {
                            "Дочь",
                            "150"});
#line 57
  testRunner.Then("Рейтинги", ((string)(null)), table9, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
