using Mantis.Automacao.tst.Bases;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ErrorMessagePage : PageBase
    {
        #region Mapping

        #endregion

        #region Actions

        public ResultModel AmInInvalidUsernamePage()
        {
            return ErrorPageValidation(ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'APPLICATION ERROR #805')]")));
        }

        public ResultModel AmInAlreadyUsedUsernamePage()
        {
            return ErrorPageValidation(ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'APPLICATION ERROR #800')]")));
        }

        public ResultModel AmInInvalidEmailPage()
        {
            return ErrorPageValidation(ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'APPLICATION ERROR #1200')]")));
        }

        public ResultModel AmInProjectAlreadyExistsPage()
        {
            return ErrorPageValidation(ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'APPLICATION ERROR #701')]")));
        }

        public ResultModel AmInCategoryAlreadyExistsPage()
        {
            return ErrorPageValidation(ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'APPLICATION ERROR #1500')]")));
        }

        #endregion

        private ResultModel ErrorPageValidation(bool validation)
        {
            return new ResultModel()
            {
                result = validation,
                message = validation ? AssertionsMessages.ErrorDisplayedSuccess : AssertionsMessages.ErrorDisplayedFail
            };
        }
    }
}
