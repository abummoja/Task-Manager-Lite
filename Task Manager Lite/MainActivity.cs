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
    public partial class MainActivity : Form
    {
        int CURRENT = 1;
        List<string> lb1 = new List<string>();
        List<string> lb2 = new List<string>();
        PerformanceCounter cpuMan;
        public MainActivity()
        {
           // searchBoxNotifier.Text = "< Search Here.";
            InitializeComponent();
            ListProcesses();
            foregroundProcPage.GotFocus += TabPage1_GotFocus;
            bgProcPage.GotFocus += TabPage2_GotFocus;
            searchBox.DropDown += SearchBox_DropDown;
            searchBox.DropDownClosed += SearchBox_DropDownClosed;
            //updatePerfMon();
            try
            {
                getUsers();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
           /* System.Threading.Thread ut = new System.Threading.Thread(ListProcesses);
            ut.Start();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
            }*/
        }

     /*   private float CPUMonitor()
        {
            cpuMan = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            dynamic firstVal = cpuMan.NextValue();
            //System.Threading.Thread.Sleep(1000);
            dynamic secondVal = cpuMan.NextValue();
            return secondVal;

        }

        void updatePerfMon()
        {
            try
            {
                int cpuPerc = (int)CPUMonitor();
                cpuT.Text = cpuPerc + "%";
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }*/

        private void SearchBox_DropDownClosed(object sender, EventArgs e)
        {
            searchBoxNotifier.Text = "< Search Here.";
            if(searchBox.Text != "")
            {
                focusedProcessLabel.Text = searchBox.Text;
            }
        }

        private void SearchBox_DropDown(object sender, EventArgs e)
        {
            searchBoxNotifier.Text = "Press Esc to close search.";
        }

        private void TabPage2_GotFocus(object sender, EventArgs e)
        {
            CURRENT = 2;
            MainActivity.ActiveForm.Text = MainActivity.ActiveForm.Text + ":Background Apps";
            //button3.Enabled = false;
            if(procDetailsBtn.Enabled == true)
            {
                procDetailsBtn.Enabled = false;
            }
        }

        private void TabPage1_GotFocus(object sender, EventArgs e)
        {
            CURRENT = 1;
            MainActivity.ActiveForm.Text = MainActivity.ActiveForm.Text + ":Foreground Apps";
            if(procDetailsBtn.Enabled == false)
            {
                procDetailsBtn.Enabled = true;
            }
        }

        private void ListProcesses()
        {
            /*ImageList ImgList = new ImageList();
            listView1.View = View.SmallIcon;
            listView1.SmallImageList = ImgList;
            ImgList.ImageSize = new Size(20, 20);
            ImgList.TransparentColor = Color.Transparent;
            Icon res;*/

            lb1.Clear();
            lb2.Clear();
            runningAppsListBox.Items.Clear();
            bgProcListBox.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach(Process p in processes)
            {
                if (!string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    //Console.WriteLine(p.ProcessName);
                    runningAppsListBox.Items.Add(p.ProcessName);
                    lb1.Add(p.ProcessName);
                    runningAppsListBox.Sorted = true;
                }
                else
                {
                    bgProcListBox.Items.Add(p.ProcessName);
                    lb2.Add(p.ProcessName);
                    bgProcListBox.Sorted = true;
                }
                /*res = Icon.ExtractAssociatedIcon(p.MainModule.FileName);
                ImgList.Images.Add(res);
                listView1.Items.Add(p.ProcessName);*/
            }
        }

        private void endOneProcess(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName(focusedProcessLabel.Text);
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
            getProcess(runningAppsListBox);
        }

        private void getProcess(ListBox listBox)
        {
            string selectedItem = listBox.SelectedItem.ToString();
            focusedProcessLabel.Text = selectedItem;
        }

        private void listBgProcClicked(object sender, EventArgs e)
        {
            getProcess(bgProcListBox);
        }

        private void showDetails(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName(focusedProcessLabel.Text);
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
            Process[] p = Process.GetProcessesByName(focusedProcessLabel.Text);
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
            Process[] p = Process.GetProcessesByName(focusedProcessLabel.Text);
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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string kwd = searchBox.Text.ToLower();
            searchBox.Items.Clear();
            searchBox.Select(searchBox.Text.Length, 0);
            List<String> results = new List<string>();
            foreach(string s in lb1)
            {
                if (s.ToLower().StartsWith(kwd))
                {
                    searchBox.Items.Add(s);
                }
            }
            foreach (string s in lb2)
            {
                if (s.ToLower().StartsWith(kwd))
                {
                    searchBox.Items.Add(s);
                }
            }
            searchBox.DroppedDown = true;
        }
    }
}
