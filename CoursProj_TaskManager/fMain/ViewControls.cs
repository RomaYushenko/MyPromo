using System;
using System.IO;
using System.Windows.Forms;

namespace fMain
{
    class ViewControls
    {
        

        public void del(ListView lv)
        {
            FuncWinApiTerminateProcess ter = FuncWinApiTerminateProcess.CreateInstanceT();

            string NameProg = lv.FocusedItem.Text; //NameProgram(lv.SelectedItems);

            //Проходимся по всем процессам локального компьютера.
            foreach (System.Diagnostics.Process clsProcess in System.Diagnostics.Process.GetProcesses())
            {
                //Определяем, совпадает ли начало имени процесса с указанным.
                //Если да, то метод "StartsWith" возвращает значение true
                //и вызывается метод удаления процесса,
                //в противном случае — значение false и происходит
                //переход к следующему процессу.
                if (clsProcess.ProcessName.StartsWith(NameProg))
                {
                    ter.TerminateProcess((IntPtr)clsProcess.Id);

                    if (clsProcess.HasExited)
                        MessageBox.Show("Процесс успешно завершён!", "Завершение процесса",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ошибка при завершении процесса.", "Завершение процесса",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Метод которые беред строку и достает из нее название процесса
        /// </summary>
        /// <param name="breakfast">Коллекция названий включенных процессов</param>
        /// <returns>Возращает имя процесса</returns>
        public string NameProgram(ListView.SelectedListViewItemCollection breakfast)
        {
            string s = breakfast[0].ToString();
            string[] str = s.Split('{');
            string[] ttt = str[str.Length - 1].Split('.');
            string Name = ttt[0];
            return Name;
        }

        public void LoadHelp(Control url)
        {
            Help.ShowHelp(url,"Help.chm");
        }

        public void SaveFile(ListView lv)
        {
            OperatingSystem os = Environment.OSVersion;
            if (lv.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("ProsessManager.txt"))
                {
                    TW.WriteLine("Диспетчер задач v1.0 \n" + DateTime.Now.ToString() + "\n"+ os.VersionString + "\n\nИмя процесса\t\tPID\t\tРабочая память\t\tФизическая память\tПриоритет");
                    foreach (ListViewItem item in lv.Items)
                    {
                        for (int a = 0; a < lv.Columns.Count; a++)
                        {
                            TW.Write(item.SubItems[a].Text + "\t\t\t");
                        }
                        TW.WriteLine();
                    }
                }

            }
        }

        /// <summary>
        /// Метод для сохранение ListView в файл
        /// </summary>
        /// <param name="lv">компанент ListView</param>
        public void SaveFileAs(ListView lv)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            OperatingSystem os = Environment.OSVersion;

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        sw.WriteLine("Диспетчер задач v1.0 \n" + DateTime.Now.ToString() + "\n" + os.VersionString + "\n\nИмя процесса\t\tPID\t\tРабочая память\t\tФизическая память\tПриоритет");
                        foreach (ListViewItem item in lv.Items)
                        {
                            for (int a = 0; a < lv.Columns.Count; a++)
                            {
                                sw.Write(item.SubItems[a].Text + "\t\t\t");
                            }
                            sw.WriteLine();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод для поиск и создание процесса
        /// </summary>
        /// <param name="PathFileName">имя файла</param>
        /// <param name="tbPathPog">Имя текст бокса</param>
        /// <param name="F">Имя формы</param>
        public void CreateProcess(string PathFileName, TextBox tbPathPog, Form F)
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
                F.Close();
            }
            else
                MessageBox.Show("Вы не вписали процесс который хотит запуссить", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
