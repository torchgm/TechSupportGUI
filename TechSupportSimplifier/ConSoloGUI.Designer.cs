﻿namespace TechSupportSimplifier
{
    partial class AppBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBase));
            this.labelFirmware = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelActivated = new System.Windows.Forms.Label();
            this.textBoxCPU = new System.Windows.Forms.TextBox();
            this.textBoxFirmware = new System.Windows.Forms.TextBox();
            this.textBoxUptime = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.textBoxActivated = new System.Windows.Forms.TextBox();
            this.textBoxLicense = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelUptime = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.BasicInfoPanel = new System.Windows.Forms.Panel();
            this.textBoxMaxMem = new System.Windows.Forms.TextBox();
            this.labelMaxMem = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.labelSerial = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.buttonDiskHealth = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.buttonMSIStart = new System.Windows.Forms.Button();
            this.buttonGrabMCT = new System.Windows.Forms.Button();
            this.buttonExplorer = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonReBCD = new System.Windows.Forms.Button();
            this.buttonScanOS = new System.Windows.Forms.Button();
            this.buttonFixBoot = new System.Windows.Forms.Button();
            this.buttonFixMBR = new System.Windows.Forms.Button();
            this.buttonWinPfW = new System.Windows.Forms.Button();
            this.buttonWinEnt = new System.Windows.Forms.Button();
            this.buttonWinPro = new System.Windows.Forms.Button();
            this.buttonWinEdu = new System.Windows.Forms.Button();
            this.buttonAdminOff = new System.Windows.Forms.Button();
            this.buttonPrintSpool = new System.Windows.Forms.Button();
            this.buttonRdpOn = new System.Windows.Forms.Button();
            this.buttonRdpOff = new System.Windows.Forms.Button();
            this.buttonAdminOn = new System.Windows.Forms.Button();
            this.buttonWsreset = new System.Windows.Forms.Button();
            this.buttonBattery = new System.Windows.Forms.Button();
            this.buttonflushdns = new System.Windows.Forms.Button();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonIPConfig = new System.Windows.Forms.Button();
            this.buttonCupHolder = new System.Windows.Forms.Button();
            this.buttonAutomount = new System.Windows.Forms.Button();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.conSolo = new ConsoleControl.ConsoleControl();
            this.buttonPUPs = new System.Windows.Forms.Button();
            this.buttonNetSh = new System.Windows.Forms.Button();
            this.buttonCrisis = new System.Windows.Forms.Button();
            this.buttonChkDsk = new System.Windows.Forms.Button();
            this.buttonUEFI = new System.Windows.Forms.Button();
            this.buttonSFC2 = new System.Windows.Forms.Button();
            this.buttonSFC1 = new System.Windows.Forms.Button();
            this.buttonDISM = new System.Windows.Forms.Button();
            this.BasicInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirmware
            // 
            this.labelFirmware.AutoSize = true;
            this.labelFirmware.Location = new System.Drawing.Point(6, 38);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(52, 13);
            this.labelFirmware.TabIndex = 1;
            this.labelFirmware.Text = "Firmware:";
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Location = new System.Drawing.Point(11, 190);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(47, 13);
            this.labelLicense.TabIndex = 2;
            this.labelLicense.Text = "License:";
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.Location = new System.Drawing.Point(3, 164);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(55, 13);
            this.labelActivated.TabIndex = 0;
            this.labelActivated.Text = "Activated:";
            // 
            // textBoxCPU
            // 
            this.textBoxCPU.Location = new System.Drawing.Point(64, 9);
            this.textBoxCPU.Name = "textBoxCPU";
            this.textBoxCPU.ReadOnly = true;
            this.textBoxCPU.Size = new System.Drawing.Size(578, 20);
            this.textBoxCPU.TabIndex = 3;
            // 
            // textBoxFirmware
            // 
            this.textBoxFirmware.Location = new System.Drawing.Point(64, 35);
            this.textBoxFirmware.Name = "textBoxFirmware";
            this.textBoxFirmware.ReadOnly = true;
            this.textBoxFirmware.Size = new System.Drawing.Size(578, 20);
            this.textBoxFirmware.TabIndex = 4;
            // 
            // textBoxUptime
            // 
            this.textBoxUptime.Location = new System.Drawing.Point(64, 110);
            this.textBoxUptime.Name = "textBoxUptime";
            this.textBoxUptime.ReadOnly = true;
            this.textBoxUptime.Size = new System.Drawing.Size(578, 20);
            this.textBoxUptime.TabIndex = 5;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(64, 136);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(578, 20);
            this.textBoxVersion.TabIndex = 6;
            // 
            // textBoxActivated
            // 
            this.textBoxActivated.Location = new System.Drawing.Point(64, 162);
            this.textBoxActivated.Name = "textBoxActivated";
            this.textBoxActivated.ReadOnly = true;
            this.textBoxActivated.Size = new System.Drawing.Size(578, 20);
            this.textBoxActivated.TabIndex = 7;
            // 
            // textBoxLicense
            // 
            this.textBoxLicense.Location = new System.Drawing.Point(64, 188);
            this.textBoxLicense.Name = "textBoxLicense";
            this.textBoxLicense.ReadOnly = true;
            this.textBoxLicense.Size = new System.Drawing.Size(578, 20);
            this.textBoxLicense.TabIndex = 8;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(13, 139);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 15;
            this.labelVersion.Text = "Version:";
            // 
            // labelUptime
            // 
            this.labelUptime.AutoSize = true;
            this.labelUptime.Location = new System.Drawing.Point(15, 113);
            this.labelUptime.Name = "labelUptime";
            this.labelUptime.Size = new System.Drawing.Size(43, 13);
            this.labelUptime.TabIndex = 16;
            this.labelUptime.Text = "Uptime:";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(26, 12);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(32, 13);
            this.labelCPU.TabIndex = 17;
            this.labelCPU.Text = "CPU:";
            // 
            // BasicInfoPanel
            // 
            this.BasicInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BasicInfoPanel.Controls.Add(this.textBoxMaxMem);
            this.BasicInfoPanel.Controls.Add(this.labelMaxMem);
            this.BasicInfoPanel.Controls.Add(this.textBoxSerial);
            this.BasicInfoPanel.Controls.Add(this.labelSerial);
            this.BasicInfoPanel.Controls.Add(this.buttonClear);
            this.BasicInfoPanel.Controls.Add(this.buttonShutdown);
            this.BasicInfoPanel.Controls.Add(this.button25);
            this.BasicInfoPanel.Controls.Add(this.button26);
            this.BasicInfoPanel.Controls.Add(this.button27);
            this.BasicInfoPanel.Controls.Add(this.button28);
            this.BasicInfoPanel.Controls.Add(this.button29);
            this.BasicInfoPanel.Controls.Add(this.button30);
            this.BasicInfoPanel.Controls.Add(this.button31);
            this.BasicInfoPanel.Controls.Add(this.button32);
            this.BasicInfoPanel.Controls.Add(this.button33);
            this.BasicInfoPanel.Controls.Add(this.button34);
            this.BasicInfoPanel.Controls.Add(this.button35);
            this.BasicInfoPanel.Controls.Add(this.button36);
            this.BasicInfoPanel.Controls.Add(this.buttonDiskHealth);
            this.BasicInfoPanel.Controls.Add(this.button14);
            this.BasicInfoPanel.Controls.Add(this.buttonMSIStart);
            this.BasicInfoPanel.Controls.Add(this.buttonGrabMCT);
            this.BasicInfoPanel.Controls.Add(this.buttonExplorer);
            this.BasicInfoPanel.Controls.Add(this.buttonDetails);
            this.BasicInfoPanel.Controls.Add(this.buttonReBCD);
            this.BasicInfoPanel.Controls.Add(this.buttonScanOS);
            this.BasicInfoPanel.Controls.Add(this.buttonFixBoot);
            this.BasicInfoPanel.Controls.Add(this.buttonFixMBR);
            this.BasicInfoPanel.Controls.Add(this.buttonWinPfW);
            this.BasicInfoPanel.Controls.Add(this.buttonWinEnt);
            this.BasicInfoPanel.Controls.Add(this.buttonWinPro);
            this.BasicInfoPanel.Controls.Add(this.buttonWinEdu);
            this.BasicInfoPanel.Controls.Add(this.buttonAdminOff);
            this.BasicInfoPanel.Controls.Add(this.buttonPrintSpool);
            this.BasicInfoPanel.Controls.Add(this.buttonRdpOn);
            this.BasicInfoPanel.Controls.Add(this.buttonRdpOff);
            this.BasicInfoPanel.Controls.Add(this.buttonAdminOn);
            this.BasicInfoPanel.Controls.Add(this.buttonWsreset);
            this.BasicInfoPanel.Controls.Add(this.buttonBattery);
            this.BasicInfoPanel.Controls.Add(this.buttonflushdns);
            this.BasicInfoPanel.Controls.Add(this.buttonPing);
            this.BasicInfoPanel.Controls.Add(this.buttonIPConfig);
            this.BasicInfoPanel.Controls.Add(this.buttonCupHolder);
            this.BasicInfoPanel.Controls.Add(this.buttonAutomount);
            this.BasicInfoPanel.Controls.Add(this.buttonReboot);
            this.BasicInfoPanel.Controls.Add(this.conSolo);
            this.BasicInfoPanel.Controls.Add(this.buttonPUPs);
            this.BasicInfoPanel.Controls.Add(this.buttonNetSh);
            this.BasicInfoPanel.Controls.Add(this.buttonCrisis);
            this.BasicInfoPanel.Controls.Add(this.buttonChkDsk);
            this.BasicInfoPanel.Controls.Add(this.buttonUEFI);
            this.BasicInfoPanel.Controls.Add(this.buttonSFC2);
            this.BasicInfoPanel.Controls.Add(this.buttonSFC1);
            this.BasicInfoPanel.Controls.Add(this.buttonDISM);
            this.BasicInfoPanel.Controls.Add(this.labelCPU);
            this.BasicInfoPanel.Controls.Add(this.labelUptime);
            this.BasicInfoPanel.Controls.Add(this.labelVersion);
            this.BasicInfoPanel.Controls.Add(this.textBoxLicense);
            this.BasicInfoPanel.Controls.Add(this.textBoxActivated);
            this.BasicInfoPanel.Controls.Add(this.textBoxVersion);
            this.BasicInfoPanel.Controls.Add(this.textBoxUptime);
            this.BasicInfoPanel.Controls.Add(this.textBoxFirmware);
            this.BasicInfoPanel.Controls.Add(this.textBoxCPU);
            this.BasicInfoPanel.Controls.Add(this.labelActivated);
            this.BasicInfoPanel.Controls.Add(this.labelLicense);
            this.BasicInfoPanel.Controls.Add(this.labelFirmware);
            this.BasicInfoPanel.Location = new System.Drawing.Point(2, 2);
            this.BasicInfoPanel.Name = "BasicInfoPanel";
            this.BasicInfoPanel.Size = new System.Drawing.Size(839, 568);
            this.BasicInfoPanel.TabIndex = 0;
            // 
            // textBoxMaxMem
            // 
            this.textBoxMaxMem.Location = new System.Drawing.Point(64, 85);
            this.textBoxMaxMem.Name = "textBoxMaxMem";
            this.textBoxMaxMem.ReadOnly = true;
            this.textBoxMaxMem.Size = new System.Drawing.Size(578, 20);
            this.textBoxMaxMem.TabIndex = 71;
            // 
            // labelMaxMem
            // 
            this.labelMaxMem.AutoSize = true;
            this.labelMaxMem.Location = new System.Drawing.Point(2, 87);
            this.labelMaxMem.Name = "labelMaxMem";
            this.labelMaxMem.Size = new System.Drawing.Size(56, 13);
            this.labelMaxMem.TabIndex = 70;
            this.labelMaxMem.Text = "Max Mem:";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(64, 59);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.ReadOnly = true;
            this.textBoxSerial.Size = new System.Drawing.Size(578, 20);
            this.textBoxSerial.TabIndex = 69;
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(22, 63);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(36, 13);
            this.labelSerial.TabIndex = 68;
            this.labelSerial.Text = "Serial:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(648, 8);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(184, 39);
            this.buttonClear.TabIndex = 67;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Location = new System.Drawing.Point(3, 511);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(89, 22);
            this.buttonShutdown.TabIndex = 66;
            this.buttonShutdown.Text = "Shut Down";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(743, 53);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(89, 23);
            this.button25.TabIndex = 65;
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(648, 53);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(89, 23);
            this.button26.TabIndex = 64;
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(743, 82);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(89, 23);
            this.button27.TabIndex = 63;
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(648, 82);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(89, 23);
            this.button28.TabIndex = 62;
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(743, 110);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(89, 23);
            this.button29.TabIndex = 61;
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(648, 110);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(89, 23);
            this.button30.TabIndex = 60;
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(743, 139);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(89, 23);
            this.button31.TabIndex = 59;
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(648, 139);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(89, 23);
            this.button32.TabIndex = 58;
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(743, 168);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(89, 23);
            this.button33.TabIndex = 57;
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(648, 168);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(89, 23);
            this.button34.TabIndex = 56;
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(743, 196);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(89, 23);
            this.button35.TabIndex = 55;
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(648, 196);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(89, 23);
            this.button36.TabIndex = 54;
            this.button36.UseVisualStyleBackColor = true;
            // 
            // buttonDiskHealth
            // 
            this.buttonDiskHealth.Location = new System.Drawing.Point(743, 225);
            this.buttonDiskHealth.Name = "buttonDiskHealth";
            this.buttonDiskHealth.Size = new System.Drawing.Size(89, 23);
            this.buttonDiskHealth.TabIndex = 53;
            this.buttonDiskHealth.Text = "Disk Health";
            this.buttonDiskHealth.UseVisualStyleBackColor = true;
            this.buttonDiskHealth.Click += new System.EventHandler(this.ButtonDiskHealth_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(648, 225);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 23);
            this.button14.TabIndex = 52;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // buttonMSIStart
            // 
            this.buttonMSIStart.Location = new System.Drawing.Point(743, 254);
            this.buttonMSIStart.Name = "buttonMSIStart";
            this.buttonMSIStart.Size = new System.Drawing.Size(89, 23);
            this.buttonMSIStart.TabIndex = 51;
            this.buttonMSIStart.Text = "Start MSI SVC";
            this.buttonMSIStart.UseVisualStyleBackColor = true;
            this.buttonMSIStart.Click += new System.EventHandler(this.buttonMSIStart_Click);
            // 
            // buttonGrabMCT
            // 
            this.buttonGrabMCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrabMCT.ForeColor = System.Drawing.Color.Orange;
            this.buttonGrabMCT.Location = new System.Drawing.Point(648, 254);
            this.buttonGrabMCT.Name = "buttonGrabMCT";
            this.buttonGrabMCT.Size = new System.Drawing.Size(89, 23);
            this.buttonGrabMCT.TabIndex = 50;
            this.buttonGrabMCT.Text = "Start MCT";
            this.buttonGrabMCT.UseVisualStyleBackColor = true;
            this.buttonGrabMCT.Click += new System.EventHandler(this.ButtonGrabMCT_Click);
            // 
            // buttonExplorer
            // 
            this.buttonExplorer.Location = new System.Drawing.Point(743, 282);
            this.buttonExplorer.Name = "buttonExplorer";
            this.buttonExplorer.Size = new System.Drawing.Size(89, 23);
            this.buttonExplorer.TabIndex = 49;
            this.buttonExplorer.Text = "Kill Explorer";
            this.buttonExplorer.UseVisualStyleBackColor = true;
            this.buttonExplorer.Click += new System.EventHandler(this.buttonExplorer_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(648, 282);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(89, 23);
            this.buttonDetails.TabIndex = 48;
            this.buttonDetails.Text = "System Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // buttonReBCD
            // 
            this.buttonReBCD.Location = new System.Drawing.Point(743, 311);
            this.buttonReBCD.Name = "buttonReBCD";
            this.buttonReBCD.Size = new System.Drawing.Size(89, 23);
            this.buttonReBCD.TabIndex = 47;
            this.buttonReBCD.Text = "Rebuild BCD";
            this.buttonReBCD.UseVisualStyleBackColor = true;
            this.buttonReBCD.Click += new System.EventHandler(this.buttonReBCD_Click);
            // 
            // buttonScanOS
            // 
            this.buttonScanOS.Location = new System.Drawing.Point(648, 311);
            this.buttonScanOS.Name = "buttonScanOS";
            this.buttonScanOS.Size = new System.Drawing.Size(89, 23);
            this.buttonScanOS.TabIndex = 46;
            this.buttonScanOS.Text = "Scan OS";
            this.buttonScanOS.UseVisualStyleBackColor = true;
            this.buttonScanOS.Click += new System.EventHandler(this.buttonScanOS_Click);
            // 
            // buttonFixBoot
            // 
            this.buttonFixBoot.Location = new System.Drawing.Point(743, 340);
            this.buttonFixBoot.Name = "buttonFixBoot";
            this.buttonFixBoot.Size = new System.Drawing.Size(89, 23);
            this.buttonFixBoot.TabIndex = 45;
            this.buttonFixBoot.Text = "Fix Boot";
            this.buttonFixBoot.UseVisualStyleBackColor = true;
            this.buttonFixBoot.Click += new System.EventHandler(this.buttonFixBoot_Click);
            // 
            // buttonFixMBR
            // 
            this.buttonFixMBR.Location = new System.Drawing.Point(648, 340);
            this.buttonFixMBR.Name = "buttonFixMBR";
            this.buttonFixMBR.Size = new System.Drawing.Size(89, 23);
            this.buttonFixMBR.TabIndex = 44;
            this.buttonFixMBR.Text = "Fix MBR";
            this.buttonFixMBR.UseVisualStyleBackColor = true;
            this.buttonFixMBR.Click += new System.EventHandler(this.buttonFixMBR_Click);
            // 
            // buttonWinPfW
            // 
            this.buttonWinPfW.Location = new System.Drawing.Point(743, 368);
            this.buttonWinPfW.Name = "buttonWinPfW";
            this.buttonWinPfW.Size = new System.Drawing.Size(89, 23);
            this.buttonWinPfW.TabIndex = 43;
            this.buttonWinPfW.Text = "PfW Upgrade";
            this.buttonWinPfW.UseVisualStyleBackColor = true;
            this.buttonWinPfW.Click += new System.EventHandler(this.buttonWinPfW_Click);
            // 
            // buttonWinEnt
            // 
            this.buttonWinEnt.Location = new System.Drawing.Point(648, 368);
            this.buttonWinEnt.Name = "buttonWinEnt";
            this.buttonWinEnt.Size = new System.Drawing.Size(89, 23);
            this.buttonWinEnt.TabIndex = 42;
            this.buttonWinEnt.Text = "Ent Upgrade";
            this.buttonWinEnt.UseVisualStyleBackColor = true;
            this.buttonWinEnt.Click += new System.EventHandler(this.buttonWinEnt_Click);
            // 
            // buttonWinPro
            // 
            this.buttonWinPro.Location = new System.Drawing.Point(743, 395);
            this.buttonWinPro.Name = "buttonWinPro";
            this.buttonWinPro.Size = new System.Drawing.Size(89, 23);
            this.buttonWinPro.TabIndex = 41;
            this.buttonWinPro.Text = "Pro Upgrade";
            this.buttonWinPro.UseVisualStyleBackColor = true;
            this.buttonWinPro.Click += new System.EventHandler(this.buttonWinPro_Click);
            // 
            // buttonWinEdu
            // 
            this.buttonWinEdu.Location = new System.Drawing.Point(648, 395);
            this.buttonWinEdu.Name = "buttonWinEdu";
            this.buttonWinEdu.Size = new System.Drawing.Size(89, 23);
            this.buttonWinEdu.TabIndex = 40;
            this.buttonWinEdu.Text = "Edu Upgrade";
            this.buttonWinEdu.UseVisualStyleBackColor = true;
            this.buttonWinEdu.Click += new System.EventHandler(this.buttonWinEdu_Click);
            // 
            // buttonAdminOff
            // 
            this.buttonAdminOff.Location = new System.Drawing.Point(648, 423);
            this.buttonAdminOff.Name = "buttonAdminOff";
            this.buttonAdminOff.Size = new System.Drawing.Size(89, 23);
            this.buttonAdminOff.TabIndex = 39;
            this.buttonAdminOff.Text = "Disable Admin";
            this.buttonAdminOff.UseVisualStyleBackColor = true;
            this.buttonAdminOff.Click += new System.EventHandler(this.buttonAdminOff_Click);
            // 
            // buttonPrintSpool
            // 
            this.buttonPrintSpool.Location = new System.Drawing.Point(743, 482);
            this.buttonPrintSpool.Name = "buttonPrintSpool";
            this.buttonPrintSpool.Size = new System.Drawing.Size(89, 23);
            this.buttonPrintSpool.TabIndex = 38;
            this.buttonPrintSpool.Text = "Restart Spool";
            this.buttonPrintSpool.UseVisualStyleBackColor = true;
            this.buttonPrintSpool.Click += new System.EventHandler(this.buttonPrintSpool_Click);
            // 
            // buttonRdpOn
            // 
            this.buttonRdpOn.Location = new System.Drawing.Point(743, 452);
            this.buttonRdpOn.Name = "buttonRdpOn";
            this.buttonRdpOn.Size = new System.Drawing.Size(89, 23);
            this.buttonRdpOn.TabIndex = 37;
            this.buttonRdpOn.Text = "Enable RDP";
            this.buttonRdpOn.UseVisualStyleBackColor = true;
            this.buttonRdpOn.Click += new System.EventHandler(this.buttonRdpOn_Click);
            // 
            // buttonRdpOff
            // 
            this.buttonRdpOff.Location = new System.Drawing.Point(648, 452);
            this.buttonRdpOff.Name = "buttonRdpOff";
            this.buttonRdpOff.Size = new System.Drawing.Size(89, 23);
            this.buttonRdpOff.TabIndex = 36;
            this.buttonRdpOff.Text = "Disable RDP";
            this.buttonRdpOff.UseVisualStyleBackColor = true;
            this.buttonRdpOff.Click += new System.EventHandler(this.buttonRdpOff_Click);
            // 
            // buttonAdminOn
            // 
            this.buttonAdminOn.Location = new System.Drawing.Point(743, 423);
            this.buttonAdminOn.Name = "buttonAdminOn";
            this.buttonAdminOn.Size = new System.Drawing.Size(89, 23);
            this.buttonAdminOn.TabIndex = 35;
            this.buttonAdminOn.Text = "Enable Admin";
            this.buttonAdminOn.UseVisualStyleBackColor = true;
            this.buttonAdminOn.Click += new System.EventHandler(this.buttonAdminOn_Click);
            // 
            // buttonWsreset
            // 
            this.buttonWsreset.Location = new System.Drawing.Point(648, 481);
            this.buttonWsreset.Name = "buttonWsreset";
            this.buttonWsreset.Size = new System.Drawing.Size(89, 23);
            this.buttonWsreset.TabIndex = 34;
            this.buttonWsreset.Text = "Reset Store";
            this.buttonWsreset.UseVisualStyleBackColor = true;
            this.buttonWsreset.Click += new System.EventHandler(this.buttonWsReset_Click);
            // 
            // buttonBattery
            // 
            this.buttonBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBattery.ForeColor = System.Drawing.Color.Orange;
            this.buttonBattery.Location = new System.Drawing.Point(743, 510);
            this.buttonBattery.Name = "buttonBattery";
            this.buttonBattery.Size = new System.Drawing.Size(89, 23);
            this.buttonBattery.TabIndex = 33;
            this.buttonBattery.Text = "Battery Info";
            this.buttonBattery.UseVisualStyleBackColor = true;
            this.buttonBattery.Click += new System.EventHandler(this.buttonBattery_Click);
            // 
            // buttonflushdns
            // 
            this.buttonflushdns.Location = new System.Drawing.Point(648, 510);
            this.buttonflushdns.Name = "buttonflushdns";
            this.buttonflushdns.Size = new System.Drawing.Size(89, 23);
            this.buttonflushdns.TabIndex = 32;
            this.buttonflushdns.Text = "Flush DNS";
            this.buttonflushdns.UseVisualStyleBackColor = true;
            this.buttonflushdns.Click += new System.EventHandler(this.buttonIP_Click);
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(743, 538);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(89, 23);
            this.buttonPing.TabIndex = 31;
            this.buttonPing.Text = "Ping 1.1.1.1";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonIPConfig
            // 
            this.buttonIPConfig.Location = new System.Drawing.Point(648, 538);
            this.buttonIPConfig.Name = "buttonIPConfig";
            this.buttonIPConfig.Size = new System.Drawing.Size(89, 23);
            this.buttonIPConfig.TabIndex = 30;
            this.buttonIPConfig.Text = "Local IPs";
            this.buttonIPConfig.UseVisualStyleBackColor = true;
            this.buttonIPConfig.Click += new System.EventHandler(this.buttonIPConfig_Click);
            // 
            // buttonCupHolder
            // 
            this.buttonCupHolder.Location = new System.Drawing.Point(3, 453);
            this.buttonCupHolder.Name = "buttonCupHolder";
            this.buttonCupHolder.Size = new System.Drawing.Size(89, 23);
            this.buttonCupHolder.TabIndex = 29;
            this.buttonCupHolder.Text = "Cup Holder";
            this.buttonCupHolder.UseVisualStyleBackColor = true;
            this.buttonCupHolder.Click += new System.EventHandler(this.buttonCupHolder_Click);
            // 
            // buttonAutomount
            // 
            this.buttonAutomount.Location = new System.Drawing.Point(3, 424);
            this.buttonAutomount.Name = "buttonAutomount";
            this.buttonAutomount.Size = new System.Drawing.Size(89, 23);
            this.buttonAutomount.TabIndex = 28;
            this.buttonAutomount.Text = "Fix Automount";
            this.buttonAutomount.UseVisualStyleBackColor = true;
            this.buttonAutomount.Click += new System.EventHandler(this.buttonAutomount_Click);
            // 
            // buttonReboot
            // 
            this.buttonReboot.Location = new System.Drawing.Point(3, 482);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(89, 23);
            this.buttonReboot.TabIndex = 27;
            this.buttonReboot.Text = "Reboot";
            this.buttonReboot.UseVisualStyleBackColor = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // conSolo
            // 
            this.conSolo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conSolo.IsInputEnabled = true;
            this.conSolo.Location = new System.Drawing.Point(99, 221);
            this.conSolo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.conSolo.Name = "conSolo";
            this.conSolo.SendKeyboardCommandsToProcess = false;
            this.conSolo.ShowDiagnostics = false;
            this.conSolo.Size = new System.Drawing.Size(543, 340);
            this.conSolo.TabIndex = 26;
            // 
            // buttonPUPs
            // 
            this.buttonPUPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPUPs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPUPs.Location = new System.Drawing.Point(3, 395);
            this.buttonPUPs.Name = "buttonPUPs";
            this.buttonPUPs.Size = new System.Drawing.Size(89, 23);
            this.buttonPUPs.TabIndex = 25;
            this.buttonPUPs.Text = "Find PUPs";
            this.buttonPUPs.UseVisualStyleBackColor = true;
            this.buttonPUPs.Click += new System.EventHandler(this.buttonPUPs_Click);
            // 
            // buttonNetSh
            // 
            this.buttonNetSh.Location = new System.Drawing.Point(3, 366);
            this.buttonNetSh.Name = "buttonNetSh";
            this.buttonNetSh.Size = new System.Drawing.Size(89, 23);
            this.buttonNetSh.TabIndex = 24;
            this.buttonNetSh.Text = "NetSh Reset";
            this.buttonNetSh.UseVisualStyleBackColor = true;
            this.buttonNetSh.Click += new System.EventHandler(this.buttonNetSh_Click);
            // 
            // buttonCrisis
            // 
            this.buttonCrisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrisis.ForeColor = System.Drawing.Color.Red;
            this.buttonCrisis.Location = new System.Drawing.Point(3, 538);
            this.buttonCrisis.Name = "buttonCrisis";
            this.buttonCrisis.Size = new System.Drawing.Size(89, 23);
            this.buttonCrisis.TabIndex = 23;
            this.buttonCrisis.Text = "Crisis";
            this.buttonCrisis.UseVisualStyleBackColor = true;
            this.buttonCrisis.Click += new System.EventHandler(this.buttonCrisis_Click);
            // 
            // buttonChkDsk
            // 
            this.buttonChkDsk.Location = new System.Drawing.Point(3, 337);
            this.buttonChkDsk.Name = "buttonChkDsk";
            this.buttonChkDsk.Size = new System.Drawing.Size(89, 23);
            this.buttonChkDsk.TabIndex = 22;
            this.buttonChkDsk.Text = "Check Disk";
            this.buttonChkDsk.UseVisualStyleBackColor = true;
            this.buttonChkDsk.Click += new System.EventHandler(this.buttonChkDsk_Click);
            // 
            // buttonUEFI
            // 
            this.buttonUEFI.Location = new System.Drawing.Point(3, 308);
            this.buttonUEFI.Name = "buttonUEFI";
            this.buttonUEFI.Size = new System.Drawing.Size(89, 23);
            this.buttonUEFI.TabIndex = 21;
            this.buttonUEFI.Text = "UEFI Reboot";
            this.buttonUEFI.UseVisualStyleBackColor = true;
            this.buttonUEFI.Click += new System.EventHandler(this.buttonUEFI_Click);
            // 
            // buttonSFC2
            // 
            this.buttonSFC2.Location = new System.Drawing.Point(3, 279);
            this.buttonSFC2.Name = "buttonSFC2";
            this.buttonSFC2.Size = new System.Drawing.Size(89, 23);
            this.buttonSFC2.TabIndex = 20;
            this.buttonSFC2.Text = "SFC Check";
            this.buttonSFC2.UseVisualStyleBackColor = true;
            this.buttonSFC2.Click += new System.EventHandler(this.buttonSFC2_Click);
            // 
            // buttonSFC1
            // 
            this.buttonSFC1.Location = new System.Drawing.Point(3, 250);
            this.buttonSFC1.Name = "buttonSFC1";
            this.buttonSFC1.Size = new System.Drawing.Size(89, 23);
            this.buttonSFC1.TabIndex = 19;
            this.buttonSFC1.Text = "SFC Repair";
            this.buttonSFC1.UseVisualStyleBackColor = true;
            this.buttonSFC1.Click += new System.EventHandler(this.buttonSFC1_Click);
            // 
            // buttonDISM
            // 
            this.buttonDISM.Location = new System.Drawing.Point(3, 221);
            this.buttonDISM.Name = "buttonDISM";
            this.buttonDISM.Size = new System.Drawing.Size(89, 23);
            this.buttonDISM.TabIndex = 18;
            this.buttonDISM.Text = "DISM Repair";
            this.buttonDISM.UseVisualStyleBackColor = true;
            this.buttonDISM.Click += new System.EventHandler(this.buttonDISM_Click);
            // 
            // AppBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 571);
            this.Controls.Add(this.BasicInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppBase";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "TSS Quick Command";
            this.Load += new System.EventHandler(this.AppBase_Load);
            this.BasicInfoPanel.ResumeLayout(false);
            this.BasicInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFirmware;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.TextBox textBoxCPU;
        private System.Windows.Forms.TextBox textBoxFirmware;
        private System.Windows.Forms.TextBox textBoxUptime;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TextBox textBoxActivated;
        private System.Windows.Forms.TextBox textBoxLicense;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelUptime;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Panel BasicInfoPanel;
        private System.Windows.Forms.Button buttonChkDsk;
        private System.Windows.Forms.Button buttonUEFI;
        private System.Windows.Forms.Button buttonSFC2;
        private System.Windows.Forms.Button buttonSFC1;
        private System.Windows.Forms.Button buttonDISM;
        private System.Windows.Forms.Button buttonPUPs;
        private System.Windows.Forms.Button buttonNetSh;
        private System.Windows.Forms.Button buttonCrisis;
        private ConsoleControl.ConsoleControl conSolo;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.Button buttonAutomount;
        private System.Windows.Forms.Button buttonCupHolder;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button buttonDiskHealth;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button buttonMSIStart;
        private System.Windows.Forms.Button buttonGrabMCT;
        private System.Windows.Forms.Button buttonExplorer;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonReBCD;
        private System.Windows.Forms.Button buttonScanOS;
        private System.Windows.Forms.Button buttonFixBoot;
        private System.Windows.Forms.Button buttonFixMBR;
        private System.Windows.Forms.Button buttonWinPfW;
        private System.Windows.Forms.Button buttonWinEnt;
        private System.Windows.Forms.Button buttonWinPro;
        private System.Windows.Forms.Button buttonWinEdu;
        private System.Windows.Forms.Button buttonAdminOff;
        private System.Windows.Forms.Button buttonPrintSpool;
        private System.Windows.Forms.Button buttonRdpOn;
        private System.Windows.Forms.Button buttonRdpOff;
        private System.Windows.Forms.Button buttonAdminOn;
        private System.Windows.Forms.Button buttonWsreset;
        private System.Windows.Forms.Button buttonBattery;
        private System.Windows.Forms.Button buttonflushdns;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonIPConfig;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxMaxMem;
        private System.Windows.Forms.Label labelMaxMem;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label labelSerial;
    }
}

