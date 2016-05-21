namespace fMain
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.завершениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.процессыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.lvProcesses = new System.Windows.Forms.ListView();
            this.chProcesses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorkSet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.сhMamorSet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.сhPrioritet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCountMemorStat = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bRefresh = new System.Windows.Forms.ToolStripButton();
            this.bSeveAs = new System.Windows.Forms.ToolStripButton();
            this.bAddProsess = new System.Windows.Forms.ToolStripButton();
            this.bDelProsess = new System.Windows.Forms.ToolStripButton();
            this.bInfoProsess = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(574, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Процессов: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel2.Text = "Загрузка ЦП: 0%";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(169, 17);
            this.toolStripStatusLabel3.Text = "Свободная память: 0 MB (0%)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.процессыToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПроцессToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripSeparator2,
            this.завершениеToolStripMenuItem,
            this.stmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьПроцессToolStripMenuItem
            // 
            this.добавитьПроцессToolStripMenuItem.Image = global::fMain.Properties.Resources.add;
            this.добавитьПроцессToolStripMenuItem.Name = "добавитьПроцессToolStripMenuItem";
            this.добавитьПроцессToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.добавитьПроцессToolStripMenuItem.Text = "Добавить процесс";
            this.добавитьПроцессToolStripMenuItem.Click += new System.EventHandler(this.tsmiCreateProcess_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::fMain.Properties.Resources.buttonSave;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(178, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(178, 22);
            this.tsmiSaveAs.Text = "Сохранить как";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // завершениеToolStripMenuItem
            // 
            this.завершениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.выключениеToolStripMenuItem,
            this.перезагрузкаToolStripMenuItem});
            this.завершениеToolStripMenuItem.Name = "завершениеToolStripMenuItem";
            this.завершениеToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.завершениеToolStripMenuItem.Text = "Закрытие системы";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::fMain.Properties.Resources.buttonLogoff;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ButtonLOGOFF_Click);
            // 
            // выключениеToolStripMenuItem
            // 
            this.выключениеToolStripMenuItem.Image = global::fMain.Properties.Resources.buttonShutdown;
            this.выключениеToolStripMenuItem.Name = "выключениеToolStripMenuItem";
            this.выключениеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выключениеToolStripMenuItem.Text = "Выключение";
            this.выключениеToolStripMenuItem.Click += new System.EventHandler(this.ButtonPOWEROFF_Click);
            // 
            // перезагрузкаToolStripMenuItem
            // 
            this.перезагрузкаToolStripMenuItem.Image = global::fMain.Properties.Resources.buttonReboot;
            this.перезагрузкаToolStripMenuItem.Name = "перезагрузкаToolStripMenuItem";
            this.перезагрузкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.перезагрузкаToolStripMenuItem.Text = "Перезагрузка";
            this.перезагрузкаToolStripMenuItem.Click += new System.EventHandler(this.ButtonREBOOT_Click);
            // 
            // stmiExit
            // 
            this.stmiExit.Image = global::fMain.Properties.Resources.buttonExit;
            this.stmiExit.Name = "stmiExit";
            this.stmiExit.Size = new System.Drawing.Size(178, 22);
            this.stmiExit.Text = "Выход";
            this.stmiExit.Click += new System.EventHandler(this.stmiExit_Click);
            // 
            // процессыToolStripMenuItem
            // 
            this.процессыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьПроцессToolStripMenuItem});
            this.процессыToolStripMenuItem.Name = "процессыToolStripMenuItem";
            this.процессыToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.процессыToolStripMenuItem.Text = "Процессы";
            // 
            // удалитьПроцессToolStripMenuItem
            // 
            this.удалитьПроцессToolStripMenuItem.Image = global::fMain.Properties.Resources.del;
            this.удалитьПроцессToolStripMenuItem.Name = "удалитьПроцессToolStripMenuItem";
            this.удалитьПроцессToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.удалитьПроцессToolStripMenuItem.Text = "Удалить процесс";
            this.удалитьПроцессToolStripMenuItem.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.tsmiAuthor});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Image = global::fMain.Properties.Resources.help;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiHelp.Size = new System.Drawing.Size(152, 22);
            this.tsmiHelp.Text = "Помощь";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiAuthor
            // 
            this.tsmiAuthor.Image = global::fMain.Properties.Resources.Author;
            this.tsmiAuthor.Name = "tsmiAuthor";
            this.tsmiAuthor.Size = new System.Drawing.Size(152, 22);
            this.tsmiAuthor.Text = "Об авторе";
            this.tsmiAuthor.Click += new System.EventHandler(this.tsmiAuthor_Click);
            // 
            // lvProcesses
            // 
            this.lvProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProcesses,
            this.chPID,
            this.chWorkSet,
            this.сhMamorSet,
            this.сhPrioritet});
            this.lvProcesses.ContextMenuStrip = this.contextMenuStrip1;
            this.lvProcesses.FullRowSelect = true;
            this.lvProcesses.GridLines = true;
            this.lvProcesses.Location = new System.Drawing.Point(0, 52);
            this.lvProcesses.Name = "lvProcesses";
            this.lvProcesses.Size = new System.Drawing.Size(574, 382);
            this.lvProcesses.TabIndex = 10;
            this.lvProcesses.UseCompatibleStateImageBehavior = false;
            this.lvProcesses.View = System.Windows.Forms.View.Details;
            this.lvProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnColumnClick);
            // 
            // chProcesses
            // 
            this.chProcesses.Text = "Процесс";
            this.chProcesses.Width = 175;
            // 
            // chPID
            // 
            this.chPID.Text = "PID";
            this.chPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPID.Width = 59;
            // 
            // chWorkSet
            // 
            this.chWorkSet.Text = "Рабочая память";
            this.chWorkSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWorkSet.Width = 102;
            // 
            // сhMamorSet
            // 
            this.сhMamorSet.Text = "Физическая память";
            this.сhMamorSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.сhMamorSet.Width = 118;
            // 
            // сhPrioritet
            // 
            this.сhPrioritet.Text = "Приоритет";
            this.сhPrioritet.Width = 93;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAdd,
            this.cmsDel,
            this.cmsInfo});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 70);
            // 
            // cmsAdd
            // 
            this.cmsAdd.Image = global::fMain.Properties.Resources.add;
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(126, 22);
            this.cmsAdd.Text = "Добавить";
            this.cmsAdd.Click += new System.EventHandler(this.tsmiCreateProcess_Click);
            // 
            // cmsDel
            // 
            this.cmsDel.Image = global::fMain.Properties.Resources.del;
            this.cmsDel.Name = "cmsDel";
            this.cmsDel.Size = new System.Drawing.Size(126, 22);
            this.cmsDel.Text = "Удалить";
            this.cmsDel.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // cmsInfo
            // 
            this.cmsInfo.Image = global::fMain.Properties.Resources.info;
            this.cmsInfo.Name = "cmsInfo";
            this.cmsInfo.Size = new System.Drawing.Size(126, 22);
            this.cmsInfo.Text = "Свойства";
            this.cmsInfo.Click += new System.EventHandler(this.tsmiProperty_Click);
            // 
            // timerCountMemorStat
            // 
            this.timerCountMemorStat.Interval = 1000;
            this.timerCountMemorStat.Tick += new System.EventHandler(this.timerCountMemorStat_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bRefresh,
            this.bSeveAs,
            this.bAddProsess,
            this.bDelProsess,
            this.bInfoProsess});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(574, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bRefresh
            // 
            this.bRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bRefresh.Image = global::fMain.Properties.Resources.refresh;
            this.bRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(23, 22);
            this.bRefresh.Text = "Обновить";
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bSeveAs
            // 
            this.bSeveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSeveAs.Image = global::fMain.Properties.Resources.buttonSave;
            this.bSeveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSeveAs.Name = "bSeveAs";
            this.bSeveAs.Size = new System.Drawing.Size(23, 22);
            this.bSeveAs.Text = "Сохранить";
            this.bSeveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // bAddProsess
            // 
            this.bAddProsess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAddProsess.Image = global::fMain.Properties.Resources.add;
            this.bAddProsess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bAddProsess.Name = "bAddProsess";
            this.bAddProsess.Size = new System.Drawing.Size(23, 22);
            this.bAddProsess.Text = "Добавить процесс";
            this.bAddProsess.Click += new System.EventHandler(this.tsmiCreateProcess_Click);
            // 
            // bDelProsess
            // 
            this.bDelProsess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bDelProsess.Image = global::fMain.Properties.Resources.del;
            this.bDelProsess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bDelProsess.Name = "bDelProsess";
            this.bDelProsess.Size = new System.Drawing.Size(23, 22);
            this.bDelProsess.Text = "Уничтожить процесс";
            this.bDelProsess.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // bInfoProsess
            // 
            this.bInfoProsess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bInfoProsess.Image = global::fMain.Properties.Resources.info;
            this.bInfoProsess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bInfoProsess.Name = "bInfoProsess";
            this.bInfoProsess.Size = new System.Drawing.Size(23, 22);
            this.bInfoProsess.Text = "Информация о процессе";
            this.bInfoProsess.Click += new System.EventHandler(this.tsmiProperty_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 456);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvProcesses);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.Text = "Диспетчер задач";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView lvProcesses;
        private System.Windows.Forms.ColumnHeader chProcesses;
        private System.Windows.Forms.ColumnHeader chPID;
        private System.Windows.Forms.ColumnHeader chWorkSet;
        private System.Windows.Forms.ColumnHeader сhMamorSet;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процессыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem завершениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAuthor;
        private System.Windows.Forms.Timer timerCountMemorStat;
        private System.Windows.Forms.ToolStripMenuItem stmiExit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsDel;
        private System.Windows.Forms.ToolStripMenuItem cmsInfo;
        private System.Windows.Forms.ColumnHeader сhPrioritet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bRefresh;
        private System.Windows.Forms.ToolStripButton bSeveAs;
        private System.Windows.Forms.ToolStripButton bAddProsess;
        private System.Windows.Forms.ToolStripButton bDelProsess;
        private System.Windows.Forms.ToolStripButton bInfoProsess;
    }
}

