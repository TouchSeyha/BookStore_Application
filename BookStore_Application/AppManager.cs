using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace BookStore_Application
{
    public class AppManager
    {
        private static AppManager instance;
        private AppManager() { }

        public static AppManager GetInstance()
        {
            if (instance == null)
            {
                instance = new AppManager();
            }
            return instance;
        }
        public Employee loginEmployee { get; set; }
       
    }
}
