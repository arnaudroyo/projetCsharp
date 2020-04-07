using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpB2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            GestionEvenement gestion;
         /*   evennement evennement = new evennement("PGW", 5, 500, "8 rue de ","Paris", "france", new DateTime(2019, 07, 04, 0,0,0), 400, 1);
            evennement evennement2 = new evennement("foire du village", 6, 500,"au village" , "Paris", "france", new DateTime(2019, 07, 04, 0, 0, 0), 0, 1);
            evennement evennement3 = new evennement("coronavirus", 7, 6000000, "partout", "Paris", "france", new DateTime(2019, 7, 04, 0, 0, 0), 10000, 1);
            gestion.AjouterEvennement(evennement);
            gestion.AjouterEvennement(evennement2);
            gestion.AjouterEvennement(evennement3);
            */
        }
    }
}
