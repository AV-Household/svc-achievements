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
    public partial class НастройкаПравилПодсчетаРейтингаОтВыполненияЗадачFeature : object, Xunit.IClassFixture<НастройкаПравилПодсчетаРейтингаОтВыполненияЗадачFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SetUpTaskRules.feature"
#line hidden
        
        public НастройкаПравилПодсчетаРейтингаОтВыполненияЗадачFeature(НастройкаПравилПодсчетаРейтингаОтВыполненияЗадачFeature.FixtureData fixtureData, Achievements_Specs_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Настройка правил подсчета рейтинга от выполнения задач", "Настройка правил подсчета рейтинга доступна только для взрослых", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Взрослые могут настраивать правило подсчета рейтинга за выполнение ребенком задач" +
            "и")]
        [Xunit.TraitAttribute("FeatureTitle", "Настройка правил подсчета рейтинга от выполнения задач")]
        [Xunit.TraitAttribute("Description", "Взрослые могут настраивать правило подсчета рейтинга за выполнение ребенком задач" +
            "и")]
        public virtual void ВзрослыеМогутНастраиватьПравилоПодсчетаРейтингаЗаВыполнениеРебенкомЗадачи()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Взрослые могут настраивать правило подсчета рейтинга за выполнение ребенком задач" +
                    "и", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Phone",
                            "Name",
                            "Adult"});
                table25.AddRow(new string[] {
                            "father@family.com",
                            "+79180000001",
                            "Папа",
                            "да"});
                table25.AddRow(new string[] {
                            "son@family.com",
                            "+79180000004",
                            "Сын",
                            "нет"});
#line 6
  testRunner.Given("Семья из", ((string)(null)), table25, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "Условие изменения рейтинга",
                            "Изменеие в баллах"});
                table26.AddRow(new string[] {
                            "Ребенок просрочил задачу",
                            "-5"});
                table26.AddRow(new string[] {
                            "Ребенок выполнил задачу",
                            "+10"});
                table26.AddRow(new string[] {
                            "Ребенок получил оценку 2",
                            "-10"});
                table26.AddRow(new string[] {
                            "Ребенок получил оценку 3",
                            "+0"});
                table26.AddRow(new string[] {
                            "Ребенок получил оценку 4",
                            "+5"});
                table26.AddRow(new string[] {
                            "Ребенок получил оценку 5",
                            "+15"});
#line 10
  testRunner.And("Правила", ((string)(null)), table26, "And ");
#line hidden
#line 18
  testRunner.And("в систему вошел Папа", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
  testRunner.When("Пользователь меняет правило подсчета при выполнении задачи ребенком(+15)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
  testRunner.And("Пользователь просматривает правила подсчета рейтинга", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
  testRunner.Then("В правилах указано, что за выполнение задачи ребенку начисляется 15 баллов", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Взрослые могут настраивать правило подсчета рейтинга за невыполнение ребенком зад" +
            "ачи в срок")]
        [Xunit.TraitAttribute("FeatureTitle", "Настройка правил подсчета рейтинга от выполнения задач")]
        [Xunit.TraitAttribute("Description", "Взрослые могут настраивать правило подсчета рейтинга за невыполнение ребенком зад" +
            "ачи в срок")]
        public virtual void ВзрослыеМогутНастраиватьПравилоПодсчетаРейтингаЗаНевыполнениеРебенкомЗадачиВСрок()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Взрослые могут настраивать правило подсчета рейтинга за невыполнение ребенком зад" +
                    "ачи в срок", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 23
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
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Phone",
                            "Name",
                            "Adult"});
                table27.AddRow(new string[] {
                            "father@family.com",
                            "+79180000001",
                            "Папа",
                            "да"});
                table27.AddRow(new string[] {
                            "son@family.com",
                            "+79180000004",
                            "Сын",
                            "нет"});
#line 24
  testRunner.Given("Семья из", ((string)(null)), table27, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Условие изменения рейтинга",
                            "Изменеие в баллах"});
                table28.AddRow(new string[] {
                            "Ребенок просрочил задачу",
                            "-5"});
                table28.AddRow(new string[] {
                            "Ребенок выполнил задачу",
                            "+10"});
                table28.AddRow(new string[] {
                            "Ребенок получил оценку 2",
                            "-10"});
                table28.AddRow(new string[] {
                            "Ребенок получил оценку 3",
                            "+0"});
                table28.AddRow(new string[] {
                            "Ребенок получил оценку 4",
                            "+5"});
                table28.AddRow(new string[] {
                            "Ребенок получил оценку 5",
                            "+15"});
#line 28
  testRunner.And("Правила", ((string)(null)), table28, "And ");
