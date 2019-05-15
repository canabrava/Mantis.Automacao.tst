using Mantis.Automacao.tst.DBSteps;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Pages;
using Mantis.Automacao.tst.Resources;

namespace Mantis.Automacao.tst.Flows
{
    public static class CreateUser
    {
        public static void FillNewUserInformation(UserModel newUser)
        {
            var manageUserCreatePage = new CreateUserPage();

            manageUserCreatePage.FillUserName(newUser.username);
            manageUserCreatePage.FillRealName(newUser.realName);
            manageUserCreatePage.FillEmail(newUser.email);
            manageUserCreatePage.FillAccessLevel(newUser.accessLevel);
        }

        public static ResultModel IsCreatedUserInDataBase(UserModel newUser)
        {
            var userTableDao = new UserTableDAO();

            var userInDb = userTableDao.ReturnUser(newUser.username);

            var isCreatedUserInDataBase = newUser.IsEqual(userInDb);

            return new ResultModel()
            {
                result = isCreatedUserInDataBase,
                message = isCreatedUserInDataBase ? AssertionsMessages.UserCreatedSucces : AssertionsMessages.UserCreatedFail
            };

        }
    }
}
