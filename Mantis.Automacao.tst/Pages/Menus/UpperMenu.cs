using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages.Menus
{
    class UpperMenu : PageBase
    {
        public bool IsUserLoggedIn(string userName)
        {
            return ReturnIfElementIsDisplayed(By.XPath("//*[@class='user-info' and contains(text(),'" + userName + "')]"));
        }
    }
}
