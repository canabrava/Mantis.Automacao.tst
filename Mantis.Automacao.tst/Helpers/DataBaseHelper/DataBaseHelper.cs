using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Mantis.Automacao.tst.Helpers.DataBaseHelper
{

    class DataBaseHelper
    {

        public DataAccessObject DAO;

        public DataBaseHelper(string cntString)
        {
            DAO = new DataAccessObject(new SqlConnection(ConfigurationSettings.AppSettings[cntString]));
        }

    }
}
