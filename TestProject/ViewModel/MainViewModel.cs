using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class MainViewModel : BaseViewModel
    {
        public string Login { set; get; }
        public string Password { set; get; }
        public Boolean AccessGranted { set; get; }
        public List<User> UserList { set; get; }

        public MainViewModel()
        {
            UserList = new List<User>()            //initiates some default data
            {
                {new Administrator("admin","admin") },
                {new User("user", "user")},
            };
        }

        public bool CheckCredentials() //checks if user login and password match the data
        {

            foreach (User user in UserList)
            {
                if (Login == user.Login && Password == user.Password)
                {
                    AccessGranted = (user is Administrator) ? true : false;
                    return true;
                }
            }
            return false;
        }
    }
}
