using Data;
using Model;
using Presenters;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmLocationsManager : Form, ILocationsManager
    {
        LocationsManagerPresenter locationsManagerPresenter;
        IRepository _repository;
        DataAccess _dataAccess;

        public FrmLocationsManager(IRepository charactersRepository, DataAccess dataAccess)
        {
            InitializeComponent();
            _repository = charactersRepository;
            _dataAccess = dataAccess;
            locationsManagerPresenter = new LocationsManagerPresenter(this, _repository, _dataAccess);
            DrawLocationsTable.Invoke(this, EventArgs.Empty);
            DrawContinentsTable.Invoke(this, EventArgs.Empty);
        }
        public DataGridView Locations { get => this.dgv_Locations; set => this.dgv_Locations = value; }
        public DataGridView Continents { get => this.dgv_Continents; set => this.dgv_Continents = value; }
        public IRepository CharactersRepository { get => _repository; set => _repository = value; }

        private void btn_AddLocation_Click(object sender, EventArgs e)
        {
            this.tCtrl_General.SelectedTab = this.tCtrl_General.TabPages["tPg_Locations"];

            Location newLocation = new Location();

            FrmLocationSheet locationSheet = new FrmLocationSheet(_dataAccess, _repository, 1, newLocation);
            if (locationSheet.ShowDialog() == DialogResult.OK)
            {
                DrawLocationsTable.Invoke(this, EventArgs.Empty);
            }
        }

        private void btn_AddContinent_Click(object sender, EventArgs e)
        {
            this.tCtrl_General.SelectedTab = this.tCtrl_General.TabPages["tPg_Continents"];

            Continent newContinent = new Continent();
            FrmContinentSheet continentSheet = new FrmContinentSheet(_dataAccess, _repository, 1, newContinent);
            if (continentSheet.ShowDialog() == DialogResult.OK)
            {
                DrawContinentsTable.Invoke(this, EventArgs.Empty);
            }
        }

        private void dgv_Locations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Locations.Columns[e.ColumnIndex].Name == "DGV_RemoveLocation")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this location?", "Remove character", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    RemoveLocation.Invoke(this, dgv_Locations.CurrentRow.Index);
                    DrawLocationsTable.Invoke(this, EventArgs.Empty);
                }
            }

            if (dgv_Locations.Columns[e.ColumnIndex].Name == "DGV_ViewLocation")
            {
                FrmLocationSheet locationSheet = new FrmLocationSheet(_dataAccess, _repository, 0, _repository.Locations[dgv_Locations.CurrentRow.Index]);
                if (locationSheet.ShowDialog() == DialogResult.OK)
                {
                    DrawLocationsTable.Invoke(this, EventArgs.Empty);
                }
            }
        }
        private void dgv_Continents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Continents.Columns[e.ColumnIndex].Name == "DGV_RemoveContinent")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this continent?", "Remove character", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    RemoveContinent.Invoke(this, dgv_Continents.CurrentRow.Index);
                    DrawContinentsTable.Invoke(this, EventArgs.Empty);
                }
            }

            if (dgv_Continents.Columns[e.ColumnIndex].Name == "DGV_ViewContinent")
            {
                FrmContinentSheet continentSheet = new FrmContinentSheet(_dataAccess, _repository, 0, _repository.Continents[dgv_Continents.CurrentRow.Index]);
                if (continentSheet.ShowDialog() == DialogResult.OK)
                {
                    DrawContinentsTable.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void FrmLocationsManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public event EventHandler DrawLocationsTable;
        public event EventHandler DrawContinentsTable;
        public event EventHandler<int> RemoveLocation;
        public event EventHandler<int> RemoveContinent;
    }
}
