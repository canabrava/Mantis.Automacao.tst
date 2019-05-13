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
        private UserModel newUser = new UserModel();

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

        public void SetNewUser(UserModel newUser)
        {
            this.newUser = newUser;
        }

        public UserModel GetNewUser()
        {
            return newUser;
        }

        #endregion
    }
}
