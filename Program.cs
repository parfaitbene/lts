using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LTS2
{
    static class Program
    {
        public static MySqlConnection con;
        private static string connectionString = "server=localhost;database=lts;uid=root;pwd=rootpwd!;";
       
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // db connection
            con = new MySqlConnection(connectionString);

            try{
                con.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            Application.Run(new AppForm());
        }
    }
}
