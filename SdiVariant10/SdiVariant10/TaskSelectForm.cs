using System;
using System.Windows.Forms;

namespace SdiVariant10
{
    /// <summary>
    /// Диалог выбора решаемой задачи.
    /// </summary>
    public partial class TaskSelectForm : Form
    {
        public TaskSelectForm(TaskOptions current)
        {
            InitializeComponent();
            Options = current.Clone();

            chkZeroRow.Checked = current.FindZeroRow;
            chkEvenColumns.Checked = current.CountZerosInEvenColumns;
            rbFromOne.Checked = current.Numbering == Numbering.FromOne;
            rbFromZero.Checked = current.Numbering == Numbering.FromZero;
        }

        /// <summary>Выбранные задачи (действительны после закрытия по OK).</summary>
        public TaskOptions Options { get; private set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!chkZeroRow.Checked && !chkEvenColumns.Checked)
            {
                MessageBox.Show(this, "Выберите хотя бы одну задачу.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Options = new TaskOptions
            {
                FindZeroRow = chkZeroRow.Checked,
                CountZerosInEvenColumns = chkEvenColumns.Checked,
                Numbering = rbFromOne.Checked ? Numbering.FromOne : Numbering.FromZero
            };
            DialogResult = DialogResult.OK;
        }
    }
}
