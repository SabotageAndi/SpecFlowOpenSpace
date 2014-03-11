using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace SpecFlowOpenSpace.Test.StepDefinition
{
    [Binding]
    class CalculatorSteps
    {
        /*
        private Calculator Calculator
        {
            get { return ScenarioContext.Current["Calc"] as Calculator; }
            set { ScenarioContext.Current["Calc"] = value; }
        }
         */

        private static Calculator Calculator;

        [Given(@"I have an calculator")]
        public void GivenIHaveAnCalculator()
        {
            Calculator = new Calculator();
        }

        [When(@"I enter '(.*)'")]
        public void WhenIEnter(string number)
        {
            decimal enteredNumber = Convert.ToDecimal(number);
            Calculator.EnterNumber(enteredNumber);
        }

        [When(@"I press '(.*)'")]
        public void WhenIPress(string button)
        {
            switch (button)
            {
                case "+":
                    Calculator.Add();
                    break;
                case "-":
                    Calculator.Sub();
                    break;
                case "*":
                    Calculator.Multi();
                    break;
                case "/":
                    Calculator.Div();
                    break;
                default:
                    throw new NotImplementedException("This calculator function is not implemented yet");
            }
        }

        [Then(@"the calculator displays '(.*)'")]
        public void ThenTheCalculatorDisplays(string number)
        {
            decimal displayedNumber = Convert.ToDecimal(number);
            Assert.AreEqual(displayedNumber, Calculator.CurrentValue);
        }

        [When(@"I enter following numbers and operators:")]
        public void WhenIEnterFollowingNumbersAndOperators(Table table)
        {
            /*
            foreach (var row in table.Rows)
            {
                string value = row["Value"];
                decimal decValue;
                if (Decimal.TryParse(value, out decValue))
                {
                    Calculator.EnterNumber(decValue);
                }
                else
                {
                    WhenIPress(value);
                }
            }*/

            var rows = table.CreateSet<ValueRow>();

            foreach (var valueRow in rows)
            {
                decimal decValue;
                if (Decimal.TryParse(valueRow.Value, out decValue))
                {
                    Calculator.EnterNumber(decValue);
                }
                else
                {
                    WhenIPress(valueRow.Value);
                }
            }
        }

        class ValueRow
        {
            public string Value { get; set; }
        }

        [Given(@"reset the calculator")]
        public void GivenResetTheCalculator()
        {
            Calculator.Reset();
        }

        [AfterScenario()]
        public void BeforeScenario()
        {
            Calculator = null;
        }
    }
}
