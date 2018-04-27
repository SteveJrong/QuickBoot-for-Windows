using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using QuickBootForWindows.common;
using QuickBootForWindows.components;

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

        private void frmQuickStart_Load(object sender, EventArgs e)
        {
            string javaHomePath = Environment.GetEnvironmentVariable("JAVA_HOME");
            this.tBJavaHomePath.Text = !String.IsNullOrEmpty(javaHomePath) ? javaHomePath : "未安装Java";

            string mavenPathOne = Environment.GetEnvironmentVariable("MAVEN_HOME");
            string mavenPathTwo = Environment.GetEnvironmentVariable("M2_HOME");
            if (!string.IsNullOrEmpty(mavenPathOne))
            {
                this.tBMavenPath.Text = mavenPathOne;
            }
            else if (!string.IsNullOrEmpty(mavenPathTwo))
            {
                this.tBMavenPath.Text = mavenPathTwo;
            }
            else
            {
                this.tBMavenPath.Text = "未安装Maven";
            }

            string gradlePath = Environment.GetEnvironmentVariable("GRADLE_HOME");
            this.tBGradlePath.Text = !String.IsNullOrEmpty(gradlePath) ? gradlePath : "未安装Gradle";
        }

        private void tBJavaHomePath_Click(object sender, EventArgs e)
        {
            Utils.copyTextBoxContentToClipBoard(this.tBJavaHomePath);
        }

        private void tBMavenPath_Click(object sender, EventArgs e)
        {
            Utils.copyTextBoxContentToClipBoard(this.tBMavenPath);
        }

        private void tBGradlePath_Click(object sender, EventArgs e)
        {
            Utils.copyTextBoxContentToClipBoard(this.tBGradlePath);
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            fmChooseColor chooseColor = new fmChooseColor();
            chooseColor.Show();
        }
    }
}
