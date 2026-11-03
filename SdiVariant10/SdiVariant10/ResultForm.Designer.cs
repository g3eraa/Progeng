namespace SdiVariant10
{
    partial class ResultForm
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
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.flowLegend = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlZeroRow = new System.Windows.Forms.Panel();
            this.lblZeroRow = new System.Windows.Forms.Label();
            this.pnlEvenColumn = new System.Windows.Forms.Panel();
            this.lblEvenColumn = new System.Windows.Forms.Label();
            this.pnlCountedZero = new System.Windows.Forms.Panel();
            this.lblCountedZero = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.flowLegend.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvMatrix
            //
            this.dgvMatrix.AllowUserToAddRows = false;
            this.dgvMatrix.AllowUserToDeleteRows = false;
            this.dgvMatrix.AllowUserToResizeRows = false;
            this.dgvMatrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrix.EnableHeadersVisualStyles = false;
            this.dgvMatrix.Location = new System.Drawing.Point(0, 0);
            this.dgvMatrix.MultiSelect = false;
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.ReadOnly = true;
            this.dgvMatrix.RowHeadersWidth = 56;
            this.dgvMatrix.Size = new System.Drawing.Size(624, 223);
            this.dgvMatrix.TabIndex = 0;
            //
            // flowLegend
            //
            this.flowLegend.Controls.Add(this.pnlZeroRow);
            this.flowLegend.Controls.Add(this.lblZeroRow);
            this.flowLegend.Controls.Add(this.pnlEvenColumn);
            this.flowLegend.Controls.Add(this.lblEvenColumn);
            this.flowLegend.Controls.Add(this.pnlCountedZero);
            this.flowLegend.Controls.Add(this.lblCountedZero);
            this.flowLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLegend.Location = new System.Drawing.Point(0, 223);
            this.flowLegend.Name = "flowLegend";
            this.flowLegend.Padding = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.flowLegend.Size = new System.Drawing.Size(624, 30);
            this.flowLegend.TabIndex = 1;
            this.flowLegend.WrapContents = false;
            //
            // pnlZeroRow
            //
            this.pnlZeroRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZeroRow.Location = new System.Drawing.Point(11, 9);
            this.pnlZeroRow.Name = "pnlZeroRow";
            this.pnlZeroRow.Size = new System.Drawing.Size(16, 16);
            this.pnlZeroRow.TabIndex = 0;
            //
            // lblZeroRow
            //
            this.lblZeroRow.AutoSize = true;
            this.lblZeroRow.Location = new System.Drawing.Point(30, 9);
            this.lblZeroRow.Margin = new System.Windows.Forms.Padding(0, 3, 16, 0);
            this.lblZeroRow.Name = "lblZeroRow";
            this.lblZeroRow.Size = new System.Drawing.Size(116, 15);
            this.lblZeroRow.TabIndex = 1;
            this.lblZeroRow.Text = "строка из одних нулей";
            //
            // pnlEvenColumn
            //
            this.pnlEvenColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvenColumn.Location = new System.Drawing.Point(165, 9);
            this.pnlEvenColumn.Name = "pnlEvenColumn";
            this.pnlEvenColumn.Size = new System.Drawing.Size(16, 16);
            this.pnlEvenColumn.TabIndex = 2;
            //
            // lblEvenColumn
            //
            this.lblEvenColumn.AutoSize = true;
            this.lblEvenColumn.Location = new System.Drawing.Point(184, 9);
            this.lblEvenColumn.Margin = new System.Windows.Forms.Padding(0, 3, 16, 0);
            this.lblEvenColumn.Name = "lblEvenColumn";
            this.lblEvenColumn.Size = new System.Drawing.Size(92, 15);
            this.lblEvenColumn.TabIndex = 3;
            this.lblEvenColumn.Text = "чётный столбец";
            //
            // pnlCountedZero
            //
            this.pnlCountedZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCountedZero.Location = new System.Drawing.Point(295, 9);
            this.pnlCountedZero.Name = "pnlCountedZero";
            this.pnlCountedZero.Size = new System.Drawing.Size(16, 16);
            this.pnlCountedZero.TabIndex = 4;
            //
            // lblCountedZero
            //
            this.lblCountedZero.AutoSize = true;
            this.lblCountedZero.Location = new System.Drawing.Point(314, 9);
            this.lblCountedZero.Margin = new System.Windows.Forms.Padding(0, 3, 16, 0);
            this.lblCountedZero.Name = "lblCountedZero";
            this.lblCountedZero.Size = new System.Drawing.Size(178, 15);
            this.lblCountedZero.TabIndex = 5;
            this.lblCountedZero.Text = "ноль в чётном столбце (учтён)";
            //
            // txtResult
            //
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtResult.Location = new System.Drawing.Point(0, 253);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(624, 180);
            this.txtResult.TabIndex = 2;
            //
            // panelButtons
            //
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 433);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(624, 48);
            this.panelButtons.TabIndex = 3;
            //
            // btnClose
            //
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(522, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            //
            // ResultForm
            //
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.flowLegend);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panelButtons);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 400);
            this.Name = "ResultForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результат";
            this.Shown += new System.EventHandler(this.ResultForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.flowLegend.ResumeLayout(false);
            this.flowLegend.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.FlowLayoutPanel flowLegend;
        private System.Windows.Forms.Panel pnlZeroRow;
        private System.Windows.Forms.Label lblZeroRow;
        private System.Windows.Forms.Panel pnlEvenColumn;
        private System.Windows.Forms.Label lblEvenColumn;
        private System.Windows.Forms.Panel pnlCountedZero;
        private System.Windows.Forms.Label lblCountedZero;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnClose;
    }
}
