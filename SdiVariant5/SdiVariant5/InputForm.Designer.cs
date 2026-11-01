namespace SdiVariant5
{
    partial class InputForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblRows = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.btnClearRow = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.btnRandom = new System.Windows.Forms.Button();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            //
            // panelTop
            //
            this.panelTop.Controls.Add(this.lblRows);
            this.panelTop.Controls.Add(this.nudRows);
            this.panelTop.Controls.Add(this.lblColumns);
            this.panelTop.Controls.Add(this.nudColumns);
            this.panelTop.Controls.Add(this.btnClearRow);
            this.panelTop.Controls.Add(this.btnClearAll);
            this.panelTop.Controls.Add(this.lblRandom);
            this.panelTop.Controls.Add(this.nudMin);
            this.panelTop.Controls.Add(this.lblTo);
            this.panelTop.Controls.Add(this.nudMax);
            this.panelTop.Controls.Add(this.btnRandom);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(624, 84);
            this.panelTop.TabIndex = 0;
            //
            // lblRows
            //
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(12, 16);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(42, 15);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Строк:";
            //
            // nudRows
            //
            this.nudRows.Location = new System.Drawing.Point(60, 12);
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(55, 23);
            this.nudRows.TabIndex = 1;
            this.nudRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRows.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            //
            // lblColumns
            //
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(132, 16);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(62, 15);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Столбцов:";
            //
            // nudColumns
            //
            this.nudColumns.Location = new System.Drawing.Point(200, 12);
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(55, 23);
            this.nudColumns.TabIndex = 3;
            this.nudColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            //
            // btnClearRow
            //
            this.btnClearRow.Location = new System.Drawing.Point(300, 10);
            this.btnClearRow.Name = "btnClearRow";
            this.btnClearRow.Size = new System.Drawing.Size(150, 27);
            this.btnClearRow.TabIndex = 4;
            this.btnClearRow.Text = "Обнулить строку";
            this.btnClearRow.UseVisualStyleBackColor = true;
            this.btnClearRow.Click += new System.EventHandler(this.btnClearRow_Click);
            //
            // btnClearAll
            //
            this.btnClearAll.Location = new System.Drawing.Point(460, 10);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(150, 27);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Обнулить всё";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            //
            // lblRandom
            //
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(12, 51);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(112, 15);
            this.lblRandom.TabIndex = 6;
            this.lblRandom.Text = "Случайные числа от";
            //
            // nudMin
            //
            this.nudMin.Location = new System.Drawing.Point(132, 47);
            this.nudMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(60, 23);
            this.nudMin.TabIndex = 7;
            this.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMin.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            //
            // lblTo
            //
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(200, 51);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 15);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "до";
            //
            // nudMax
            //
            this.nudMax.Location = new System.Drawing.Point(227, 47);
            this.nudMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(60, 23);
            this.nudMax.TabIndex = 9;
            this.nudMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            //
            // btnRandom
            //
            this.btnRandom.Location = new System.Drawing.Point(300, 45);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(150, 27);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "Заполнить случайно";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            //
            // dgvMatrix
            //
            this.dgvMatrix.AllowUserToAddRows = false;
            this.dgvMatrix.AllowUserToDeleteRows = false;
            this.dgvMatrix.AllowUserToResizeRows = false;
            this.dgvMatrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrix.Location = new System.Drawing.Point(0, 84);
            this.dgvMatrix.MultiSelect = false;
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersWidth = 56;
            this.dgvMatrix.Size = new System.Drawing.Size(624, 309);
            this.dgvMatrix.TabIndex = 1;
            this.dgvMatrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellEndEdit);
            this.dgvMatrix.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMatrix_CellValidating);
            this.dgvMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellValueChanged);
            //
            // panelBottom
            //
            this.panelBottom.Controls.Add(this.lblHint);
            this.panelBottom.Controls.Add(this.btnOk);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 393);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(624, 48);
            this.panelBottom.TabIndex = 2;
            //
            // lblHint
            //
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHint.Location = new System.Drawing.Point(12, 17);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(285, 15);
            this.lblHint.TabIndex = 0;
            this.lblHint.Text = "Выделите ячейку и введите целое число (F2 — правка)";
            //
            // btnOk
            //
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(424, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 28);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            //
            // btnCancel
            //
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(522, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // InputForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 300);
            this.Name = "InputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод исходных данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputForm_FormClosing);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Button btnClearRow;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
