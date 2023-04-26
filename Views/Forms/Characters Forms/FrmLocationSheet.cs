using Data;
using Model;
using Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmLocationSheet : Form, ILocationSheet
    {
        LocationSheetPresenter presenter;        
        
        public FrmLocationSheet(DataAccess dataAccess, IRepository repository, int opt, Location location)
        {
            InitializeComponent();
            presenter = new LocationSheetPresenter(this, dataAccess, repository, opt, location);            
            Load.Invoke(this, EventArgs.Empty);
        }

        public string LocationName { get => txtBox_Name.Text ; set => txtBox_Name.Text = value; }
        public ComboBox Continent { get => CmbBox_Continent; set => CmbBox_Continent = value; }
        public string Description { get => rchTxtBox_Description.Text; set => rchTxtBox_Description.Text = value; }
        public Button BtnAccept {   get => btn_Accept; set => btn_Accept= value; }

        private void txtBox_Name_TextChanged(object sender, EventArgs e)
        {
            LocationNameChanged.Invoke(sender, e);
        }

        private void CmbBox_Continent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationContinentChanged.Invoke(this, EventArgs.Empty);
        }

        private void rchTxtBox_Description_TextChanged(object sender, EventArgs e)
        {
            LocationDescriptionChanged.Invoke(this, EventArgs.Empty);
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

        public event EventHandler Load;
        public event EventHandler LocationNameChanged;
        public event EventHandler Accept;
        public event EventHandler LocationDescriptionChanged;
        public event EventHandler LocationContinentChanged;
    }
}
