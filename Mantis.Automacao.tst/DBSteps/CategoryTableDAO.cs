using Mantis.Automacao.tst.Helpers.DataBaseHelper.DbConnection;
using System.Data;
using System.Linq;

namespace Mantis.Automacao.tst.DBSteps
{
    class CategoryTableDAO : DBMantisDAL
    {
        public void ClearCategoryTable()
        {
            using (DAO)
            {
                DAO.text = clearCategoryTable;
                DAO.ExecuteCommand();
            }
        }

        public void InsertNewCategory(string categoryName)
        {
            using (DAO)
            {
                DAO.text = insertCategoryIntoCategoryTable;
                DAO.AddParameter("@NAME", categoryName, SqlDbType.VarChar);
                DAO.ExecuteCommand();
            }
        }

        public string ReturnCategory(string name)
        {
            var result = new DataTable();

            using (DAO)
            {
                DAO.text = selectCategoruByName;
                DAO.AddParameter("@NAME", name, SqlDbType.VarChar);
                result = DAO.Select();
            }

            return result.AsEnumerable().Select(x => x.Field<string>("name")).First();
        }

        //TODO - Montar as querys da tabela de projetos.
        private readonly string selectCategoruByName = @"";

        private readonly string clearCategoryTable = @"";

        private readonly string insertCategoryIntoCategoryTable = @"";
    }
}
