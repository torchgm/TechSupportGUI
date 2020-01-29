using System;
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
            textBoxSerial.Text = runCmd("wmic", "bios get serialnumber").Substring(26);
            textBoxMaxMem.Text = runCmd("wmic", "memphysical get maxcapacity").Substring(13);
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

            try
            {
                conSolo.StartProcess("cmd", "/c echo Be careful! These buttons are not to be played with. They can alter settings, delete files, change your version and deactivate Windows. Use them at your own risk.");
            }
            catch (Exception) { }
        }



        // -- Something something make a new method for magicing processes. --

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
                conSolo.StartProcess("chkdsk", "/f C:");
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
            // -- This is all borked because the console is stupid; I'll fix it later. --

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

        private void buttonCrisis_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c echo Formatting C:\\... & echo Done!");
            }
            catch (Exception) { }
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c shutdown /p /f");
            }
            catch (Exception) { }
        }

        private void buttonIPConfig_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("ipconfig", "/all");
            }
            catch (Exception) { }
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("ping", "1.1.1.1");
            }
            catch (Exception) { }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            conSolo.ClearOutput();
        }

        private void buttonBattery_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c cd C:\\Windows\\system32 && powercfg /batteryreport && start battery-report.html");
            }
            catch (Exception) { }
        }

        private void buttonIP_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("ipconfig", "/flushdns");
            }
            catch (Exception) { }
        }

        private void buttonWsReset_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("wsreset", "");
            }
            catch (Exception) { }
        }

        private void buttonAdminOn_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("net", "user administrator /active:yes");
            }
            catch (Exception) { }
        }

        private void buttonRdpOn_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("reg", "add \"hklm\\system\\currentcontrolset\\control\\terminal server\" /f /v fDenyTSConnections /t REG_DWORD /d 0");
            }
            catch (Exception) { }
        }

        private void buttonAdminOff_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("net", "user administrator /active:no");
            }
            catch (Exception) { }
        }

        private void buttonRdpOff_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("reg", "add \"hklm\\system\\currentcontrolset\\control\\terminal server\" /f /v fDenyTSConnections /t REG_DWORD /d 1");
            }
            catch (Exception) { }
        }

        private void buttonWinPro_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c slmgr /upk && slmgr /ipk VK7JG-NPHTM-C97JM-9MPGT-3V66T");
            }
            catch (Exception) { }
        }

        private void buttonWinEdu_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c slmgr /upk && slmgr /ipk YNMGQ-8RYV3-4PGQ3-C8XTP-7CFBY");
            }
            catch (Exception) { }
        }

        private void buttonWinEnt_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c slmgr /upk && slmgr /ipk DXG7C-N36C4-C4HTG-X4T3X-2YV77");
            }
            catch (Exception) { }
        }

        private void buttonWinPfW_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c slmgr /upk && slmgr /ipk XGVPP-NMH47-7TTHJ-W3FW7-8HV2C");
            }
            catch (Exception) { }
        }

        private void buttonPrintSpool_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c net stop spooler && del %systemroot%\\System32\\spool\\printers\\* /Q && net start spooler");
            }
            catch (Exception) { }
        }

        private void buttonReBCD_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("bootrec", "/rebuildbcd");
            }
            catch (Exception) { }
        }

        private void buttonFixBoot_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("bootrec", "/fixboot");
            }
            catch (Exception) { }
        }

        private void buttonFixMBR_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("bootrec", "/fixmbr");
            }
            catch (Exception) { }
        }

        private void buttonScanOS_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("bootrec", "/scanos");
            }
            catch (Exception) { }
        }

        private void buttonExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c taskkill /f /im explorer.exe && PING localhost -n 6 >NUL && start C:\\windows\\explorer");
            }
            catch (Exception) { }
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("wmic", "computersystem get model,name,manufacturer,systemtype");
            }
            catch (Exception) { }
        }

        private void buttonMSIStart_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("cmd", "/c reg add \"HKLM\\SYSTEM\\CurrentControlSet\\services\\msiserver\" /v Start /t REG_DWORD /d 2 /f && net start msiserver");
            }
            catch (Exception) { }
        }

        private void ButtonGrabMCT_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDiskHealth_Click(object sender, EventArgs e)
        {
            try
            {
                conSolo.StartProcess("powershell", "/c Get-Disk | select number, operation*, health*, friendly*, size");
            }
            catch (Exception) { }
        }
    }
}
