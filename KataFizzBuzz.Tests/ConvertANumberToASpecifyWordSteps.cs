﻿using KataFizzBuzzLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace KataFizzBuzz.Tests
{
    [Binding]
    public  sealed class ConvertANumberToASpecifyWordSteps
    {
        public static string Output
        {
            get => ScenarioContext.Current.Get<string>(nameof(Output));
            set => ScenarioContext.Current.Set(value, nameof(Output));
        }
        public static string Error
        {
            get => ScenarioContext.Current.Get<string>(nameof(Error));
            set => ScenarioContext.Current.Set(value, nameof(Error));
        }



        [When(@"I ask to convert a (.*)")]
        public void WhenIAskToConvertA(int input)
        {
            try
            {
               Output = NumberConverter.Conversion(input);
            }

            catch(Exception e)
            {
                Error = e.Message;
            }
              

          
        }

        [Then(@"The result of the conversion should be a (.*)")]
        public void ThenTheResultOfTheConversionShouldBeFizz(string multipleOfConverted)
        {
            Assert.AreEqual(multipleOfConverted, Output);
        }



        


        [Then(@"An Error indicates ""(.*)""")]
        public void ThenAnErrorIndicates(string erreur)
        {
            Assert.AreEqual(erreur, Error);
        }

    }
}
