using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantis.Automacao.tst.Pages
{
    class ManageUserPage : PageBase
    {
        #region Mapping

        By createNewUser = By.XPath("//*[@class='btn btn-primary btn-white btn-round']");

        #endregion

        #region Actions

        public void ClickCreateNewUser()
        {
            Click(createNewUser);
        }

        #endregion
    }
}
