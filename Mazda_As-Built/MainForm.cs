using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mazda_As_Built
{
    public partial class frmMain : Form
    {
        private bool FirstRun = true;

        public frmMain()
        {
            InitializeComponent();
            this.Text += " " + System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;

            //Disable main form
            this.Enabled = false;

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (FirstRun)
            {
                //Show pop up window
                frmPopUp frmPopUp = new frmPopUp(this);
                frmPopUp.Show();
                //Do not show popup window any more
                FirstRun = false;


            }
        }
    }
}
