using Mantis.Automacao.tst.Bases;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages.Menus
{
    class UpperMenu : PageBase
    {
        public ResultModel IsUserLoggedIn(string userName)
        {
            var isUserLoggedIn = ReturnIfElementIsDisplayed(By.XPath("//*[@class='user-info' and contains(text(),'" + userName + "')]"));

            return new ResultModel()
            {
                result = isUserLoggedIn,
                message = isUserLoggedIn ? AssertionsMessages.UserLogedInSuccess : AssertionsMessages.UserLoggedInFail
            };
        }
    }
}
