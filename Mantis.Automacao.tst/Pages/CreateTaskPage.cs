using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class CreateTaskPage : PageBase
    {

        #region Mapping

        By fieldCategory = By.Id("category_id");

        By fieldReproducibility = By.Id("reproducibility");

        By fieldSeverity = By.Id("severity");

        By fieldPriority = By.Id("priority");

        By fieldHandler = By.Id("handler_id");

        By fieldSummary = By.Id("summary");

        By fieldDescription = By.Id("description");

        By fieldStepsToReproduce = By.Id("steps_to_reproduce");

        By fieldAdditionalInfo = By.Id("additiona_info");

        By radioBtnPublic = By.XPath("//*[contains(text(), 'público')]");

        By radioBtnPrivated = By.XPath("//*[contains(text(), 'privado')]");

        By boxCreateMoreTasks = By.XPath("//*[contains(text(), 'selecione para criar mais tarefas')]");

        By btnCreateNewTask = By.XPath("//*[@class= 'btn btn-primary btn-white btn-round']");

        #endregion

        #region Actions



        #endregion


    }
}
