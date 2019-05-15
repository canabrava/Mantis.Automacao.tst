using Mantis.Automacao.tst.Helpers.DataBaseHelper.DbConnection;
using Mantis.Automacao.tst.Models;
using System.Data;
using System.Linq;

namespace Mantis.Automacao.tst.DBSteps
{
    class ProjectTableDAO : DBMantisDAL
    {
        public void ClearProjectTable()
        {
            using (DAO)
            {
                DAO.text = clearProjectTable;
                DAO.ExecuteCommand();
            }
        }

        public void InsertNewProject(ProjectModel newProject)
        {
            using (DAO)
            {
                DAO.text = insertProjectIntoProjectTable;
                DAO.AddParameter("@NAME", newProject.name, SqlDbType.VarChar);
                DAO.AddParameter("@STATUS", newProject.status, SqlDbType.VarChar);
                DAO.AddParameter("@VIEW_STATE", newProject.viewState, SqlDbType.VarChar);
                DAO.AddParameter("@DESCRIPTION", newProject.description, SqlDbType.VarChar);
                DAO.ExecuteCommand();
            }
        }

        public ProjectModel ReturnProject(string name)
        {
            var result = new DataTable();

            using (DAO)
            {
                DAO.text = selectProjectByName;
                DAO.AddParameter("@NAME", name, SqlDbType.VarChar);
                result = DAO.Select();
            }

            return result.AsEnumerable().Select(x => new ProjectModel()
            {
                name = x.Field<string>("name"),
                status = x.Field<string>("status"),
                viewState = x.Field<string>("status"),
                description = x.Field<string>("description")
            }).First();
        }

        #region Querys
        //TODO - Montar as querys da tabela de projetos.
        private readonly string selectProjectByName = @"";

        private readonly string clearProjectTable = @"";

        private readonly string insertProjectIntoProjectTable = @"";

        #endregion
    }
}
