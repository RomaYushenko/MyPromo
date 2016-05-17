using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace fMain
{
    public partial class fProperty : Form
    {
        string NameProg;

        public fProperty(string name)
        {
            NameProg = name;
            InitializeComponent();
        }

        Process[] ProcessList = Process.GetProcesses();

        private void fProperty_Load(object sender, EventArgs e)
        {
            this.Text += " " + NameProg;


            //Process[] ProcessList = Process.GetProcesses();
            Process[] ProcessListCurrent = Process.GetProcessesByName(NameProg);
            for (int i = 0; i < ProcessList.Length; i++)
            {
                if (ProcessList[i].ProcessName == NameProg)
                {
                    lNameProcess.Text = ProcessList[i].ProcessName;
                    lPID.Text = ProcessList[i].Id.ToString();

                    lStartTime.Text = ProcessList[i].StartTime.ToString();
                    lUsetTime.Text = ProcessList[i].UserProcessorTime.ToString();
                    lTotalTime.Text = ProcessList[i].TotalProcessorTime.ToString();
                    

                    if (ProcessList[i].BasePriority == 4)
                        lBasePrior.Text = "Idle";//Приоритет
                    if (ProcessList[i].BasePriority == 8)
                        lBasePrior.Text = "Normal";//Приоритет
                    if (ProcessList[i].BasePriority == 13)
                        lBasePrior.Text = "High";//Приоритет
                    if (ProcessList[i].BasePriority == 24)
                        lBasePrior.Text = "RealTime";//Приоритет

                    //lWorkSet.Text = Math.Round((ProcessList[i].WorkingSet / 1024.0 / 1024.0), 2) + " mb";
                    //lVirtualMemorySize.Text = Math.Round((ProcessList[i].VirtualMemorySize / 1024.0 / 1024.0), 2) + " mb";
                    //lPagedMemorySize.Text = Math.Round((ProcessList[i].PagedMemorySize / 1024.0 / 1024.0), 2) + " mb";


                    

                    var executable = Process.GetProcessById(ProcessList[i].Id);
                    tbDirect.Text = executable.MainModule.FileName;
                    lVersion.Text = executable.MainModule.FileVersionInfo.FileVersion;
                    lSource.Text = executable.MainModule.FileVersionInfo.CompanyName;


                }

                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ProcessList.Length; i++)
            {
                if (ProcessList[i].ProcessName == NameProg)
                {
                    lWorkSet.Text = Math.Round((ProcessList[i].WorkingSet / 1024.0 / 1024.0), 2) + " mb";
                    lVirtualMemorySize.Text = Math.Round((ProcessList[i].VirtualMemorySize / 1024.0 / 1024.0), 2) + " mb";
                    lPagedMemorySize.Text = Math.Round((ProcessList[i].PagedMemorySize / 1024.0 / 1024.0), 2) + " mb";
                }
            }
        }
    }
}
