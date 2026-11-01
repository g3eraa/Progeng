namespace SdiVariant5
{
    partial class TaskSelectForm
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
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.chkZeroRow = new System.Windows.Forms.CheckBox();
            this.chkEvenColumns = new System.Windows.Forms.CheckBox();
            this.grpNumbering = new System.Windows.Forms.GroupBox();
            this.rbFromOne = new System.Windows.Forms.RadioButton();
            this.rbFromZero = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpTasks.SuspendLayout();
            this.grpNumbering.SuspendLayout();
            this.SuspendLayout();
            //
            // grpTasks
            //
            this.grpTasks.Controls.Add(this.chkZeroRow);
            this.grpTasks.Controls.Add(this.chkEvenColumns);
            this.grpTasks.Location = new System.Drawing.Point(12, 12);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(456, 84);
            this.grpTasks.TabIndex = 0;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Решаемые задачи";
            //
            // chkZeroRow
            //
            this.chkZeroRow.AutoSize = true;
            this.chkZeroRow.Location = new System.Drawing.Point(14, 24);
            this.chkZeroRow.Name = "chkZeroRow";
            this.chkZeroRow.Size = new System.Drawing.Size(399, 19);
            this.chkZeroRow.TabIndex = 0;
            this.chkZeroRow.Text = "1. Имеется ли строка, состоящая только из нулевых элементов";
            this.chkZeroRow.UseVisualStyleBackColor = true;
            //
            // chkEvenColumns
            //
            this.chkEvenColumns.AutoSize = true;
            this.chkEvenColumns.Location = new System.Drawing.Point(14, 52);
            this.chkEvenColumns.Name = "chkEvenColumns";
            this.chkEvenColumns.Size = new System.Drawing.Size(408, 19);
            this.chkEvenColumns.TabIndex = 1;
            this.chkEvenColumns.Text = "2. Суммарное количество нулевых элементов в чётных столбцах";
            this.chkEvenColumns.UseVisualStyleBackColor = true;
            //
            // grpNumbering
            //
            this.grpNumbering.Controls.Add(this.rbFromOne);
            this.grpNumbering.Controls.Add(this.rbFromZero);
            this.grpNumbering.Location = new System.Drawing.Point(12, 104);
            this.grpNumbering.Name = "grpNumbering";
            this.grpNumbering.Size = new System.Drawing.Size(456, 84);
            this.grpNumbering.TabIndex = 1;
            this.grpNumbering.TabStop = false;
            this.grpNumbering.Text = "Нумерация строк и столбцов";
            //
            // rbFromOne
            //
            this.rbFromOne.AutoSize = true;
            this.rbFromOne.Checked = true;
            this.rbFromOne.Location = new System.Drawing.Point(14, 24);
            this.rbFromOne.Name = "rbFromOne";
            this.rbFromOne.Size = new System.Drawing.Size(232, 19);
            this.rbFromOne.TabIndex = 0;
            this.rbFromOne.TabStop = true;
            this.rbFromOne.Text = "с 1 — чётные столбцы: 2, 4, 6, …";
            this.rbFromOne.UseVisualStyleBackColor = true;
            //
            // rbFromZero
            //
            this.rbFromZero.AutoSize = true;
            this.rbFromZero.Location = new System.Drawing.Point(14, 52);
            this.rbFromZero.Name = "rbFromZero";
            this.rbFromZero.Size = new System.Drawing.Size(352, 19);
            this.rbFromZero.TabIndex = 1;
            this.rbFromZero.Text = "с 0 (индексы C#) — чётные столбцы: 0, 2, 4, …";
            this.rbFromZero.UseVisualStyleBackColor = true;
            //
            // btnOk
            //
            this.btnOk.Location = new System.Drawing.Point(282, 202);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(378, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // TaskSelectForm
            //
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 242);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.grpNumbering);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskSelectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор задачи";
            this.grpTasks.ResumeLayout(false);
            this.grpTasks.PerformLayout();
            this.grpNumbering.ResumeLayout(false);
            this.grpNumbering.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.CheckBox chkZeroRow;
        private System.Windows.Forms.CheckBox chkEvenColumns;
        private System.Windows.Forms.GroupBox grpNumbering;
        private System.Windows.Forms.RadioButton rbFromOne;
        private System.Windows.Forms.RadioButton rbFromZero;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
