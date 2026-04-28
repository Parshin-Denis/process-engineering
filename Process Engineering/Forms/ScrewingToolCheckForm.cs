using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    internal partial class ScrewingToolCheckForm : Form
    {
        private ScrewingTool tool = new ScrewingTool();

        public ScrewingToolCheckForm(ScrewingTool screwingTool)
        {
            InitializeComponent();
            tool = screwingTool;
            lTool.Text += $"Номер: {tool.id} | Вид: {tool.type} | Модель: {tool.model}";
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            dgTools.DataSource = new BindingList<ToolCheck>(ToolCheck.toolChecks);
            DataGridViewColumn resultColumn = dgTools.Columns[0];
            dgTools.Columns.RemoveAt(0);
            dgTools.Columns.Add(resultColumn);
            dgTools.Columns[0].Visible = false;
            dgTools.Columns[1].HeaderText = "Дата проверки";
            dgTools.Columns[2].HeaderText = "Момент номинал";
            dgTools.Columns[3].HeaderText = "Момент 1-й";
            dgTools.Columns[4].HeaderText = "Момент 2-й";
            dgTools.Columns[5].HeaderText = "Момент 3-й";
            dgTools.Columns[6].HeaderText = "Разброс момента";
            dgTools.Columns[7].HeaderText = "Средний момент";
            dgTools.Columns[8].HeaderText = "Средний угол";
            dgTools.Columns[9].HeaderText = "Время торможения";
            dgTools.Columns[10].HeaderText = "Угол торможения";
            dgTools.Columns[11].Visible = false;
            dgTools.Columns[12].HeaderText = "Номер датчика";

            for (int i = 2; i < dgTools.Columns.Count; i++)
            {
                dgTools.Columns[i].Width = 65;
                dgTools.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            for (int i = 0; i < dgTools.Rows.Count; i++)
            {
                dgTools.Rows[i].Cells[13].Value = ToolCheck.toolChecks[i].codeResult == 128 ? "OK" : "NOK";
            }
            //dgTools.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgTools.Columns[2].Width = dgTools.Width - SystemInformation.VerticalScrollBarWidth -
            //    dgTools.Columns[0].Width - dgTools.Columns[1].Width - 3;
            dgTools.ReadOnly = true;
            lCount.Text = $"Найдено проверок: {dgTools.Rows.Count} шт.";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
