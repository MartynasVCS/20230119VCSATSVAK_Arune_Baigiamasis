﻿namespace Framework.POM
{
    public class Home
    {
        // The only way I've found to wait for the page to be loaded
        // This loading can be seen in the search page when prices are updated
        // The page is disabled for a moment but there is no overlay element created in the html
        // The only noticable change is that additional specific divs are created
        // These divs are probably created by the Criteo system
        // This method waits for the number of those divs changes
        // This method should be update to maybe throw some exceptions if no additional divs were found
        // It will wait for maximum time of maxTries * milliseconds used in Thread.Sleep()
        // i.e. 20 * 100 results in up to 2 seconds of wait time
        internal static void WaitForPageToFinishLoading()
        {
            int countInitial = Common.GetElementCount(Locators.Home.DivsCriteo);

            int maxTries = 20;
            int currentTry = 0;
            while (currentTry < maxTries)
            {
                int countUpdated = Common.GetElementCount(Locators.Home.DivsCriteo);
                if (countUpdated > countInitial)
                {
                    break;
                }
                currentTry++;
                System.Threading.Thread.Sleep(100);
            }
        }

        public static void ClickCookiesAllaccept()
        {
            // Various waits are needed for tests to be stable
            // In rare cases it would still fail, might need additional investigation of what else to wait for
            Common.WaitForElementToBePresent(Locators.Home.ImagesLoading);
            Common.WaitForElementToBePresent(Locators.Home.ImagesLoaded);
            Common.WaitForElementToBePresent(Locators.Home.TagsCriteo);
            Common.WaitForElementToBePresent(Locators.Home.IframeCriteo);
            Common.ClickElement(Locators.Home.ButtonCookiesAllaccept);
            Common.WaitForElementToBeInvisible(Locators.Home.ModalCookies);
        }
    }
}
