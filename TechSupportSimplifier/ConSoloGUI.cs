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
            try
            {
                string CPU = runCmd("wmic", "cpu get name");
                String[] CPUCount = CPU.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
                textBoxCPU.Text = CPU.Substring((CPU.Length / CPUCount.Length) + 15);
            }
            catch (Exception) { }
            try
            {
                string Firmware = runCmd("wmic", "bios get biosversion");
                textBoxFirmware.Text = Firmware.Substring((Firmware.Length / 2) - 1);
            }
            catch (Exception) { }
            try
            {
                string Serial = runCmd("wmic", "bios get serialnumber");
                textBoxSerial.Text = Serial.Substring((Serial.Length / 2) - 1);
            }
            catch (Exception) { }
            try
            {
                String MaxMem = runCmd("wmic", "memphysical get maxcapacity");
                String[] MaxMemCount = MaxMem.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
                textBoxMaxMem.Text = MaxMem.Substring((MaxMem.Length / MaxMemCount.Length) + MaxMemCount.Length);
            }
            catch (Exception) { }
            try
            {
                textBoxUptime.Text = runCmd("cmd", "/c systeminfo | find \"System Boot Time: \"").Substring(27);
            }
            catch (Exception) { }
            try
            {
                textBoxVersion.Text = runCmd("cmd", "/c ver").Substring(20);
            }
            catch (Exception) { }

            if (runCmd("wmic", "path SoftwareLicensingProduct where LicenseStatus='1' get Name").Contains("Windows"))
            {
                textBoxActivated.Text = "Yes";
            }
            else
            {
                textBoxActivated.Text = "No";
            }
            try
            {
                string License = runCmd("wmic", "os get caption");
                textBoxLicense.Text = License.Substring((License.Length / 2) + 17);
            }
            catch (Exception) { }
            try
            {
                conSolo.StartProcess("cmd", "/c echo Be careful! These buttons are not to be played with. They can alter settings, delete files, change your version and deactivate Windows. Use them at your own risk.");
            }
            catch (Exception) { }
        }



        // -- Something something make a new method for magicing processes maybe. --

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
            // Yes, I will sort out the no-space strings. Later though, it's not necessary.
            conSolo.StartProcess("powershell", "-c $string=Get-ItemProperty HKLM:\\Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\* | Select-Object DisplayName, DisplayVersion, Publisher, InstallDate | Format-Table –AutoSize | Out-String; if($string | Select-String -Pattern \"mcafee\" -SimpleMatch) {echo \"McAfee\"}; if($string | Select-String -Pattern \"ccleaner\" -SimpleMatch) {echo \"CCleaner\"}; if($string | Select-String -Pattern \"adwclean\" -SimpleMatch) {echo \"AdwCleaner\"}; if($string | Select-String -Pattern \"registry\" -SimpleMatch) {echo \"Potential-RegistryCleaners\"};if($string | Select-String -Pattern \"driver\" -SimpleMatch) {echo \"Potential-DriverBoosters\"}; if($string | Select-String -Pattern \"booster\" -SimpleMatch) {echo \"Potential-DriverBoosters\"}; if($string | Select-String -Pattern \"Avast\" -SimpleMatch) {echo \"Avast\"}; if($string | Select-String -Pattern \"avg\" -SimpleMatch) {echo \"AVG\"}; if($string | Select-String -Pattern \"pinball\" -SimpleMatch) {echo \"Pinball\"}; if($string | Select-String -Pattern \"iobit\" -SimpleMatch) {echo \"IOBit utilities installed\"}; if($string | Select-String -Pattern \"chromium\" -SimpleMatch) {echo \"Chromium\"};");
            
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
