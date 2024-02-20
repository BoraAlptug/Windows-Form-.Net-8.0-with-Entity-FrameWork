using OdemePlanı_7.UI.Forms;
using OdemePlanı_7.UIService;


namespace OdemePlanı_7
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

            IPayPlanUIService uIService=new PayPlanUIService();

            Application.Run(new PayPlanPreviewList_frm(uIService));
        }
    }
}