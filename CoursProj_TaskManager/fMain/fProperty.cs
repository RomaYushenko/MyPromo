using System;
using System.Drawing;
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
            infoProcess();
            pb_icon.Image = loadIcon(tbDirect.Text).ToBitmap();
        }

        private void infoProcess()
        {
            this.Text += " " + NameProg;

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

                    var executable = Process.GetProcessById(ProcessList[i].Id);
                    lVersion.Text = executable.MainModule.FileVersionInfo.FileVersion;
                    lSource.Text = executable.MainModule.FileVersionInfo.CompanyName;
                    tbDirect.Text = executable.MainModule.FileName;
                  }
            }
        }

        /// <summary>
        /// Методы для загрузки Иконки по пути
        /// </summary>
        /// <param name="path">путь к exe файлу</param>
        /// <returns>возращает иконку</returns>
        private Icon loadIcon(string path)
        {
            return new Icon(GetIcon.GetImageIcon(path), new Size(16, 16));
        }
    }
}
