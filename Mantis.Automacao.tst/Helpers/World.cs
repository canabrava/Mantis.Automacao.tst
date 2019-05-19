using Mantis.Automacao.tst.Models;

namespace Mantis.Automacao.tst.Helpers
{
    class World
    {

        private static World INSTANCE { get; set; } = null;

        #region Constructor

        public static World GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new World();

                return INSTANCE;
            }
            else return INSTANCE;
            
        }

        public static void DestroiInstance()
        {
            INSTANCE = null;
        }

        #endregion

        #region Stored Variables

        private string userName = string.Empty;
        private UserModel user = new UserModel();
        private ProjectModel project = new ProjectModel();
        private string categoryName = string.Empty;

        #endregion

        #region Actions

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public string GetUserName()
        {
            return userName;
        }

        public void SetUser(UserModel newUser)
        {
            this.user = newUser;
        }

        public UserModel GetUser()
        {
            return user;
        }

        public void SetProject(ProjectModel newProject)
        {
            this.project = newProject;
        }

        public ProjectModel GetProject()
        {
            return project;
        }

        public void SetCategory(string categoryName)
        {
            this.categoryName = categoryName;
        }

        public string GetCategory()
        {
            return categoryName;
        }

        #endregion
    }
}
