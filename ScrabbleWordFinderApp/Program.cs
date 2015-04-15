using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace ScrabbleWordFinderApp
{
    static class Program
    {
        public static SplashScreen splashScreen;

        [STAThread]
        static void Main()
        {
            InitializeAssemblyPackagedInExe();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start splash screen in separate thread
            Thread splashThread = new Thread(new ThreadStart(
            delegate
            {
                splashScreen = new SplashScreen();
                Application.Run(splashScreen);
            }
            ));

            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();


            // Start main form
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Load += new EventHandler(mainForm_Load);
            Application.Run(homeWindow);
        }

        static void mainForm_Load(object sender, EventArgs e)
        {
            //close splash
            if (splashScreen == null)
            {
                return;
            }

            splashScreen.Invoke(new Action(splashScreen.Close));
            splashScreen.Dispose();
            splashScreen = null;

            HomeWindow homeWindow = (HomeWindow)sender;
            homeWindow.Show();
            homeWindow.Activate();
        }

        private static void InitializeAssemblyPackagedInExe()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                String resourceName = "ScrabbleWordFinderApp." + new AssemblyName(args.Name).Name + ".dll";//AssemblyLoadingAndReflection

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    Byte[] assemblyData = new Byte[stream.Length];

                    stream.Read(assemblyData, 0, assemblyData.Length);

                    return Assembly.Load(assemblyData);

                }

            };

        }
    }
}
