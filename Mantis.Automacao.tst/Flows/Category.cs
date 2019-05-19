using Mantis.Automacao.tst.DBSteps;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
using System.Linq;

namespace Mantis.Automacao.tst.Flows
{
    public static class Category
    {
        public static ResultModel IsNewCategoryInDataBase(string categoryName)
        {
            var categoryTableDao = new CategoryTableDAO();

            var isCategoryInDataBase = categoryTableDao.ReturnCategory(categoryName).Any();

            return new ResultModel()
            {
                result = isCategoryInDataBase,
                message = isCategoryInDataBase ? AssertionsMessages.CategoryCreatedSucces : AssertionsMessages.CategoryCreatedFail
            };
        }

    }
}
