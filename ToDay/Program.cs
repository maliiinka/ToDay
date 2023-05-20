using ToDay.Database;

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
<<<<<<< HEAD
            IRepository repository = new Repository();
=======
            Repository repository = new Repository();
>>>>>>> 7290701 (Приняла)
            repository.ensureCreated();

             //To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}