using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    internal partial class ScrewingToolMovementForm : Form
    {
        private ScrewingTool tool = new ScrewingTool();

        public ScrewingToolMovementForm(ScrewingTool screwingTool)
        {
            InitializeComponent();
            tool = screwingTool;
            lTool.Text += $"Номер: {tool.id} | Вид: {tool.type} | Модель: {tool.model}";
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            dgMovements.DataSource = new BindingList<ScrewingToolMovement>(ScrewingToolMovement.screwingToolMovements);
            dgMovements.Columns[0].HeaderText = "Дата изменения";
            dgMovements.Columns[1].HeaderText = "Статус";
            dgMovements.Columns[1].Width = 150;
            dgMovements.Columns[2].HeaderText = "Гамма";
            dgMovements.Columns[2].Width = 70;
            dgMovements.Columns[3].HeaderText = "Пост";
            dgMovements.Columns[3].Width = 70;
            dgMovements.Columns[4].HeaderText = "Момент";
            dgMovements.Columns[4].Width = 70;
            dgMovements.Columns[5].HeaderText = "Изменил";

            for (int i = 0; i < dgMovements.Columns.Count; i++)
            {                
                dgMovements.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgMovements.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgMovements.Columns[5].Width = dgMovements.Width - SystemInformation.VerticalScrollBarWidth -
                dgMovements.Columns[0].Width - dgMovements.Columns[1].Width - dgMovements.Columns[2].Width - dgMovements.Columns[3].Width
                - dgMovements.Columns[4].Width - 3;            
            lCount.Text = $"Найдено изменений: {dgMovements.Rows.Count} шт.";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
