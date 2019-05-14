namespace Mantis.Automacao.tst.Models
{
    public class UserModel
    {
        public string username { get; set; }
        public string realName { get; set; }
        public string email { get; set; }
        public string accessLevel { get; set; }

        public bool IsEqual(UserModel user)
        {
            if (user.username.Equals(username)
                && user.realName.Equals(realName)
                && user.email.Equals(email)
                && user.accessLevel.Equals(accessLevel)) return true;
            else return false;
        }
    }
}
