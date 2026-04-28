using Process_Engineering.DTO;
using Process_Engineering.Objects;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    internal partial class CardDescriptionForm : Form
    {
        private CardMainInfo card = new CardMainInfo();

        public CardDescriptionForm(CardMainInfo card)
        {
            InitializeComponent();
            this.card = card;
            lCard.Text += $"№ {card.number}";
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            dgDescriptions.DataSource = new BindingList<CardDescription>(CardDescription.cardDescriptions);
            dgDescriptions.Columns[0].HeaderText = "Версия";
            dgDescriptions.Columns[1].HeaderText = "Дата создания";
            dgDescriptions.Columns[2].HeaderText = "Описанмие изменения";
            dgDescriptions.Columns[3].HeaderText = "Автор";
            dgDescriptions.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDescriptions.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgDescriptions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDescriptions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDescriptions.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDescriptions.Columns[2].Width = dgDescriptions.Width - SystemInformation.VerticalScrollBarWidth -
                dgDescriptions.Columns[0].Width - dgDescriptions.Columns[1].Width - dgDescriptions.Columns[3].Width - 3;            
            lCount.Text = $"Всего изменений: {dgDescriptions.Rows.Count} шт.";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
