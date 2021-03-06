// ReSharper disable InconsistentNaming

namespace Two_Windows_Demo
{
    using System;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;

    public partial class Form2 : Form
    {
        public Control Screen
        {
            get
            {
                return pnScreen;
            }
        }

        public void LogLicense(string message)
        {
            if (cbLicensing.Checked)
            {
                mmError.Text += "LICENSING:" + Environment.NewLine + message + Environment.NewLine;
            }
        }

        public void Log(string message)
        {
            mmError.Text = mmError.Text + message + Environment.NewLine;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mmError.Clear();
        }



    }
}

// ReSharper restore InconsistentNaming
