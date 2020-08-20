using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    static class Program
    {
        static SplashScreen splashscreen;
        public static Form1 bmiCalculator;
        public static Form2 bmiResult;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashscreen = new SplashScreen();
            splashscreen.Show();

            bmiCalculator = new Form1();
            bmiCalculator.Shown += bmiCalculator_Shown;

            bmiResult = new Form2();
            bmiResult.Shown += bmiResult_Shown;

            Application.Run(bmiCalculator);
        }
        private static void bmiCalculator_Shown(object sender, EventArgs e)
        {
            splashscreen.Hide();
        }
        private static void bmiResult_Shown(object sender, EventArgs e)
        {
            splashscreen.Hide();
        }
    }
}
