﻿using Mantis.Automacao.tst.Bases;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ManageProjectPage : PageBase
    {
        #region Mapping

        By btnCreateNewProject = By.XPath("//*[contains(text(), 'Criar Novo Projeto')]");

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
