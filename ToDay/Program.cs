using ToDay.Database;
using ToDay.Database.Models;

namespace ToDay
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Repository repository = new Repository();
            repository.ensureCreated();
            //Comment this before production
<<<<<<< HEAD
            //repository.fillTables();
=======
            repository.fillTables();
>>>>>>> ecd47e6 (Дебег 1.2)

             //To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}