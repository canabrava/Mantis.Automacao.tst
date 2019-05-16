namespace Mantis.Automacao.tst.Models
{
    public class ProjectModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string viewState { get; set; }
        public string description { get; set; }

        public bool IsEqual(ProjectModel project)
        {
            return name.Equals(project.name)
                   && status.Equals(project.status)
                   && viewState.Equals(project.viewState)
                   && description.Equals(project.description);
        }
    }
}
