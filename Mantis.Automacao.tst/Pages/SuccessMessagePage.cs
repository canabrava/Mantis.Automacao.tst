using Mantis.Automacao.tst.Bases;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class SuccessMessagePage : PageBase
    {
        #region Mapping

        By btnProcced = By.XPath("//*[contains(text(), 'Clique aqui para prosseguir')]");

        #endregion

        #region Actions

        public void ClickProceed()
        {
            Click(btnProcced);
        }

        public ResultModel AmInUserCreatedSuccessPage(string accessLevel)
        {
            var amInUserCreatedSuccessPage = ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'Usuário criado com um nível de acesso de " + accessLevel + " ')]"));

            return new ResultModel()
            {
                result = amInUserCreatedSuccessPage,
                message = amInUserCreatedSuccessPage ? AssertionsMessages.UserCreatedSucces : AssertionsMessages.UserCreatedFail
            };
        }

        public ResultModel AmInOperationSuccessPage()
        {
            var amInOperationSuccessPage = ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'Operação realizada com sucesso.')]"));

            return new ResultModel()
            {
                result = amInOperationSuccessPage,
                message = amInOperationSuccessPage ? AssertionsMessages.OperationSuccess : AssertionsMessages.OperationFail
            };
        }

        #endregion
    }
}
                                                                                                                                                