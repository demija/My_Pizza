using MyPizza_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_GUI
{
    public class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }

        public static string GetMessage(string key)
        {
            ResourceManager rm = new ResourceManager("MyPizza_GUI.Messages", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}
