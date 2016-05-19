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
        ViewControls vc = new ViewControls();

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
        /// Событие при нажатие на кнопку открытие процесса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreateProcess_Click(object sender, EventArgs e)
        {
            vc.CreateProcess(PathFileName, tbPathPog, this);
        }

        private void tbPathPog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.Cursor = Cursors.AppStarting;
                vc.CreateProcess(PathFileName, tbPathPog, this);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
