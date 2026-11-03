namespace SdiVariant10
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miArray = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.miTask = new System.Windows.Forms.ToolStripMenuItem();
            this.miChooseTask = new System.Windows.Forms.ToolStripMenuItem();
            this.miTaskSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miSolve = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTasks = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCondition = new System.Windows.Forms.Label();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.SuspendLayout();
            //
            // menuStrip
            //
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miArray,
            this.miTask,
            this.miHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            //
            // miFile
            //
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Text = "&Файл";
            //
            // miExit
            //
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeyDisplayString = "Alt+F4";
            this.miExit.Text = "&Выход";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            //
            // miArray
            //
            this.miArray.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEdit,
            this.miRandom});
            this.miArray.Name = "miArray";
            this.miArray.Text = "&Массив";
            //
            // miEdit
            //
            this.miEdit.Name = "miEdit";
            this.miEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.miEdit.Text = "&Ввод и редактирование…";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            //
            // miRandom
            //
            this.miRandom.Name = "miRandom";
            this.miRandom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.miRandom.Text = "&Заполнить случайными числами";
            this.miRandom.Click += new System.EventHandler(this.miRandom_Click);
            //
            // miTask
            //
            this.miTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChooseTask,
            this.miTaskSeparator,
            this.miSolve});
            this.miTask.Name = "miTask";
            this.miTask.Text = "&Задача";
            //
            // miChooseTask
            //
            this.miChooseTask.Name = "miChooseTask";
            this.miChooseTask.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.miChooseTask.Text = "&Выбор задачи…";
            this.miChooseTask.Click += new System.EventHandler(this.miChooseTask_Click);
            //
            // miTaskSeparator
            //
            this.miTaskSeparator.Name = "miTaskSeparator";
            //
            // miSolve
            //
            this.miSolve.Name = "miSolve";
            this.miSolve.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miSolve.Text = "&Решить";
            this.miSolve.Click += new System.EventHandler(this.miSolve_Click);
            //
            // miHelp
            //
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Text = "&Справка";
            //
            // miAbout
            //
            this.miAbout.Name = "miAbout";
            this.miAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miAbout.Text = "&О программе…";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            //
            // statusStrip
            //
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSize,
            this.lblTasks});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            //
            // lblSize
            //
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(90, 17);
            this.lblSize.Text = "Массив: 0 × 0";
            //
            // lblTasks
            //
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(579, 17);
            this.lblTasks.Spring = true;
            this.lblTasks.Text = "Задачи:";
            this.lblTasks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblCondition
            //
            this.lblCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCondition.Location = new System.Drawing.Point(0, 24);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.lblCondition.Size = new System.Drawing.Size(684, 72);
            this.lblCondition.TabIndex = 1;
            this.lblCondition.Text = "Вариант 10. Дан двумерный массив.\r\n" +
    "1) Имеется ли в исходном массиве строка, состоящая только из нулевых элементов?\r\n" +
    "2) Определить суммарное количество нулевых элементов в чётных столбцах.";
            //
            // dgvMatrix
            //
            this.dgvMatrix.AllowUserToAddRows = false;
            this.dgvMatrix.AllowUserToDeleteRows = false;
            this.dgvMatrix.AllowUserToResizeRows = false;
            this.dgvMatrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrix.Location = new System.Drawing.Point(0, 96);
            this.dgvMatrix.MultiSelect = false;
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.ReadOnly = true;
            this.dgvMatrix.RowHeadersWidth = 56;
            this.dgvMatrix.Size = new System.Drawing.Size(684, 343);
            this.dgvMatrix.TabIndex = 2;
            this.dgvMatrix.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellDoubleClick);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDI-приложение — Вариант 10";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miArray;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miRandom;
        private System.Windows.Forms.ToolStripMenuItem miTask;
        private System.Windows.Forms.ToolStripMenuItem miChooseTask;
        private System.Windows.Forms.ToolStripSeparator miTaskSeparator;
        private System.Windows.Forms.ToolStripMenuItem miSolve;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblSize;
        private System.Windows.Forms.ToolStripStatusLabel lblTasks;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.DataGridView dgvMatrix;
    }
}
