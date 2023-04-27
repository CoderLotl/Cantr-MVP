using Data;
using Model;
using Presenters;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmContinentSheet : Form, IContinentSheet
    {
        ContinentSheetPresenter presenter;

        public FrmContinentSheet(DataAccess dataAccess, IRepository repository, int opt, Continent location)
        {
            InitializeComponent();
            presenter = new ContinentSheetPresenter(this, dataAccess, repository, opt, location);
        }

        public string LocationName { get => txtBox_Name.Text; set => txtBox_Name.Text = value; }
        public string Description { get => rchTxtBox_Description.Text; set => rchTxtBox_Description.Text = value; }
        public Button BtnAccept { get => btn_Accept; set => btn_Accept = value; }


        private void txtBox_Name_TextChanged(object sender, EventArgs e)
        {
            ContinentNameChanged.Invoke(sender, e);
        }
        private void rchTxtBox_Description_TextChanged(object sender, EventArgs e)
        {
            ContinentDescriptionChanged.Invoke(this, EventArgs.Empty);
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Accept.Invoke(this, EventArgs.Empty);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler Accept;
        public event EventHandler ContinentNameChanged;
        public event EventHandler ContinentDescriptionChanged;
    }
}
