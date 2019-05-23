using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Pages;


namespace Mantis.Automacao.tst.Flows
{
    public static class Navigation
    {
        public static void GoBack()
        {
            DriverFactory.INSTANCE.Navigate().Back();
        }

        public static void EnterCreateUserPage()
        {
            var userPage = new UserPage();
            var manageOverviewPage = new ManageOverviewPage();
            var manageUserPage = new ManageUserPage();

            userPage.sideMenu.ClickManageOverview();
            manageOverviewPage.manageMenu.ClickManageUsers();
            manageUserPage.ClickCreateNewUser();
        }

        public static void EnterManageProjectsPage()
        {
            var userPage = new UserPage();
            var manageOverviewPage = new ManageOverviewPage();

            userPage.sideMenu.ClickManageOverview();
            manageOverviewPage.manageMenu.ClickManageProjects();
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

        public static void EnterProjectPage(int projectId)
        {
            var userPage = new UserPage();
            var manageOverviewPage = new ManageOverviewPage();
            var manageProjectPage = new ManageProjectPage();

            userPage.sideMenu.ClickManageOverview();
            manageOverviewPage.manageMenu.ClickManageProjects();
            manageProjectPage.ClickProject(projectId);
        }

        public static void EnterCreateTaskPage()
        {
            var userPage = new UserPage();

            userPage.sideMenu.ClickCreateTask();
        }


    }
}
