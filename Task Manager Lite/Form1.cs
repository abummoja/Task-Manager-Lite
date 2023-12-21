using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager_Lite
{
    public partial class Form1 : Form
    {
        int CURRENT = 1;
        public Form1()
        {
            InitializeComponent();
            ListProcesses();
            tabPage1.GotFocus += TabPage1_GotFocus;
            tabPage2.GotFocus += TabPage2_GotFocus;
            try
            {
                getUsers();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        private void TabPage2_GotFocus(object sender, EventArgs e)
        {
            CURRENT = 2;
            Form1.ActiveForm.Text = Form1.ActiveForm.Text + ":Background Apps";
            //button3.Enabled = false;
            if(button3.Enabled == true)
            {
                button3.Enabled = false;
            }
        }

        private void TabPage1_GotFocus(object sender, EventArgs e)
        {
            CURRENT = 1;
            Form1.ActiveForm.Text = Form1.ActiveForm.Text + ":Foreground Apps";
            if(button3.Enabled == false)
            {
                button3.Enabled = true;
            }
        }

        private void ListProcesses()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach(Process p in processes)
            {
                if (!string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    //Console.WriteLine(p.ProcessName);
                    listBox1.Items.Add(p.ProcessName);
                    listBox1.Sorted = true;
                }
                else
                {
                    listBox2.Items.Add(p.ProcessName);
                    listBox2.Sorted = true;
                }
               
            }
        }

        private void endOneProcess(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName(label1.Text);
            foreach(var proc in p)
            {
                try
                {
                    proc.Kill();
                }catch (Exception)
                {
                    try
                    {
                        proc.Close();
                    }catch(Exception Ve)
                    {
                       MessageBox.Show("Could not end the task.");
                    }
                }
            }
            ListProcesses();
        }


        private void endAllProcesses(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                p.Kill();
            }
        }

        private void listItemClicked(object sender, EventArgs e)
        {
            getProcess(listBox1);
        }

        private void getProcess(ListBox listBox)
        {
            string selectedItem = listBox.SelectedItem.ToString();
            label1.Text = selectedItem;
        }

        private void listBgProcClicked(object sender, EventArgs e)
        {
            getProcess(listBox2);
        }

        private void showDetails(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName(label1.Text);
            foreach(var pr in p)
            {
                string name = pr.ProcessName.ToString();
                if(name.Equals("Task Manager Lite"))
                {
                    name = "This Application (Task Manager Lite)";
                }
                var id = pr.Id;
                var path = "SysWin";
                try
                {
                    path = pr.MainModule.FileName;
                }
                catch (Exception)
                {
                    path = "System32";
                }
               
                var mwinTitle = pr.MainWindowTitle;
                string w64 = pr.WorkingSet64.ToString();
               // string ws = pr.WorkingSet.ToString();
                string bp = pr.BasePriority.ToString();
                string pc;
                try
                {
                    pc = pr.PriorityClass.ToString();
            
                }
                catch (Exception)
                {
                    pc = "Background Process";
                }
                string uproc;
                try
                {
                    uproc = pr.UserProcessorTime.ToString();
                }
                catch (Exception)
                {
                    uproc = "Unavailable";
                }
                string pproc;
                try
                {
                     pproc = pr.PrivilegedProcessorTime.ToString();
                }
                catch (Exception)
                {
                    pproc = "Unavailable";
                }
                string tproc;
                try
                {
                    tproc = pr.TotalProcessorTime.ToString();
                }
                catch (Exception)
                {
                    tproc = "Unhandled";
                }
                string psysmem = pr.PagedSystemMemorySize64.ToString();
                string pmem = pr.PagedMemorySize64.ToString();
                string resp = pr.Responding.ToString();
                String details = "Name: "+name+"\nId: "+id+"\nPath: "+path+"\nMain Window Title: "+mwinTitle+"\nWorking set: " + w64+"\nBase priority: "+bp+"\nPriorityClass: "
                    +pc+"\nProcessor Time: "+uproc+"\nPrivileged Time: "+pproc+"\nTotal Processor Time: "+tproc+"\nPaged System Memory: "+psysmem
                    +"\nPaged Memory: "+pmem+"\nIs Responsive: "+resp;
                MessageBox.Show(details);

           
    
            }
        }

        void refreshProcess()
        {
            Process[] p = Process.GetProcessesByName(label1.Text);
            foreach (var proc in p)
            {
                try
                {
                    proc.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to refresh");
                }
                
            }
        }

        private void RfClicked(object sender, EventArgs e)
        {
            refreshProcess();
        }

        private void closeGraceFully(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName(label1.Text);
            foreach (var proc in p)
            {
                try
                {
                    proc.CloseMainWindow();
                }
                catch (Exception)
                {
                    try
                    {
                        proc.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not end the task.");
                    }
                }
            }
            ListProcesses();
        }

        void getUsers()
        {
            //TODO: get users and their CPU Usage to allow us to force log them out#
            string path = @"C:\Users\";
            string[] usrs = System.IO.Directory.GetDirectories(path);
            
            foreach(string usr in usrs)
            {
                Console.WriteLine(usr.LastIndexOf("/"));
                //ERROR: The code above returns -1
            }
        }
    }
}
