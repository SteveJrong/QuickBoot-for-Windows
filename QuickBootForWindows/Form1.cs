using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuickBootForWindows
{
    public partial class frmQuickStart : Form
    {
        public frmQuickStart()
        {
            InitializeComponent();
        }

        private void btnSystemProperties_Click(object sender, EventArgs e)
        {
            Process.Start("sysdm.cpl");
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            Process.Start("control");
        }

        private void btnSysServices_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void btnDeviceManager_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void btnComputerManager_Click(object sender, EventArgs e)
        {
            Process.Start("compmgmt.msc");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void btnApplicationManager_Click(object sender, EventArgs e)
        {
            Process.Start("appwiz.cpl");
        }
    }
}
