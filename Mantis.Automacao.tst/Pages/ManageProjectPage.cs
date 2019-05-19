using Mantis.Automacao.tst.Bases;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ManageProjectPage : PageBase
    {
        #region Mapping

        By fieldCategory = By.XPath("//*[@class='input-sm']");

        By btnCreateNewProject = By.XPath("//*[contains(text(), 'Criar Novo Projeto')]");

        By btnAddCategory = By.XPath("//*[@value='Adicionar Categoria']");


        #endregion

        #region Actions

        public void ClickCreateNewProject()
        {
            Click(btnCreateNewProject);
        }

        public void ClickProject(int projectID)
        {
            Click(By.XPath("//*[@href='manage_proj_edit_page.php?project_id=" + projectID + "']"));
        }

        public void ClickAddCategory()
        {
            Click(btnAddCategory);
        }

        public void FillCategory(string category)
        {
            SendKeys(fieldCategory, category);
        }

        public ResultModel AmInManageProjectPage()
        {
            var amInManageProjectPage = ReturnIfElementIsDisplayed(btnCreateNewProject);

            return new ResultModel()
            {
                result = amInManageProjectPage,
                message = amInManageProjectPage ? AssertionsMessages.AmInManageProjectPageSuccess : AssertionsMessages.AmInManageProjectPageFail
            };
        }

        #endregion
    }
}
