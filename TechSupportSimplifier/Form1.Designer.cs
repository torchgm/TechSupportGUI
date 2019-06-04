namespace TechSupportSimplifier
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
            this.buttonCupHolder = new System.Windows.Forms.Button();
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
            this.labelLicense.Location = new System.Drawing.Point(11, 139);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(47, 13);
            this.labelLicense.TabIndex = 2;
            this.labelLicense.Text = "License:";
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.Location = new System.Drawing.Point(3, 115);
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
            this.textBoxUptime.Location = new System.Drawing.Point(64, 61);
            this.textBoxUptime.Name = "textBoxUptime";
            this.textBoxUptime.ReadOnly = true;
            this.textBoxUptime.Size = new System.Drawing.Size(578, 20);
            this.textBoxUptime.TabIndex = 5;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(64, 87);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(578, 20);
            this.textBoxVersion.TabIndex = 6;
            // 
            // textBoxActivated
            // 
            this.textBoxActivated.Location = new System.Drawing.Point(64, 113);
            this.textBoxActivated.Name = "textBoxActivated";
            this.textBoxActivated.ReadOnly = true;
            this.textBoxActivated.Size = new System.Drawing.Size(578, 20);
            this.textBoxActivated.TabIndex = 7;
            // 
            // textBoxLicense
            // 
            this.textBoxLicense.Location = new System.Drawing.Point(64, 139);
            this.textBoxLicense.Name = "textBoxLicense";
            this.textBoxLicense.ReadOnly = true;
            this.textBoxLicense.Size = new System.Drawing.Size(578, 20);
            this.textBoxLicense.TabIndex = 8;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(13, 90);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 15;
            this.labelVersion.Text = "Version:";
            // 
            // labelUptime
            // 
            this.labelUptime.AutoSize = true;
            this.labelUptime.Location = new System.Drawing.Point(15, 64);
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
            this.BasicInfoPanel.Size = new System.Drawing.Size(648, 568);
            this.BasicInfoPanel.TabIndex = 0;
            // 
            // buttonAutomount
            // 
            this.buttonAutomount.Location = new System.Drawing.Point(3, 368);
            this.buttonAutomount.Name = "buttonAutomount";
            this.buttonAutomount.Size = new System.Drawing.Size(89, 23);
            this.buttonAutomount.TabIndex = 28;
            this.buttonAutomount.Text = "Fix Automount";
            this.buttonAutomount.UseVisualStyleBackColor = true;
            this.buttonAutomount.Click += new System.EventHandler(this.buttonAutomount_Click);
            // 
            // buttonReboot
            // 
            this.buttonReboot.Location = new System.Drawing.Point(3, 510);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(89, 22);
            this.buttonReboot.TabIndex = 27;
            this.buttonReboot.Text = "Reboot";
            this.buttonReboot.UseVisualStyleBackColor = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // conSolo
            // 
            this.conSolo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conSolo.IsInputEnabled = true;
            this.conSolo.Location = new System.Drawing.Point(99, 165);
            this.conSolo.Name = "conSolo";
            this.conSolo.SendKeyboardCommandsToProcess = false;
            this.conSolo.ShowDiagnostics = false;
            this.conSolo.Size = new System.Drawing.Size(543, 396);
            this.conSolo.TabIndex = 26;
            // 
            // buttonPUPs
            // 
            this.buttonPUPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPUPs.ForeColor = System.Drawing.Color.Orange;
            this.buttonPUPs.Location = new System.Drawing.Point(3, 339);
            this.buttonPUPs.Name = "buttonPUPs";
            this.buttonPUPs.Size = new System.Drawing.Size(89, 23);
            this.buttonPUPs.TabIndex = 25;
            this.buttonPUPs.Text = "Find PUPs";
            this.buttonPUPs.UseVisualStyleBackColor = true;
            this.buttonPUPs.Click += new System.EventHandler(this.buttonPUPs_Click);
            // 
            // buttonNetSh
            // 
            this.buttonNetSh.Location = new System.Drawing.Point(3, 310);
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
            // 
            // buttonChkDsk
            // 
            this.buttonChkDsk.Location = new System.Drawing.Point(3, 281);
            this.buttonChkDsk.Name = "buttonChkDsk";
            this.buttonChkDsk.Size = new System.Drawing.Size(89, 23);
            this.buttonChkDsk.TabIndex = 22;
            this.buttonChkDsk.Text = "Check Disk";
            this.buttonChkDsk.UseVisualStyleBackColor = true;
            this.buttonChkDsk.Click += new System.EventHandler(this.buttonChkDsk_Click);
            // 
            // buttonUEFI
            // 
            this.buttonUEFI.Location = new System.Drawing.Point(3, 252);
            this.buttonUEFI.Name = "buttonUEFI";
            this.buttonUEFI.Size = new System.Drawing.Size(89, 23);
            this.buttonUEFI.TabIndex = 21;
            this.buttonUEFI.Text = "UEFI Reboot";
            this.buttonUEFI.UseVisualStyleBackColor = true;
            this.buttonUEFI.Click += new System.EventHandler(this.buttonUEFI_Click);
            // 
            // buttonSFC2
            // 
            this.buttonSFC2.Location = new System.Drawing.Point(3, 223);
            this.buttonSFC2.Name = "buttonSFC2";
            this.buttonSFC2.Size = new System.Drawing.Size(89, 23);
            this.buttonSFC2.TabIndex = 20;
            this.buttonSFC2.Text = "SFC Check";
            this.buttonSFC2.UseVisualStyleBackColor = true;
            this.buttonSFC2.Click += new System.EventHandler(this.buttonSFC2_Click);
            // 
            // buttonSFC1
            // 
            this.buttonSFC1.Location = new System.Drawing.Point(3, 194);
            this.buttonSFC1.Name = "buttonSFC1";
            this.buttonSFC1.Size = new System.Drawing.Size(89, 23);
            this.buttonSFC1.TabIndex = 19;
            this.buttonSFC1.Text = "SFC Repair";
            this.buttonSFC1.UseVisualStyleBackColor = true;
            this.buttonSFC1.Click += new System.EventHandler(this.buttonSFC1_Click);
            // 
            // buttonDISM
            // 
            this.buttonDISM.Location = new System.Drawing.Point(3, 165);
            this.buttonDISM.Name = "buttonDISM";
            this.buttonDISM.Size = new System.Drawing.Size(89, 23);
            this.buttonDISM.TabIndex = 18;
            this.buttonDISM.Text = "DISM Repair";
            this.buttonDISM.UseVisualStyleBackColor = true;
            this.buttonDISM.Click += new System.EventHandler(this.buttonDISM_Click);
            // 
            // buttonCupHolder
            // 
            this.buttonCupHolder.Location = new System.Drawing.Point(3, 397);
            this.buttonCupHolder.Name = "buttonCupHolder";
            this.buttonCupHolder.Size = new System.Drawing.Size(89, 23);
            this.buttonCupHolder.TabIndex = 29;
            this.buttonCupHolder.Text = "Cup Holder";
            this.buttonCupHolder.UseVisualStyleBackColor = true;
            this.buttonCupHolder.Click += new System.EventHandler(this.buttonCupHolder_Click);
            // 
            // AppBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 572);
            this.Controls.Add(this.BasicInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppBase";
            this.Text = "Not Microsoft Community Support App";
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
    }
}

