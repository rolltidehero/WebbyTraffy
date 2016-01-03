﻿namespace WebbyTraffy
{
    partial class MainForm
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
            this.lblTotalUrlsToVisit = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnActionBrowser = new System.Windows.Forms.Button();
            this.grpConfigs = new System.Windows.Forms.GroupBox();
            this.btnFileProxies = new System.Windows.Forms.Button();
            this.btnFileUrls = new System.Windows.Forms.Button();
            this.chkConfigSimulateOpSystem = new System.Windows.Forms.CheckBox();
            this.chkConfigSimulateCountries = new System.Windows.Forms.CheckBox();
            this.chkConfigSimulateBrowser = new System.Windows.Forms.CheckBox();
            this.lblTotalVisits = new System.Windows.Forms.Label();
            this.txtLogger = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.spinRepeatConditionValue = new System.Windows.Forms.NumericUpDown();
            this.lblRepeatConditionValue = new System.Windows.Forms.Label();
            this.lblRepeatConditionType = new System.Windows.Forms.Label();
            this.lblConfigAvgReadTime = new System.Windows.Forms.Label();
            this.spinAvgReadTime = new System.Windows.Forms.NumericUpDown();
            this.lblTotalLoops = new System.Windows.Forms.Label();
            this.grpConsole = new System.Windows.Forms.GroupBox();
            this.grpBrowser = new System.Windows.Forms.GroupBox();
            this.grpConfigs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRepeatConditionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAvgReadTime)).BeginInit();
            this.grpConsole.SuspendLayout();
            this.grpBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalUrlsToVisit
            // 
            this.lblTotalUrlsToVisit.AutoSize = true;
            this.lblTotalUrlsToVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalUrlsToVisit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalUrlsToVisit.Location = new System.Drawing.Point(9, 31);
            this.lblTotalUrlsToVisit.Name = "lblTotalUrlsToVisit";
            this.lblTotalUrlsToVisit.Size = new System.Drawing.Size(110, 15);
            this.lblTotalUrlsToVisit.TabIndex = 3;
            this.lblTotalUrlsToVisit.Tag = "Target URLs: ";
            this.lblTotalUrlsToVisit.Text = "Target URLs: (none)";
            this.lblTotalUrlsToVisit.Click += new System.EventHandler(this.lblUrlsToCall_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(3, 19);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(615, 424);
            this.webBrowser.TabIndex = 5;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // btnActionBrowser
            // 
            this.btnActionBrowser.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionBrowser.Location = new System.Drawing.Point(12, 358);
            this.btnActionBrowser.Name = "btnActionBrowser";
            this.btnActionBrowser.Size = new System.Drawing.Size(233, 42);
            this.btnActionBrowser.TabIndex = 6;
            this.btnActionBrowser.Text = "DO IT!";
            this.btnActionBrowser.UseVisualStyleBackColor = true;
            this.btnActionBrowser.Click += new System.EventHandler(this.btnActionBrowser_Click);
            // 
            // grpConfigs
            // 
            this.grpConfigs.Controls.Add(this.btnFileProxies);
            this.grpConfigs.Controls.Add(this.btnFileUrls);
            this.grpConfigs.Controls.Add(this.chkConfigSimulateOpSystem);
            this.grpConfigs.Controls.Add(this.chkConfigSimulateCountries);
            this.grpConfigs.Controls.Add(this.chkConfigSimulateBrowser);
            this.grpConfigs.Controls.Add(this.lblTotalUrlsToVisit);
            this.grpConfigs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpConfigs.Location = new System.Drawing.Point(12, 12);
            this.grpConfigs.Name = "grpConfigs";
            this.grpConfigs.Size = new System.Drawing.Size(233, 182);
            this.grpConfigs.TabIndex = 7;
            this.grpConfigs.TabStop = false;
            this.grpConfigs.Text = "Simulation configs";
            // 
            // btnFileProxies
            // 
            this.btnFileProxies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFileProxies.Image = global::WebbyTraffy.Properties.Resources.OpenFile;
            this.btnFileProxies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileProxies.Location = new System.Drawing.Point(141, 138);
            this.btnFileProxies.Name = "btnFileProxies";
            this.btnFileProxies.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFileProxies.Size = new System.Drawing.Size(80, 23);
            this.btnFileProxies.TabIndex = 15;
            this.btnFileProxies.Text = "Import...";
            this.btnFileProxies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFileProxies.UseVisualStyleBackColor = true;
            // 
            // btnFileUrls
            // 
            this.btnFileUrls.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFileUrls.Image = global::WebbyTraffy.Properties.Resources.OpenFile;
            this.btnFileUrls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileUrls.Location = new System.Drawing.Point(141, 27);
            this.btnFileUrls.Name = "btnFileUrls";
            this.btnFileUrls.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFileUrls.Size = new System.Drawing.Size(80, 23);
            this.btnFileUrls.TabIndex = 12;
            this.btnFileUrls.Text = "Import...";
            this.btnFileUrls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFileUrls.UseVisualStyleBackColor = true;
            this.btnFileUrls.Click += new System.EventHandler(this.btnFileUrls_Click);
            // 
            // chkConfigSimulateOpSystem
            // 
            this.chkConfigSimulateOpSystem.AutoSize = true;
            this.chkConfigSimulateOpSystem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConfigSimulateOpSystem.Enabled = false;
            this.chkConfigSimulateOpSystem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkConfigSimulateOpSystem.Location = new System.Drawing.Point(9, 65);
            this.chkConfigSimulateOpSystem.Name = "chkConfigSimulateOpSystem";
            this.chkConfigSimulateOpSystem.Size = new System.Drawing.Size(90, 19);
            this.chkConfigSimulateOpSystem.TabIndex = 2;
            this.chkConfigSimulateOpSystem.Text = "Simulate OS";
            this.chkConfigSimulateOpSystem.UseVisualStyleBackColor = true;
            // 
            // chkConfigSimulateCountries
            // 
            this.chkConfigSimulateCountries.AutoSize = true;
            this.chkConfigSimulateCountries.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConfigSimulateCountries.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkConfigSimulateCountries.Location = new System.Drawing.Point(9, 141);
            this.chkConfigSimulateCountries.Name = "chkConfigSimulateCountries";
            this.chkConfigSimulateCountries.Size = new System.Drawing.Size(124, 19);
            this.chkConfigSimulateCountries.TabIndex = 1;
            this.chkConfigSimulateCountries.Text = "Simulate countries";
            this.chkConfigSimulateCountries.UseVisualStyleBackColor = true;
            // 
            // chkConfigSimulateBrowser
            // 
            this.chkConfigSimulateBrowser.AutoSize = true;
            this.chkConfigSimulateBrowser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConfigSimulateBrowser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkConfigSimulateBrowser.Location = new System.Drawing.Point(9, 103);
            this.chkConfigSimulateBrowser.Name = "chkConfigSimulateBrowser";
            this.chkConfigSimulateBrowser.Size = new System.Drawing.Size(122, 19);
            this.chkConfigSimulateBrowser.TabIndex = 0;
            this.chkConfigSimulateBrowser.Text = "Simulate browsers";
            this.chkConfigSimulateBrowser.UseVisualStyleBackColor = true;
            // 
            // lblTotalVisits
            // 
            this.lblTotalVisits.AutoSize = true;
            this.lblTotalVisits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalVisits.Location = new System.Drawing.Point(12, 409);
            this.lblTotalVisits.Name = "lblTotalVisits";
            this.lblTotalVisits.Size = new System.Drawing.Size(74, 15);
            this.lblTotalVisits.TabIndex = 8;
            this.lblTotalVisits.Tag = "Total visits: ";
            this.lblTotalVisits.Text = "Total visits: 0";
            // 
            // txtLogger
            // 
            this.txtLogger.BackColor = System.Drawing.Color.Black;
            this.txtLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogger.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLogger.ForeColor = System.Drawing.Color.White;
            this.txtLogger.Location = new System.Drawing.Point(3, 19);
            this.txtLogger.Multiline = true;
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogger.Size = new System.Drawing.Size(854, 126);
            this.txtLogger.TabIndex = 9;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DereferenceLinks = false;
            this.openFileDialog.Filter = "\"Text|*.txt|All|*.*\"";
            // 
            // picLoading
            // 
            this.picLoading.Image = global::WebbyTraffy.Properties.Resources.LoadingAnimation;
            this.picLoading.Location = new System.Drawing.Point(217, 406);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(28, 42);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 15;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.spinRepeatConditionValue);
            this.groupBox1.Controls.Add(this.lblRepeatConditionValue);
            this.groupBox1.Controls.Add(this.lblRepeatConditionType);
            this.groupBox1.Controls.Add(this.lblConfigAvgReadTime);
            this.groupBox1.Controls.Add(this.spinAvgReadTime);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 152);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traffic configs";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDown1.Location = new System.Drawing.Point(163, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 23);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // spinRepeatConditionValue
            // 
            this.spinRepeatConditionValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.spinRepeatConditionValue.Location = new System.Drawing.Point(163, 72);
            this.spinRepeatConditionValue.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.spinRepeatConditionValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinRepeatConditionValue.Name = "spinRepeatConditionValue";
            this.spinRepeatConditionValue.Size = new System.Drawing.Size(58, 23);
            this.spinRepeatConditionValue.TabIndex = 20;
            this.spinRepeatConditionValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinRepeatConditionValue.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.spinRepeatConditionValue.Visible = false;
            // 
            // lblRepeatConditionValue
            // 
            this.lblRepeatConditionValue.AutoSize = true;
            this.lblRepeatConditionValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRepeatConditionValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRepeatConditionValue.Location = new System.Drawing.Point(9, 76);
            this.lblRepeatConditionValue.Name = "lblRepeatConditionValue";
            this.lblRepeatConditionValue.Size = new System.Drawing.Size(128, 15);
            this.lblRepeatConditionValue.TabIndex = 19;
            this.lblRepeatConditionValue.Tag = "";
            this.lblRepeatConditionValue.Text = "Dispersed during (min)";
            this.lblRepeatConditionValue.Visible = false;
            // 
            // lblRepeatConditionType
            // 
            this.lblRepeatConditionType.AutoSize = true;
            this.lblRepeatConditionType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRepeatConditionType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRepeatConditionType.Location = new System.Drawing.Point(9, 30);
            this.lblRepeatConditionType.Name = "lblRepeatConditionType";
            this.lblRepeatConditionType.Size = new System.Drawing.Size(94, 15);
            this.lblRepeatConditionType.TabIndex = 18;
            this.lblRepeatConditionType.Tag = "";
            this.lblRepeatConditionType.Text = "Number of visits";
            // 
            // lblConfigAvgReadTime
            // 
            this.lblConfigAvgReadTime.AutoSize = true;
            this.lblConfigAvgReadTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfigAvgReadTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfigAvgReadTime.Location = new System.Drawing.Point(9, 123);
            this.lblConfigAvgReadTime.Name = "lblConfigAvgReadTime";
            this.lblConfigAvgReadTime.Size = new System.Drawing.Size(105, 15);
            this.lblConfigAvgReadTime.TabIndex = 16;
            this.lblConfigAvgReadTime.Tag = "";
            this.lblConfigAvgReadTime.Text = "Visit duration (sec)";
            // 
            // spinAvgReadTime
            // 
            this.spinAvgReadTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.spinAvgReadTime.Location = new System.Drawing.Point(163, 119);
            this.spinAvgReadTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.spinAvgReadTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinAvgReadTime.Name = "spinAvgReadTime";
            this.spinAvgReadTime.Size = new System.Drawing.Size(58, 23);
            this.spinAvgReadTime.TabIndex = 0;
            this.spinAvgReadTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinAvgReadTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblTotalLoops
            // 
            this.lblTotalLoops.AutoSize = true;
            this.lblTotalLoops.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLoops.Location = new System.Drawing.Point(12, 430);
            this.lblTotalLoops.Name = "lblTotalLoops";
            this.lblTotalLoops.Size = new System.Drawing.Size(77, 15);
            this.lblTotalLoops.TabIndex = 17;
            this.lblTotalLoops.Tag = "Total loops: ";
            this.lblTotalLoops.Text = "Total loops: 0";
            // 
            // grpConsole
            // 
            this.grpConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConsole.Controls.Add(this.txtLogger);
            this.grpConsole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpConsole.Location = new System.Drawing.Point(12, 456);
            this.grpConsole.Name = "grpConsole";
            this.grpConsole.Size = new System.Drawing.Size(860, 148);
            this.grpConsole.TabIndex = 18;
            this.grpConsole.TabStop = false;
            this.grpConsole.Text = "Log";
            // 
            // grpBrowser
            // 
            this.grpBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBrowser.Controls.Add(this.webBrowser);
            this.grpBrowser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpBrowser.Location = new System.Drawing.Point(251, 12);
            this.grpBrowser.Name = "grpBrowser";
            this.grpBrowser.Size = new System.Drawing.Size(621, 446);
            this.grpBrowser.TabIndex = 19;
            this.grpBrowser.TabStop = false;
            this.grpBrowser.Text = "Browser (fake)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 616);
            this.Controls.Add(this.grpBrowser);
            this.Controls.Add(this.grpConsole);
            this.Controls.Add(this.lblTotalLoops);
            this.Controls.Add(this.btnActionBrowser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.lblTotalVisits);
            this.Controls.Add(this.grpConfigs);
            this.MinimumSize = new System.Drawing.Size(16, 655);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpConfigs.ResumeLayout(false);
            this.grpConfigs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRepeatConditionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAvgReadTime)).EndInit();
            this.grpConsole.ResumeLayout(false);
            this.grpConsole.PerformLayout();
            this.grpBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalUrlsToVisit;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnActionBrowser;
        private System.Windows.Forms.GroupBox grpConfigs;
        private System.Windows.Forms.CheckBox chkConfigSimulateOpSystem;
        private System.Windows.Forms.CheckBox chkConfigSimulateCountries;
        private System.Windows.Forms.CheckBox chkConfigSimulateBrowser;
        private System.Windows.Forms.Label lblTotalVisits;
        private System.Windows.Forms.TextBox txtLogger;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnFileUrls;
        private System.Windows.Forms.Button btnFileProxies;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalLoops;
        private System.Windows.Forms.Label lblConfigAvgReadTime;
        private System.Windows.Forms.NumericUpDown spinAvgReadTime;
        private System.Windows.Forms.GroupBox grpConsole;
        private System.Windows.Forms.GroupBox grpBrowser;
        private System.Windows.Forms.NumericUpDown spinRepeatConditionValue;
        private System.Windows.Forms.Label lblRepeatConditionValue;
        private System.Windows.Forms.Label lblRepeatConditionType;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
