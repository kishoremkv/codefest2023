using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Listeningear.Helpers
{
	public class HelperClass
	{
        public static List<AdminModel> Adminlist = new List<AdminModel>()
        {
            new AdminModel{ password="123562",email="admin@gmail.com" ,role="Admin"},
            //new AdminModel{ password="123",username="31sg@gmail.com" ,role="User"},
        };
       

	}
}
