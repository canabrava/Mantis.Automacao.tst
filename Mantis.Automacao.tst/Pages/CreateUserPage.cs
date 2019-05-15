using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantis.Automacao.tst.Pages
{
    class CreateUserPage : PageBase
    {

        #region Mapping

        By fieldUserName = By.XPath("//*[@id='user-username']");

        By fieldRealName = By.XPath("//*[@id='user-realname']");

        By fieldEmail = By.XPath("//*[@id='email-field']");

        By selectorAccessLevel = By.XPath("//*[@id='user-access-level']");

        By checkBoxUserEnabled = By.XPath("//*[@id='user-enabled']");

        By checkBoxUserProtected = By.XPath("//*[@id='user-protected']");

        By btnCreateUser = By.XPath("//*[@class='btn btn-primary btn-white btn-round']");

        #endregion

        #region Actions

        public void FillUserName(string username)
        {
            SendKeys(fieldUserName, username);
        }

        public void FillRealName(string realname)
        {
            SendKeys(fieldRealName, realname);
        }

        public void FillEmail(string email)
        {
            SendKeys(fieldEmail, email);
        }

        public void FillAccessLevel(string accessLevel)
        {
            SendKeys(selectorAccessLevel, accessLevel);
        }

        public void ClickCreateUser()
        {
            Click(btnCreateUser);
        }


        #endregion
    }
}
