using Gen_Sim.Controller;
using Gen_Sim.Data;
using Gen_Sim.Model;
using Gen_Sim.View;

namespace Gen_Sim
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DbContext dbContext = new DbContext();
            dbContext.CreateDataBase();
            Application.Run(new FormularioPrincipal());
        }
    }
}