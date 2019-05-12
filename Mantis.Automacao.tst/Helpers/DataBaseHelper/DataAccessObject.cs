using System;
using System.Data;
using System.Data.SqlClient;

namespace Mantis.Automacao.tst.Helpers.DataBaseHelper
{
    class DataAccessObject : IDisposable
    {
        private SqlCommand command { get; set; }
        private SqlConnection sqlConnection { get; set; }
        public string text = string.Empty;

        public DataAccessObject(SqlConnection connection)
        {
            Dispose(false);
            sqlConnection = connection;
        }

        public void ExecuteCommand()
        {
            SetConnection();
            command.ExecuteNonQuery();
        }

        public DataTable Select()
        {

            var dataTable = new DataTable();

            SetConnection();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            dataTable.Load(reader);

            return dataTable;

        }

        public void AddParameter(string variable, SqlParameter value, SqlDbType type)
        {
            command.Parameters.Add(variable, type);
            command.Parameters["variable"] = value;
        }

        private void SetConnection()
        {
            command.CommandText = text;
            command.Connection = sqlConnection;
            command.Connection.Open();
        }

        public void Dispoes()
        {
            Dispose(true);
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    command.Connection.Close();
                    text = string.Empty;
                }

                disposedValue = true;
            }
        }


        // Código adicionado para implementar corretamente o padrão descartável.
        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
