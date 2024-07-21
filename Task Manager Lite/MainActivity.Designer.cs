
namespace Task_Manager_Lite
{
    partial class MainActivity
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
            this.runningAppsListBox = new System.Windows.Forms.ListBox();
            this.forceKillBtn = new System.Windows.Forms.Button();
            this.endAllProcBtn = new System.Windows.Forms.Button();
            this.mAtabHost = new System.Windows.Forms.TabControl();
            this.foregroundProcPage = new System.Windows.Forms.TabPage();
            this.bgProcPage = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bgProcListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cpuT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuProgBar = new System.Windows.Forms.ProgressBar();
            this.focusedProcessLabel = new System.Windows.Forms.Label();
            this.procDetailsBtn = new System.Windows.Forms.Button();
            this.refreshProcButton = new System.Windows.Forms.Button();
            this.putDownBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.searchBoxNotifier = new System.Windows.Forms.Label();
            this.mAtabHost.SuspendLayout();
            this.foregroundProcPage.SuspendLayout();
            this.bgProcPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // runningAppsListBox
            // 
            this.runningAppsListBox.FormattingEnabled = true;
            this.runningAppsListBox.Location = new System.Drawing.Point(0, 0);
            this.runningAppsListBox.Name = "runningAppsListBox";
            this.runningAppsListBox.Size = new System.Drawing.Size(791, 485);
            this.runningAppsListBox.TabIndex = 0;
            this.runningAppsListBox.Click += new System.EventHandler(this.listItemClicked);
            // 
            // forceKillBtn
            // 
            this.forceKillBtn.Location = new System.Drawing.Point(695, 515);
            this.forceKillBtn.Name = "forceKillBtn";
            this.forceKillBtn.Size = new System.Drawing.Size(101, 25);
            this.forceKillBtn.TabIndex = 1;
            this.forceKillBtn.Text = "Force Close";
            this.forceKillBtn.UseVisualStyleBackColor = true;
            this.forceKillBtn.Click += new System.EventHandler(this.endOneProcess);
            // 
            // endAllProcBtn
            // 
            this.endAllProcBtn.Location = new System.Drawing.Point(525, 515);
            this.endAllProcBtn.Name = "endAllProcBtn";
            this.endAllProcBtn.Size = new System.Drawing.Size(79, 25);
            this.endAllProcBtn.TabIndex = 2;
            this.endAllProcBtn.Text = "End All";
            this.endAllProcBtn.UseVisualStyleBackColor = true;
            this.endAllProcBtn.Click += new System.EventHandler(this.endAllProcesses);
            // 
            // mAtabHost
            // 
            this.mAtabHost.Controls.Add(this.foregroundProcPage);
            this.mAtabHost.Controls.Add(this.bgProcPage);
            this.mAtabHost.Controls.Add(this.tabPage3);
            this.mAtabHost.Location = new System.Drawing.Point(1, 31);
            this.mAtabHost.Name = "mAtabHost";
            this.mAtabHost.SelectedIndex = 0;
            this.mAtabHost.Size = new System.Drawing.Size(799, 478);
            this.mAtabHost.TabIndex = 4;
            // 
            // foregroundProcPage
            // 
            this.foregroundProcPage.Controls.Add(this.runningAppsListBox);
            this.foregroundProcPage.Location = new System.Drawing.Point(4, 22);
            this.foregroundProcPage.Name = "foregroundProcPage";
            this.foregroundProcPage.Padding = new System.Windows.Forms.Padding(3);
            this.foregroundProcPage.Size = new System.Drawing.Size(791, 452);
            this.foregroundProcPage.TabIndex = 0;
            this.foregroundProcPage.Text = "Running Apps";
            this.foregroundProcPage.UseVisualStyleBackColor = true;
            // 
            // bgProcPage
            // 
            this.bgProcPage.Controls.Add(this.listView1);
            this.bgProcPage.Controls.Add(this.bgProcListBox);
            this.bgProcPage.Location = new System.Drawing.Point(4, 22);
            this.bgProcPage.Name = "bgProcPage";
            this.bgProcPage.Padding = new System.Windows.Forms.Padding(3);
            this.bgProcPage.Size = new System.Drawing.Size(791, 452);
            this.bgProcPage.TabIndex = 1;
            this.bgProcPage.Text = "Background Processes";
            this.bgProcPage.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 245);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 188);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bgProcListBox
            // 
            this.bgProcListBox.FormattingEnabled = true;
            this.bgProcListBox.Location = new System.Drawing.Point(0, 0);
            this.bgProcListBox.Name = "bgProcListBox";
            this.bgProcListBox.Size = new System.Drawing.Size(795, 238);
            this.bgProcListBox.TabIndex = 0;
            this.bgProcListBox.Click += new System.EventHandler(this.listBgProcClicked);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cpuT);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cpuProgBar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Performance";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cpuT
            // 
            this.cpuT.AutoSize = true;
            this.cpuT.Location = new System.Drawing.Point(74, 51);
            this.cpuT.Name = "cpuT";
            this.cpuT.Size = new System.Drawing.Size(13, 13);
            this.cpuT.TabIndex = 2;
            this.cpuT.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU";
            // 
            // cpuProgBar
            // 
            this.cpuProgBar.Location = new System.Drawing.Point(23, 70);
            this.cpuProgBar.Name = "cpuProgBar";
            this.cpuProgBar.Size = new System.Drawing.Size(406, 18);
            this.cpuProgBar.TabIndex = 0;
            // 
            // focusedProcessLabel
            // 
            this.focusedProcessLabel.AutoSize = true;
            this.focusedProcessLabel.Location = new System.Drawing.Point(79, 521);
            this.focusedProcessLabel.Name = "focusedProcessLabel";
            this.focusedProcessLabel.Size = new System.Drawing.Size(104, 13);
            this.focusedProcessLabel.TabIndex = 5;
            this.focusedProcessLabel.Text = "No process selected";
            // 
            // procDetailsBtn
            // 
            this.procDetailsBtn.Location = new System.Drawing.Point(440, 515);
            this.procDetailsBtn.Name = "procDetailsBtn";
            this.procDetailsBtn.Size = new System.Drawing.Size(79, 25);
            this.procDetailsBtn.TabIndex = 6;
            this.procDetailsBtn.Text = "Details";
            this.procDetailsBtn.UseVisualStyleBackColor = true;
            this.procDetailsBtn.Click += new System.EventHandler(this.showDetails);
            // 
            // refreshProcButton
            // 
            this.refreshProcButton.Location = new System.Drawing.Point(347, 516);
            this.refreshProcButton.Name = "refreshProcButton";
            this.refreshProcButton.Size = new System.Drawing.Size(87, 24);
            this.refreshProcButton.TabIndex = 7;
            this.refreshProcButton.Text = "Refresh";
            this.refreshProcButton.UseVisualStyleBackColor = true;
            this.refreshProcButton.Click += new System.EventHandler(this.RfClicked);
            // 
            // putDownBtn
            // 
            this.putDownBtn.Location = new System.Drawing.Point(610, 515);
            this.putDownBtn.Name = "putDownBtn";
            this.putDownBtn.Size = new System.Drawing.Size(79, 25);
            this.putDownBtn.TabIndex = 8;
            this.putDownBtn.Text = "Close";
            this.putDownBtn.UseVisualStyleBackColor = true;
            this.putDownBtn.Click += new System.EventHandler(this.closeGraceFully);
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(213, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(376, 21);
            this.searchBox.TabIndex = 9;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchBoxNotifier
            // 
            this.searchBoxNotifier.AutoSize = true;
            this.searchBoxNotifier.Location = new System.Drawing.Point(610, 11);
            this.searchBoxNotifier.Name = "searchBoxNotifier";
            this.searchBoxNotifier.Size = new System.Drawing.Size(0, 13);
            this.searchBoxNotifier.TabIndex = 10;
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.searchBoxNotifier);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.putDownBtn);
            this.Controls.Add(this.refreshProcButton);
            this.Controls.Add(this.procDetailsBtn);
            this.Controls.Add(this.focusedProcessLabel);
            this.Controls.Add(this.mAtabHost);
            this.Controls.Add(this.endAllProcBtn);
            this.Controls.Add(this.forceKillBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainActivity";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Task Manager Lite";
            this.mAtabHost.ResumeLayout(false);
            this.foregroundProcPage.ResumeLayout(false);
            this.bgProcPage.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox runningAppsListBox;
        private System.Windows.Forms.Button forceKillBtn;
        private System.Windows.Forms.Button endAllProcBtn;
        private System.Windows.Forms.TabControl mAtabHost;
        private System.Windows.Forms.TabPage foregroundProcPage;
        private System.Windows.Forms.TabPage bgProcPage;
        private System.Windows.Forms.Label focusedProcessLabel;
        private System.Windows.Forms.ListBox bgProcListBox;
        private System.Windows.Forms.Button procDetailsBtn;
        private System.Windows.Forms.Button refreshProcButton;
        private System.Windows.Forms.Button putDownBtn;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.Label searchBoxNotifier;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label cpuT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar cpuProgBar;
        private System.Windows.Forms.ListView listView1;
    }
}

