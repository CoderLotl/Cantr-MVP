using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Model;
using Presenter;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace Views
{
	public partial class FrmCharactersMain : Form, ICharactersMain
    {

        //*************************************************

		readonly CharactersMainPresenter _charPresenter;
        readonly IRepository _charactersService;
        readonly IVariables _variables;
        SearchCriteriaEventArgs criteriaEventArgs;

        //*************************************************

        public FrmCharactersMain(IRepository charactersService, IVariables variables)
        {
            InitializeComponent();
            _charactersService = charactersService;
            _variables = variables;
            criteriaEventArgs = new SearchCriteriaEventArgs();

            _charPresenter = new CharactersMainPresenter(this, charactersService);            
            LoadFile.Invoke(this, EventArgs.Empty);
            DrawTable.Invoke(this, 0);
            UpdateInfo();
        }

        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public string Lbl_Characters
		{
			set { lbl_CharactersCount.Text = value; }
		}
		
		public string Lbl_MaroDate
		{			
			set { lbl_MaroDate.Text = value; }
		}

        public DataGridView DataGridView
        {
        	get { return this.dataGridView1; }
        	set { dataGridView1 = value; }
        }
        
        //-----------------------------------------------------
        //------------------ [ BUTTONS ]
        //-----------------------------------------------------
        
        private void btn_AddCharacter_Click(object sender, EventArgs e)
        {
            FrmCharacterSheet frmCharacterSheet = new FrmCharacterSheet(null, 1, _charactersService, _variables);
            if(frmCharacterSheet.ShowDialog() == DialogResult.OK)
            {
                DrawTable.Invoke(this, 1);
                UpdateInfo();
            }
        }

        //------------------

        private void btn_ManageLocations_Click(object sender, EventArgs e)
        {
            FrmLocationsManager locationsManager = new FrmLocationsManager(_charactersService, _charactersService.DataAccess);
            if(locationsManager.ShowDialog() == DialogResult.OK)
            {
                DrawTable.Invoke(this, 1);
            }
        }

        //------------------

        void Btn_ClearListClick(object sender, EventArgs e)
		{			
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the list of characters?\n\n" +
			                                            "All characters are gonna be erased and this cannot be undone.", "Clear Characters List", MessageBoxButtons.YesNo);
			
			if(dialogResult == DialogResult.Yes)
			{
				Clear.Invoke(this, EventArgs.Empty);
				DrawTable.Invoke(this, 1);
				UpdateInfo();
            }
		}
		
		//------------------
		
		void Btn_LoadClick(object sender, EventArgs e)
		{
            LoadFile.Invoke(this, EventArgs.Empty);
            DrawTable.Invoke(this, 1);
            UpdateInfo();
        }


        private void btn_SaveToHtmlSpecial_Click(object sender, EventArgs e)
        {
            SaveTableToHtmlFileWithSelection.Invoke(this, EventArgs.Empty);
        }

        private void btn_SaveToHtml_Click(object sender, EventArgs e)
        {
            SaveTableToHtmlFile.Invoke(this, EventArgs.Empty);
        }

        private void btn_NewDB_Click(object sender, EventArgs e)
        {
            CreateDB.Invoke(this, EventArgs.Empty);
        }

        private void btn_ViewMap_Click(object sender, EventArgs e)
        {
            ViewMap.Invoke(this, EventArgs.Empty);
        }

        void Btn_CalcAgeAllClick(object sender, EventArgs e)
        {
            Action<string> message = (string text) => MessageBox.Show(text);
            //DELEGATE. USED TO PASS A LAMBDA METHOD.
            CalculateCharsAge(this, message);
            DrawTable.Invoke(this, 1);
        }

        //-----------------------------------------------------
        //------------------ [ EVENTS ]
        //-----------------------------------------------------

        //------------------

        private void FrmCharactersMain_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }
		
		//------------------
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGV_RemoveChar")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this character?","Remove character",MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    RemoveCharacter.Invoke(this, dataGridView1.CurrentRow.Index);

                    DrawTable.Invoke(this, 1);
                    UpdateInfo();
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGV_ViewChar")
            {
                FrmCharacterSheet viewChar = new FrmCharacterSheet(_charactersService.Characters[dataGridView1.CurrentRow.Index], 2, _charactersService, _variables);
                if (viewChar.ShowDialog() == DialogResult.OK)
                {
                    _charactersService.Characters[dataGridView1.CurrentRow.Index] = viewChar.PresenterCharacter;
                    DrawTable.Invoke(this, 1);
                }
                else
                {
                    DrawTable.Invoke(this, 1);
                }
            }
        }

        public void DisableAll()
        {
            btn_AddCharacter.Enabled = false;
            btn_CalcAgeAll.Enabled = false;
            btn_ClearList.Enabled = false;
            btn_ManageLocations.Enabled = false;
            btn_SaveToHtmlSpecial.Enabled = false;            
        }

        public void EnableAll()
        {
            btn_AddCharacter.Enabled = true;
            btn_CalcAgeAll.Enabled = true;
            btn_ClearList.Enabled = true;
            btn_ManageLocations.Enabled = true;
            btn_SaveToHtmlSpecial.Enabled = true;
        }
		
		//------------------
        
        private void UpdateInfo()
        {
            UpdateAmountOfCharacters.Invoke(this, EventArgs.Empty);

            if (_charactersService.Characters.Count > 0)
            {                
                btn_ClearList.Enabled = true;                                
                btn_CalcAgeAll.Enabled = true;
            }
            else
            {                
                btn_ClearList.Enabled = false;                
                btn_CalcAgeAll.Enabled = false;
            }
        }

        private void FrmCharactersMain_KeyDown(object sender, KeyEventArgs e)
        {
        	if (e.KeyCode == Keys.Escape)
        	{
        		this.Close();
        	}
        }
                
		public event EventHandler AddCharacter;
        public event EventHandler<int> RemoveCharacter;
        public event EventHandler LoadFile;		
		public event EventHandler Clear;
        public event EventHandler UpdateAmountOfCharacters;
        public event EventHandler<Action<string>> CalculateCharsAge;
        public event EventHandler SaveTableToHtmlFile;
        public event EventHandler SaveTableToHtmlFileWithSelection;
        public event EventHandler CreateDB;
        public event EventHandler ViewMap;
        public event EventHandler<int> DrawTable;
        public event EventHandler<SearchCriteriaEventArgs> SearchCriteria;

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (rdb_Name.Checked == true)
            {
                criteriaEventArgs.Criteria = "Name";
                criteriaEventArgs.Value = txtBox_Search.Text;
            }
            else if (rdb_Age.Checked == true)
            {
                criteriaEventArgs.Criteria = "Age";
                criteriaEventArgs.Value = txtBox_Search.Text;
            }
            else if(rdb_Language.Checked == true)
            {
                criteriaEventArgs.Criteria = "Language";
                criteriaEventArgs.Value = txtBox_Search.Text;
            }
            else
            {
                criteriaEventArgs.Criteria = "Gender";
                criteriaEventArgs.Value = txtBox_Search.Text;
            }

            SearchCriteria.Invoke(this, criteriaEventArgs);
        }
    }
}
