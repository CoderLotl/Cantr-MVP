using System;
using System.Data;
using System.Windows.Forms;
using Views;

namespace Maro_MVP.Views.Forms.Characters_Forms
{
    public partial class FrmCharactersDataGridSelector : Form
    {

        TableService _tableService;

        public FrmCharactersDataGridSelector(DataTable dataTable)
        {
            InitializeComponent();
            _tableService = new TableService();
            _tableService.DrawSelectCharsTable(this.dataGridView1, dataTable);
        }

        private void btn_SaveToHtml_Click(object sender, EventArgs e)
        {
            _tableService.SaveTableToHtmlWithSelection(this.dataGridView1);
            this.Close();
        }
    }
}
