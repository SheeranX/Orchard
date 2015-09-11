﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Multiple tenant management")]
    public partial class MultipleTenantManagementFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MultiTenancy.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Multiple tenant management", "  In order to host several isolated web applications\r\n  As a root Orchard system " +
                    "operator\r\n  I want to create and manage tenant configurations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Default site is listed")]
        public virtual void DefaultSiteIsListed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Default site is listed", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
    testRunner.When("I go to \"Admin/MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
    testRunner.Then("I should see \"List of Site&#39;s Tenants\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
        testRunner.And("I should see \"<h3>Default\\s*</h3>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
        testRunner.And("the status should be 200 \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("New tenant fields are required")]
        public virtual void NewTenantFieldsAreRequired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("New tenant fields are required", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
    testRunner.Then("I should see \"is required\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A new tenant is created")]
        public virtual void ANewTenantIsCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new tenant is created", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "Name",
                        "Scott"});
#line 25
        testRunner.And("I fill in", ((string)(null)), table1, "And ");
#line 28
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
    testRunner.Then("I should see \"<h3>Scott\\s*</h3>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
        testRunner.And("the status should be 200 \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A new tenant is created with uninitialized state")]
        public virtual void ANewTenantIsCreatedWithUninitializedState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new tenant is created with uninitialized state", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "Name",
                        "Scott"});
#line 37
        testRunner.And("I fill in", ((string)(null)), table2, "And ");
#line 40
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.Then("I should see \"<li class=\"tenant Uninitialized\">\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
        testRunner.And("the status should be 200 \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A new tenant goes to the setup screen")]
        public virtual void ANewTenantGoesToTheSetupScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new tenant goes to the setup screen", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Name",
                        "Scott"});
            table3.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott.example.org"});
#line 49
        testRunner.And("I fill in", ((string)(null)), table3, "And ");
#line 53
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
        testRunner.And("I go to \"/Setup\" on host scott.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
    testRunner.Then("I should see \"Welcome to Orchard\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
        testRunner.And("I should see \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
        testRunner.And("the status should be 200 \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Several tenants are configured and go to setup screen")]
        public virtual void SeveralTenantsAreConfiguredAndGoToSetupScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Several tenants are configured and go to setup screen", ((string[])(null)));
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Name",
                        "Scott1"});
            table4.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott1.example.org"});
#line 63
        testRunner.And("I fill in", ((string)(null)), table4, "And ");
#line 67
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
        testRunner.And("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Name",
                        "Scott2"});
            table5.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott2.example.org"});
#line 70
        testRunner.And("I fill in", ((string)(null)), table5, "And ");
#line 74
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
        testRunner.And("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Name",
                        "Scott3"});
            table6.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott3.example.org"});
#line 77
        testRunner.And("I fill in", ((string)(null)), table6, "And ");
#line 81
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
        testRunner.And("I go to \"/Setup\" on host scott1.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
        testRunner.And("I go to \"/Setup\" on host scott2.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
        testRunner.And("I go to \"/Setup\" on host scott3.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
    testRunner.Then("I should see \"Welcome to Orchard\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A new tenant with preconfigured database goes to the setup screen")]
        public virtual void ANewTenantWithPreconfiguredDatabaseGoesToTheSetupScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new tenant with preconfigured database goes to the setup screen", ((string[])(null)));
#line 88
this.ScenarioSetup(scenarioInfo);
#line 89
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Name",
                        "Scott"});
            table7.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott.example.org"});
            table7.AddRow(new string[] {
                        "DataProvider",
                        "SqlCe"});
#line 92
        testRunner.And("I fill in", ((string)(null)), table7, "And ");
#line 97
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
        testRunner.And("I go to \"/Setup\" on host scott.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
    testRunner.Then("I should see \"Welcome to Orchard\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
        testRunner.And("I should see \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
        testRunner.And("I should not see \"SQL Server Compact\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
        testRunner.And("the status should be 200 \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A new tenant runs the setup")]
        public virtual void ANewTenantRunsTheSetup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new tenant runs the setup", ((string[])(null)));
#line 105
this.ScenarioSetup(scenarioInfo);
#line 106
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 107
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "Name",
                        "Scott"});
            table8.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott.example.org"});
#line 109
        testRunner.And("I fill in", ((string)(null)), table8, "And ");
#line 113
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
        testRunner.And("I go to \"/Setup\" on host scott.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "SiteName",
                        "Scott Site"});
            table9.AddRow(new string[] {
                        "AdminPassword",
                        "6655321"});
            table9.AddRow(new string[] {
                        "ConfirmPassword",
                        "6655321"});
#line 115
        testRunner.And("I fill in", ((string)(null)), table9, "And ");
