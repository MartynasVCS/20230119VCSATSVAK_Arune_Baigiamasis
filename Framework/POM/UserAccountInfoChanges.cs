﻿namespace Framework.POM
{
    public class UserAccountInfoChanges
    {
        public static void ClickAddNewPet()
        {
            Common.ClickElement(Locators.AddNewDogToMyPetsInfo.ButtonAddNewPet);
            Common.WaitForElementToBeVisible(Locators.AddNewDogToMyPetsInfo.FormNewPet);
        }

        public static void CLickButtonToSave()
        {
            Common.ClickElement(Locators.AddNewDogToMyPetsInfo.ButtonToSave);
        }

        public static void ClickIconUserAccount()
        {
            Common.ClickElement(Locators.AddNewDogToMyPetsInfo.ButtonIconUserAccount);
        }

        public static void ClickMyPets()
        {
            Common.ClickElement(Locators.AddNewDogToMyPetsInfo.ButtonMyPets);
        }

        public static void EneterValuePetsBreed(string valuePetsBreed)
        {
            Common.SendKeys(Locators.AddNewDogToMyPetsInfo.InputPetsBreed,valuePetsBreed);
        }

        public static void EnterValuePetsName(string valuePetsName)
        {
            Common.SendKeys(Locators.AddNewDogToMyPetsInfo.InputPetsName,valuePetsName);
        }

        public static string NotificationSuccess()
        {
            return Common.GetElementText(Locators.AddNewDogToMyPetsInfo.NotificationBar);
        }

        public static void SelectOptionInBirthDay(string optionText)
        {
            Common.SelectOptionBytext(Locators.AddNewDogToMyPetsInfo.SelectDay, optionText);
        }

        public static void SelectOptionInBirthMonth(string optionText)
        {
            Common.SelectOptionBytext(Locators.AddNewDogToMyPetsInfo.SelectMonth, optionText);
        }

        public static void SelectOptionInBirthYear(string optionText)
        {
            Common.SelectOptionBytext(Locators.AddNewDogToMyPetsInfo.SelectYear, optionText);
        }

        public static void SelectOptionInPetsSpecies(string optionText)
        {
            Common.SelectOptionBytext(Locators.AddNewDogToMyPetsInfo.SelectSpecies, optionText);
        }
    }
}
