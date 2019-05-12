using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #endregion
    }
}
