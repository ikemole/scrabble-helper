using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrabbleWordFinderApp
{
    public class HomeWindowController
    {
        private HomeWindow homeWindow;
        private ContestWindow contestWindow;
        private CheatWindow cheatWindow;
        private ScrabbleWordFinderSession wordFinderSession;

        public HomeWindowController(HomeWindow homeWindow)
        {
            this.homeWindow = homeWindow;
            this.contestWindow = new ContestWindow();
            this.cheatWindow = new CheatWindow();
            this.wordFinderSession = ScrabbleWordFinderSession.getInstance();
        }

        public void launchContestWindow()
        {
            contestWindow.Location = homeWindow.Location;
            contestWindow.StartPosition = FormStartPosition.Manual;
            contestWindow.Show();
            contestWindow.Focus();
        }

        public void launchCheatWindow()
        {
            cheatWindow.Location = homeWindow.Location;
            cheatWindow.StartPosition = FormStartPosition.Manual;
            cheatWindow.Show();
            cheatWindow.Focus();
        }

        public void initializeGlobalResources()
        {
            try
            {
                wordFinderSession.Initialize();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error during initialization");
            }
        }

    }
}
