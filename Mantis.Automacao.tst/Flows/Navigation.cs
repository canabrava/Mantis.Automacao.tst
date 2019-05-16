using Mantis.Automacao.tst.Pages;


namespace Mantis.Automacao.tst.Flows
{
    public static class Navigation
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

        public static void EnterCreateProjectPage()
        {
            var userPage = new UserPage();
            var manageOverviewPage = new ManageOverviewPage();
            var manageProjectPage = new ManageProjectPage();

            userPage.sideMenu.ClickManageOverview();
            manageOverviewPage.manageMenu.ClickManageProjects();
            manageProjectPage.ClickCreateNewProject();
        }

        public static void EnterManageProjectPage(int projectId)
        {
            var userPage = new UserPage();
            var manageOverviewPage = new ManageOverviewPage();
            var manageProjectPage = new ManageProjectPage();

            userPage.sideMenu.ClickManageOverview();
            manageOverviewPage.manageMenu.ClickManageProjects();
            manageProjectPage.ClickProject(projectId);
        }


    }
}
