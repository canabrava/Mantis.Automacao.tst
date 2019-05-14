using Mantis.Automacao.tst.Helpers.DataBaseHelper.DbConnection;
using Mantis.Automacao.tst.Models;
using System.Data;
using System.Linq;

namespace Mantis.Automacao.tst.DBSteps
{
    class UserTableDAO : DBMantisDAL
    {

        public void ClearUserTable()
        {
            using (DAO)
            {
                DAO.text = deleteAllUsersButTheAdministrator;
                DAO.ExecuteCommand();
            }
        }

        public UserModel ReturnUser(string username)
        {
            var result = new DataTable();

            using (DAO)
            {
                DAO.text = selectUserByUsername;
                DAO.AddParameter("@USERNAME", username, SqlDbType.VarChar);
                result = DAO.Select();
            }

            return result.AsEnumerable().Select(x => new UserModel()
            {
                username = x.Field<string>("username"),
                realName = x.Field<string>("realname"),
                email = x.Field<string>("email"),
                accessLevel = x.Field<string>("access_level")
            }).First();
        }

        #region Querys

        private readonly string deleteAllUsersButTheAdministrator = @"DELETE FROM user_mantis_tables WHERE id_user <> 1";

        private readonly string selectUserByUsername = @"SELECT * FROM user_mantis_tables WHERE username = @USERNAME";

        #endregion

    }
}
