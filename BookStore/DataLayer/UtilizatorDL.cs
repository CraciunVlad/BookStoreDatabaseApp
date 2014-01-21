using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UtilizatorDL
    {
        BookStoreEntities b = new BookStoreEntities();

        public int login(string username, string password)
        {
            var x = from utilizator in b.Utilizatoris
                    where utilizator.Username == username && utilizator.Parola == password
                    select utilizator;

            foreach (var a in x)
            {
                if (a.Username != string.Empty)
                    return 1;
            }

            return 0;
        }

    }
}
