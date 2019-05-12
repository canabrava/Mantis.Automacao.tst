using Mantis.Automacao.tst.Helpers.DataBaseHelper.DbConnection;
using System.Data;

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

        public DataTable ReturnClient(string username)
        {
            var result = new DataTable();

            using (DAO)
            {
                DAO.text = selectUserByUsername;
                DAO.AddParameter("@USERNAME", username, SqlDbType.VarChar);
                result = DAO.Select();
            }

            return result;
        }

        #region Querys

        private readonly string deleteAllUsersButTheAdministrator = @"DELETE FROM user_mantis_tables WHERE id_user <> 1";

        private readonly string selectUserByUsername = @"SELECT * FROM user_mantis_tables WHERE username = @USERNAME";

        #endregion

    }
}
