using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Pages;

namespace Mantis.Automacao.tst.Flows
{
    public static class CreateUser
    {
        public static void EnterCreateUserPage()
        {
            var userPage = new UserPage();
            var manageOverviewPage = new ManageOverviewPage();
            var manageUserPage = new ManageUserPage();

            userPage.sideMenu.ClickManageOverview();
            manageOverviewPage.manageMenu.ClickManageUsers();
            manageUserPage.ClickCreateNewUser();
        }

        public static void FillNewUserInformation(UserModel newUser)
        {
            var manageUserCreatePage = new ManageUserCreatePage();

            manageUserCreatePage.FillUserName(newUser.username);
            manageUserCreatePage.FillRealName(newUser.realName);
            manageUserCreatePage.FillEmail(newUser.email);
            manageUserCreatePage.FillAccessLevel(newUser.accessLevel);
        }
    }
}
