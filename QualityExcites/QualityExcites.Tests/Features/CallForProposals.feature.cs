﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace QualityExcites.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Call For Proposals")]
    public partial class CallForProposalsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CallForProposals.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Call For Proposals", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register with correct data")]
        [NUnit.Framework.CategoryAttribute("automated")]
        public virtual void RegisterWithCorrectData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register with correct data", new string[] {
                        "automated"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("User navigates to \'Call for proposals\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "title",
                        "Presentation 1"});
            table1.AddRow(new string[] {
                        "form",
                        "lecture (25 minutes)"});
            table1.AddRow(new string[] {
                        "speaker",
                        "no"});
            table1.AddRow(new string[] {
                        "presented",
                        "no"});
            table1.AddRow(new string[] {
                        "presentation",
                        "Presentation.txt"});
            table1.AddRow(new string[] {
                        "description",
                        "400"});
#line 6
 testRunner.When("User fills following fields on \'Call for proposals\' page", ((string)(null)), table1, "When ");
#line 14
 testRunner.And("User clicks on \'Next step\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "first name",
                        "Mark"});
            table2.AddRow(new string[] {
                        "surname",
                        "Smith"});
            table2.AddRow(new string[] {
                        "position",
                        "QA"});
            table2.AddRow(new string[] {
                        "company institution",
                        "FP"});
            table2.AddRow(new string[] {
                        "biography",
                        "400"});
            table2.AddRow(new string[] {
                        "email address",
                        "test@test.test"});
            table2.AddRow(new string[] {
                        "phone number",
                        "123123123"});
            table2.AddRow(new string[] {
                        "photo",
                        "Photo.png"});
            table2.AddRow(new string[] {
                        "agreement",
                        "yes"});
            table2.AddRow(new string[] {
                        "captcha",
                        "1234"});
#line 15
 testRunner.And("User fills following fields on \'Call for proposals\' page", ((string)(null)), table2, "And ");
#line 27
 testRunner.And("User clicks on submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("User is successfully registered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mandatory fields - step 1")]
        [NUnit.Framework.CategoryAttribute("automated")]
        public virtual void MandatoryFields_Step1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mandatory fields - step 1", new string[] {
                        "automated"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("User navigates to \'Call for proposals\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When("User clicks on \'Next step\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("All fields from step 1 are marked as invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Mandatory fields - step 2")]
        [NUnit.Framework.CategoryAttribute("automated")]
        public virtual void MandatoryFields_Step2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mandatory fields - step 2", new string[] {
                        "automated"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("User navigates to \'Call for proposals\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "title",
                        "Presentation 1"});
            table3.AddRow(new string[] {
                        "form",
                        "lecture (25 minutes)"});
            table3.AddRow(new string[] {
                        "speaker",
                        "no"});
            table3.AddRow(new string[] {
                        "presented",
                        "no"});
            table3.AddRow(new string[] {
                        "presentation",
                        "Presentation.txt"});
            table3.AddRow(new string[] {
                        "description",
                        "400"});
#line 39
 testRunner.When("User fills following fields on \'Call for proposals\' page", ((string)(null)), table3, "When ");
#line 47
 testRunner.And("User clicks on \'Next step\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("User clicks on submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.Then("All fields from step 2 are marked as invalid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
