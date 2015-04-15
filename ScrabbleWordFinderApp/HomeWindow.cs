using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace ScrabbleWordFinderApp
{
    public partial class HomeWindow : Form
    {
        HomeWindowController controller;

        public HomeWindow()
        {
            InitializeComponent();
            controller = new HomeWindowController(this);
            controller.initializeGlobalResources();
        }

        private void launchContestWindowBtn_Click(object sender, EventArgs e)
        {
            controller.launchContestWindow();
        }

        private void launchCheatWindowBtn_Click(object sender, EventArgs e)
        {
            controller.launchCheatWindow();
        }

        private void buttonLabel_mouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonLabel_mouseLeave(object sender, EventArgs e)
        {

        }

    }
}
