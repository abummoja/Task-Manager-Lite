
namespace Task_Manager_Lite
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(791, 485);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listItemClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Force Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.endOneProcess);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "End All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.endAllProcesses);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 509);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Running Apps";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Background Processes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(795, 485);
            this.listBox2.TabIndex = 0;
            this.listBox2.Click += new System.EventHandler(this.listBgProcClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No process selected";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.showDetails);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 24);
            this.button4.TabIndex = 7;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RfClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(610, 515);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.closeGraceFully);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Task Manager Lite";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

