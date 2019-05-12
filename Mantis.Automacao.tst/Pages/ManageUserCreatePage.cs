using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ManageUserCreatePage : PageBase
    {
        #region Mapping

        By btnProcced = By.XPath("//*[contains(text(), 'Clique aqui para prosseguir')]");

        #endregion

        #region Actions

        public void ClickProceed()
        {
            Click(btnProcced);
        }

        public bool AnInManageUserCreatePage(string accessLevel)
        {
            return ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(), 'Usuário criado com um nível de acesso de " + accessLevel + " ')]"));
        }

        #endregion
    }
}
