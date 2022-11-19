using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Toy.Components
{
    internal class Navigation
    {
        public static bool isAuth = false;
        public static MainWindow main;
        public static User AuthUser = null;
        public static List<User> navs = new List<User>();
        public static void NextPage(User nav)
        {
            navs.Add(nav);
            Update(nav);
        }

        private static void Update(User nav)
        {
    
        }
    }
}
