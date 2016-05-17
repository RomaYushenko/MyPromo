using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//winApi
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace fMain
{
    public partial class fMain : Form
    {
 
        ItemComparer itemComparer = new ItemComparer();
        ViewControls vc = new ViewControls();

        public fMain()
        {
            InitializeComponent();
            lvProcesses.ListViewItemSorter = itemComparer;    
        }

        /// <summary>
        /// Метод которые выполняется при первой загрузке программы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fMain_Load(object sender, EventArgs e)
        {
            timerCountMemorStat.Enabled = true;
            //timer1.Enabled = true;
            //viewInf();
            FuncWinApiShutdownReboot.setBoss();
            viewInfNew();
            
            
        }


        /// <summary>
        /// Методы для вывод всех процессов в ListView
        /// </summary>
        public void viewInfNew()
        {
            lvProcesses.BeginUpdate();
            
            Process[] ProcessList = Process.GetProcesses();
            for (int i = 0; i < ProcessList.Length; i++)
            {

                ListViewItem itm2 = new ListViewItem(ProcessList[i].ProcessName);//Имя образа
                itm2.SubItems.Add(ProcessList[i].Id.ToString());//PID
                itm2.SubItems.Add(Math.Round((ProcessList[i].WorkingSet / 1024.0 / 1024.0),2) + " mb");//Рабочая память
                itm2.SubItems.Add(Math.Round((ProcessList[i].PagedMemorySize / 1024.0 / 1024.0), 2) + " mb");//Вирт.п.
                switch (ProcessList[i].BasePriority)
                {
                    case 4:
                        {
                            itm2.SubItems.Add("Idle");
                            break;
                        }
                    case 8:
                        {
                            itm2.SubItems.Add("Normal");
                            break;
                        }
                    case 13:
                        {
                            itm2.SubItems.Add("High");
                            break;
                        }
                    case 24:
                        {
                            itm2.SubItems.Add("RealTime");
                            break;
                        }
                    default:
                        itm2.SubItems.Add("null");
                        break;
                }
                this.lvProcesses.Items.Add(itm2);
              }

              lvProcesses.EndUpdate();

          }

          /// <summary>
          /// Метод для выкючения компьютера
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void ButtonPOWEROFF_Click(object sender, EventArgs e)
          {
              // Выключение компьютера          
              FuncWinApiShutdownReboot.poweroffPC();
          }

          /// <summary>
          /// Метод для перезагрузка компьютера
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void ButtonREBOOT_Click(object sender, EventArgs e)
          {
              // Выключение компьютера
              FuncWinApiShutdownReboot.rebootPC();
          }

          /// <summary>
          /// Метод для выхода из системы
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void ButtonLOGOFF_Click(object sender, EventArgs e)
          {
              // Выход из системы       
              FuncWinApiShutdownReboot.logoffPC();
          }

          /// <summary>
          /// Таймер которые обновляет все системыне параметры (Загрузку ЦП, Физическая память)
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void timerCountMemorStat_Tick(object sender, EventArgs e)
          {
              FuncWinApiTotalPhys status = FuncWinApiTotalPhys.CreateInstance();
              FuncWinApiLoadCP load = FuncWinApiLoadCP.CreateInstanceCP();
              int countProc = lvProcesses.Items.Count;
              ulong Aram = status.AvailPhys;
              ulong Tram = status.TotalPhys;
              string mamo = load.GetIdleTime();
              toolStripStatusLabel1.Text = "Процессов: " + countProc;
              toolStripStatusLabel2.Text = "Загрузка ЦП: " + mamo + "%";
              toolStripStatusLabel3.Text = "Свободная память: " + (Aram / 1024 / 1024) + " MB (" + (100 - ((Aram * 100) / Tram)) + "%) ";

          }

          /// <summary>
          /// Событие открывает новую форму для добавление нового процесса с правами администратора
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void tsmiCreateProcess_Click(object sender, EventArgs e)
          {
              fCreateProcess fcp = new fCreateProcess();
              fcp.Show();

          }

          /// <summary>
          /// Событие для уничтожение процесса
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void tsmiDelete_Click(object sender, EventArgs e)
          {
                  vc.del(lvProcesses);
          }

          /// <summary>
          /// Событие открывает Help
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void tsmiHelp_Click(object sender, EventArgs e)
          {
              vc.LoadHelp(this);
          }

          /// <summary>
          /// Событие завершает прроцесс гланвоей программы
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void stmiExit_Click(object sender, EventArgs e)
          {
              this.Close();
          }

          /// <summary>
          /// Событие открывает форму Об авторе
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void tsmiAuthor_Click(object sender, EventArgs e)
          {
              fAuthor fa = new fAuthor();
              fa.Show();
          }

          /// <summary>
          /// Событие Сохранить
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void tsmiSave_Click(object sender, EventArgs e)
          {
              vc.SaveFile(lvProcesses);
          }
        
          /// <summary>
          /// Событие открывает форму "Свойства"
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void tsmiProperty_Click(object sender, EventArgs e)
          {
              fProperty fp = new fProperty(lvProcesses.FocusedItem.Text);
              fp.Show();
          }
          
          /// <summary>
          /// Событие Сохранить как...
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void tsmiSaveAs_Click(object sender, EventArgs e)
          {
              vc.SaveFileAs(lvProcesses);
          }

          /// <summary>
          /// Сортирует ListView
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          void OnColumnClick(object sender, ColumnClickEventArgs e)
          {
              //Указываем сортируемую колонку
              itemComparer.ColumnIndex = e.Column;
              //Непосредственно инициируем сортировку
              ((ListView)sender).Sort();
          }

          /// <summary>
          /// Сохранение при нажатие Ctrl + S 
          /// Открытие Хелпера при нажатие на F1
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void fMain_KeyDown(object sender, KeyEventArgs e)
          {
              if (e.Control && e.KeyCode.Equals(Keys.S))
              {
                  this.Cursor = Cursors.AppStarting;
                  vc.SaveFile(lvProcesses);
              }
              if (e.KeyCode.Equals(Keys.F1))
              {
                  this.Cursor = Cursors.AppStarting;
                  vc.LoadHelp(this);
              }
              this.Cursor = Cursors.Default;
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
              lvProcesses.Clear();
              this.lvProcesses.GridLines = true;
              this.lvProcesses.View = View.Details;
              this.lvProcesses.FullRowSelect = true;
              this.lvProcesses.Columns.Add("Процесс", 175);
              this.lvProcesses.Columns.Add("PID", 59);
              this.lvProcesses.Columns.Add("Рабочая память", 102);
              this.lvProcesses.Columns.Add("Физическая память", 118);
              this.lvProcesses.Columns.Add("Приоритет", 93);
              this.lvProcesses.Columns.Add("", 60);
              viewInfNew();
          }

          private void bRefresh_Click(object sender, EventArgs e)
          {
              lvProcesses.Clear();
              this.lvProcesses.GridLines = true;
              this.lvProcesses.View = View.Details;
              this.lvProcesses.FullRowSelect = true;
              this.lvProcesses.Columns.Add("Процесс", 175);
              this.lvProcesses.Columns.Add("PID", 59);
              this.lvProcesses.Columns.Add("Рабочая память", 102);
              this.lvProcesses.Columns.Add("Физическая память", 118);
              this.lvProcesses.Columns.Add("Приоритет", 93);
              this.lvProcesses.Columns.Add("", 60);
              viewInfNew();
              this.lvProcesses.Refresh();
              //this.Controls.Add(this.lvProcesses);
          }
      }
  }
