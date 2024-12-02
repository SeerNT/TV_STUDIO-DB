using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace БД_Телестудии
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static List<object> openForms = new List<object>();

        public static Authorization authForm;
        public static FilmCrewForm filmCrewForm;
        public static BroadcastPlaybackPlanForm broadcastsForm;
        public static CreationStageForm creationStageForm;
        public static Director_BroadcastPlaybackPlanForm director_broadcastsForm;
        public static ManagerMainForm managerMainForm;

        public static string conString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=True";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            authForm = new Authorization();
            authForm.Show();

            Application.Run();
        }
    }
}
