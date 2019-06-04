﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace TechSupportSimplifier
{
    public partial class AppBase : Form
    {
        public bool driveOpen = false;
        public AppBase()
        {
            InitializeComponent();
        }

        private void AppBase_Load(object sender, EventArgs e)
        {
            textBoxCPU.Text = runCmd("wmic","cpu get name").Substring(43);
            textBoxFirmware.Text = runCmd("wmic","bios get biosversion").Substring(62);
            textBoxUptime.Text = runCmd("cmd", "/c systeminfo | find \"System Boot Time: \"").Substring(27);
            textBoxVersion.Text = runCmd("cmd","/c ver");

            if (runCmd("wmic", "path SoftwareLicensingProduct where LicenseStatus='1' get Name").Contains("Windows"))
            {
                textBoxActivated.Text = "Yes";
            }
            else
            {
                textBoxActivated.Text = "No";
            }

            textBoxLicense.Text = "sorry this is borked rn";
        }

        private string runCmd(string exe, string args)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = exe;
            proc.StartInfo.Arguments = args;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            return proc.StandardOutput.ReadToEnd();
        }

        private void buttonDISM_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("dism", "/Online /Cleanup-Image /RestoreHealth");
            }
            catch (Exception) { }
        }

        private void buttonSFC1_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("sfc", "/scannow");
            }
            catch (Exception) { }
        }

        private void buttonSFC2_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("sfc", "/verifyonly");
            }
            catch (Exception) { }
        }

        private void buttonUEFI_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c shutdown /r /fw /t 0");
            }
            catch (Exception) { }
        }

        private void buttonChkDsk_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("chkdsk", "/?");
            }
            catch (Exception) { }
        }

        private void buttonNetSh_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("netsh", "int ip reset");
            }
            catch (Exception) { }
        }

        private void buttonPUPs_Click(object sender, EventArgs e)
        {
            conSolo.StartProcess("wmic", "product");
            //string productOutput = runCmd("wmic", "product").ToLower();
            //if (productOutput.Contains("mcafee"))
            //{
            //    conSolo.StartProcess("cmd","/c echo McAfee");
            //}
            //if (productOutput.Contains("ccleaner"))
            //{
            //    conSolo.StartProcess("cmd", "/c echo CCleaner");
            //}
            //if (productOutput.Contains("adwcleaner"))
            //{
            //    conSolo.StartProcess("cmd", "/c echo AdwCleaner");
            //}
            //if (productOutput.Contains("registry"))
            //{
            //    conSolo.StartProcess("cmd", "/c echo Potential registry cleaners");
            //}
            //if (productOutput.Contains("visual studio"))
            //{
            //    conSolo.StartProcess("cmd", "/c echo Visual Studio");
            //}
            //if (productOutput.Contains("driver"))
            //{
            //    conSolo.StartProcess("cmd", "/c echo Potential driver updaters/boosters");
            //}
        }

        private void buttonAutomount_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c mountvol /N && mountvol /R && mountvol /E && echo Automount repair complete.");
            }
            catch (Exception) { }
        }

        private void buttonCupHolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (driveOpen)
                {
                    int ret = mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
                    driveOpen = false;
                }
                else
                {
                    int ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
                    driveOpen = true;
                }
            }
            catch (Exception) { }
        }
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

        private void buttonReboot_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c shutdown /r");
            }
            catch (Exception) { }
        }
    }
}