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
    public partial class frmPopUp : Form
    {
        private Form _mainForm;

        private int CountDownForDelay = 10;

        public frmPopUp(Form mainForm)
        {
            _mainForm = mainForm;
            
            InitializeComponent();
            btnOK.Text = CountDownForDelay.ToString();
            this.TopMost = true;

        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            timStartDelay.Start();
            
        }

        private void timStartDelay_Tick(object sender, EventArgs e)
        {
            if (CountDownForDelay > 0)
            {
                CountDownForDelay--;
                btnOK.Text = CountDownForDelay.ToString();
                this.Activate();
            }
            else
            {
                btnOK.Text = "OK";
                timStartDelay.Stop();
                btnOK.Enabled = true;

            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            _mainForm.Enabled = true;
            _mainForm.Activate();
            this.Close();

            

        }

        private void lnklbDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.lnklbDonate.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://yasobe.ru/na/mazda_as_built_editor");
        }
    }
}
