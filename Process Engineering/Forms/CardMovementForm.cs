using Process_Engineering.DTO;
using Process_Engineering.Objects;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    internal partial class CardMovementForm : Form
    {
        private CardMainInfo card = new CardMainInfo();

        public CardMovementForm(CardMainInfo card)
        {
            InitializeComponent();
            this.card = card;
            lCard.Text += card.number;
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            dgMovements.DataSource = new BindingList<CardMovement>(CardMovement.cardMovements);
            dgMovements.Columns[0].HeaderText = "Дата переноса";
            dgMovements.Columns[1].HeaderText = "Пост";
            dgMovements.Columns[2].HeaderText = "Переместил";
            dgMovements.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgMovements.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgMovements.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgMovements.Columns[2].Width = dgMovements.Width - SystemInformation.VerticalScrollBarWidth -
                dgMovements.Columns[0].Width - dgMovements.Columns[1].Width - 3;            
            lCount.Text = $"Всего перемещений: {dgMovements.Rows.Count} шт.";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