#line hidden
#line 36
  testRunner.And("в систему вошел Папа", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
  testRunner.When("Пользователь меняет правило подсчета при невыполнении задачи ребенком(-10)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
  testRunner.And("Пользователь просматривает правила подсчета рейтинга", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
  testRunner.Then("В правилах указано, что за невыполнение задачи у ребенка снимается 10 баллов", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Ребенок не может настраивать правило подсчета рейтинга за выполнение ребенком зад" +
            "ачи")]
        [Xunit.TraitAttribute("FeatureTitle", "Настройка правил подсчета рейтинга от выполнения задач")]
        [Xunit.TraitAttribute("Description", "Ребенок не может настраивать правило подсчета рейтинга за выполнение ребенком зад" +
            "ачи")]
        public virtual void РебенокНеМожетНастраиватьПравилоПодсчетаРейтингаЗаВыполнениеРебенкомЗадачи()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ребенок не может настраивать правило подсчета рейтинга за выполнение ребенком зад" +
                    "ачи", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 41
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
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Phone",
                            "Name",
                            "Adult"});
                table29.AddRow(new string[] {
                            "father@family.com",
                            "+79180000001",
                            "Папа",
                            "да"});
                table29.AddRow(new string[] {
                            "son@family.com",
                            "+79180000004",
                            "Сын",
                            "нет"});
#line 42
  testRunner.Given("Семья из", ((string)(null)), table29, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "Условие изменения рейтинга",
                            "Изменеие в баллах"});
                table30.AddRow(new string[] {
                            "Ребенок просрочил задачу",
                            "-5"});
                table30.AddRow(new string[] {
                            "Ребенок выполнил задачу",
                            "+10"});
                table30.AddRow(new string[] {
                            "Ребенок получил оценку 2",
                            "-10"});
                table30.AddRow(new string[] {
                            "Ребенок получил оценку 3",
                            "+0"});
                table30.AddRow(new string[] {
                            "Ребенок получил оценку 4",
                            "+5"});
                table30.AddRow(new string[] {
                            "Ребенок получил оценку 5",
                            "+15"});
#line 46
  testRunner.And("Правила", ((string)(null)), table30, "And ");
#line hidden
#line 54
  testRunner.And("в систему вошел Сын", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
  testRunner.When("Пользователь меняет правило подсчета при выполнении задачи ребенком(+15)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
  testRunner.And("Пользователь просматривает правила подсчета рейтинга", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
  testRunner.Then("В правилах указано, что за выполнение задачи ребенку начисляется 10 баллов", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Ребенок не может настраивать правило подсчета рейтинга за невыполнение ребенком з" +
            "адачи в срок")]
        [Xunit.TraitAttribute("FeatureTitle", "Настройка правил подсчета рейтинга от выполнения задач")]
        [Xunit.TraitAttribute("Description", "Ребенок не может настраивать правило подсчета рейтинга за невыполнение ребенком з" +
            "адачи в срок")]
        public virtual void РебенокНеМожетНастраиватьПравилоПодсчетаРейтингаЗаНевыполнениеРебенкомЗадачиВСрок()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ребенок не может настраивать правило подсчета рейтинга за невыполнение ребенком з" +
                    "адачи в срок", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 59
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
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Phone",
                            "Name",
                            "Adult"});
                table31.AddRow(new string[] {
                            "father@family.com",
                            "+79180000001",
                            "Папа",
                            "да"});
                table31.AddRow(new string[] {
                            "son@family.com",
                            "+79180000004",
                            "Сын",
                            "нет"});
#line 60
  testRunner.Given("Семья из", ((string)(null)), table31, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "Условие изменения рейтинга",
                            "Изменеие в баллах"});
                table32.AddRow(new string[] {
                            "Ребенок просрочил задачу",
                            "-5"});
                table32.AddRow(new string[] {
                            "Ребенок выполнил задачу",
                            "+10"});
                table32.AddRow(new string[] {
                            "Ребенок получил оценку 2",
                            "-10"});
                table32.AddRow(new string[] {
                            "Ребенок получил оценку 3",
                            "+0"});
                table32.AddRow(new string[] {
                            "Ребенок получил оценку 4",
                            "+5"});
                table32.AddRow(new string[] {
                            "Ребенок получил оценку 5",
                            "+15"});
#line 64
  testRunner.And("Правила", ((string)(null)), table32, "And ");
#line hidden
#line 72
  testRunner.And("в систему вошел Сын", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
  testRunner.When("Пользователь меняет правило подсчета при невыполнении задачи ребенком(-10)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
  testRunner.And("Пользователь просматривает правила подсчета рейтинга", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
  testRunner.Then("В правилах указано, что за невыполнение задачи у ребенка снимается 5 баллов", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                НастройкаПравилПодсчетаРейтингаОтВыполненияЗадачFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                НастройкаПравилПодсчетаРейтингаОтВыполненияЗадачFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
