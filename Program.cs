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
            //personne p1 = new personne(3, "test", "test", "test", "test", "test");
            GestionEvenement gestion = new GestionEvenement();

            gestion.SupprimerEvennement(9);

            Application.Run(new Form1());


        }
    }
}
