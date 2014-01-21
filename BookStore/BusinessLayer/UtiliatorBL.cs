using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class UtiliatorBL
    {
        public int login(string username, string password)
        {
            string criptat=password;

            //aplici criparea

            UtilizatorDL function = new UtilizatorDL();
            int x = function.login(username,password);

            return x;
        }
    }
}