#line 120
        testRunner.And("I hit \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
            testRunner.And("I go to \"/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
    testRunner.Then("I should see \"Scott Site\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
        testRunner.And("I should see \"Welcome\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An existing initialized tenant cannot have its database option cleared")]
        public virtual void AnExistingInitializedTenantCannotHaveItsDatabaseOptionCleared()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An existing initialized tenant cannot have its database option cleared", ((string[])(null)));
#line 125
this.ScenarioSetup(scenarioInfo);
#line 126
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 127
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "Name",
                        "Scott"});
            table10.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott.example.org"});
#line 129
        testRunner.And("I fill in", ((string)(null)), table10, "And ");
#line 133
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
        testRunner.And("I go to \"/Setup\" on host scott.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table11.AddRow(new string[] {
                        "SiteName",
                        "Scott Site"});
            table11.AddRow(new string[] {
                        "AdminPassword",
                        "6655321"});
            table11.AddRow(new string[] {
                        "ConfirmPassword",
                        "6655321"});
#line 135
        testRunner.And("I fill in", ((string)(null)), table11, "And ");
#line 140
        testRunner.And("I hit \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
        testRunner.And("I go to \"/Admin/MultiTenancy/Edit/Scott\" on host localhost", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
    testRunner.Then("I should see \"<h1 id=\"page-title\">Edit Tenant</h1>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
        testRunner.And("I should see \"<h2>Scott</h2>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
        testRunner.And("I should not see \"Allow the tenant to set up the database\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Default tenant cannot be disabled")]
        public virtual void DefaultTenantCannotBeDisabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Default tenant cannot be disabled", ((string[])(null)));
#line 146
this.ScenarioSetup(scenarioInfo);
#line 147
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 148
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
    testRunner.When("I go to \"Admin/MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 150
    testRunner.Then("I should not see \"<form action=\"/Admin/MultiTenancy/disable\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A running tenant can be disabled")]
        public virtual void ARunningTenantCanBeDisabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A running tenant can be disabled", ((string[])(null)));
#line 152
this.ScenarioSetup(scenarioInfo);
#line 153
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 154
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table12.AddRow(new string[] {
                        "Name",
                        "Scott"});
            table12.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott.example.org"});
#line 156
        testRunner.And("I fill in", ((string)(null)), table12, "And ");
#line 160
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
        testRunner.And("I go to \"/Setup\" on host scott.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table13.AddRow(new string[] {
                        "SiteName",
                        "Scott Site"});
            table13.AddRow(new string[] {
                        "AdminPassword",
                        "6655321"});
            table13.AddRow(new string[] {
                        "ConfirmPassword",
                        "6655321"});
#line 162
        testRunner.And("I fill in", ((string)(null)), table13, "And ");
#line 167
        testRunner.And("I hit \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
        testRunner.And("I go to \"/Admin/MultiTenancy\" on host localhost", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
        testRunner.And("I hit \"Suspend\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
    testRunner.Then("I should see \"<form action=\"/Admin/MultiTenancy/enable\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A running tenant which is disabled can be enabled")]
        public virtual void ARunningTenantWhichIsDisabledCanBeEnabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A running tenant which is disabled can be enabled", ((string[])(null)));
#line 173
this.ScenarioSetup(scenarioInfo);
#line 174
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 175
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
    testRunner.When("I go to \"Admin/MultiTenancy/Add\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table14.AddRow(new string[] {
                        "Name",
                        "Scott"});
            table14.AddRow(new string[] {
                        "RequestUrlHost",
                        "scott.example.org"});
#line 177
        testRunner.And("I fill in", ((string)(null)), table14, "And ");
#line 181
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
        testRunner.And("I go to \"/Setup\" on host scott.example.org", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table15.AddRow(new string[] {
                        "SiteName",
                        "Scott Site"});
            table15.AddRow(new string[] {
                        "AdminPassword",
                        "6655321"});
            table15.AddRow(new string[] {
                        "ConfirmPassword",
                        "6655321"});
#line 183
        testRunner.And("I fill in", ((string)(null)), table15, "And ");
#line 188
        testRunner.And("I hit \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
        testRunner.And("I go to \"/Admin/MultiTenancy\" on host localhost", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
        testRunner.And("I hit \"Suspend\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 192
        testRunner.And("I hit \"Resume\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
    testRunner.Then("I should see \"<form action=\"/Admin/MultiTenancy/disable\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Listing tenants from command line")]
        public virtual void ListingTenantsFromCommandLine()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Listing tenants from command line", ((string[])(null)));
#line 196
this.ScenarioSetup(scenarioInfo);
#line 197
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 198
        testRunner.And("I have installed \"Orchard.MultiTenancy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
        testRunner.And("I have tenant \"Alpha\" on \"example.org\" as \"New-site-name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
    testRunner.When("I execute >tenant list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 201
    testRunner.Then("I should see \"Name: Alpha\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 202
        testRunner.And("I should see \"Request Url Host: example.org\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
