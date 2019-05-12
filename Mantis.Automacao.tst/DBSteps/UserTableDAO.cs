using Mantis.Automacao.tst.Helpers.DataBaseHelper.DbConnection;

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

        #region Querys

        private readonly string deleteAllUsersButTheAdministrator = @"DELETE FROM user_mantis_tables WHERE id_user <> 1";

        #endregion

    }
}
