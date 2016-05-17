using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fMain
{
    public partial class fCreateProcess : Form
    {
              
        public fCreateProcess()
        {
            InitializeComponent();
        }

        string PathFileName;

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Собыите при нажатие на кнопку открывается OpenFileDialog
        /// для выбора названия файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bFileName_Click(object sender, EventArgs e)
        {
            PathFileName = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "exe files (*.exe)|*.exe";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PathFileName = dialog.FileName;
                tbPathPog.Text = PathFileName;
            }
        }

        /// <summary>
        /// Событие при нажатие на кнопку идет поиск и создание процесса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreateProcess_Click(object sender, EventArgs e)
        {
            if (tbPathPog.Text != "")
            {
                bool flag;
                FuncWinApiCreateProcess crProc = FuncWinApiCreateProcess.CreateInstanceCrProc();

                PathFileName = tbPathPog.Text;
                string[] str = PathFileName.Split('\\');
                if (str[0] == "C:" || str[0] == "D:" || str[0] == "E:" || str[0] == "F:")
                {
                    flag = true;
                    crProc.CreateProcessInPC(PathFileName, flag);
                }
                else
                {
                    flag = false;
                    crProc.CreateProcessInPC(PathFileName, flag);
                }
                this.Close();
            }
            else
                MessageBox.Show("Вы не вписали процесс который хотит запуссить", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
