using Model;
using Presenter;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Views
{

    /// <summary>
    ///				!!! IMPORTANT !!!
    ///				
    /// THIS FORM WORKS WITH A FAKE CHAR, WHICH IS ACTUALLY A NEW CHARACTER THAT LIVES AND DIES HERE. IT ONLY SERVES THE MERE PURPOSE OF
    /// HAVING A DUMMY TO WORK ON, BEFORE ALL THE REAL CHANGES ARE PERFORMED ON THE REAL CHARACTER AND OTHER CHARACTERS RELATED TO IT.
    /// 
    /// MAY THE CHANGES NOT BE CONFIRMED AT THE END OF THIS FORM, NOTHING REALLY REACHES THE ORIGINAL CHARACTER. OTHERWISE ANY CHANGES
    /// ARE PASSED FROM THE FAKE CHAR TO THE ORIGINAL CHAR, AND FROM THE ORIGINAL TO THE OTHERS.
    /// </summary>
    public partial class FrmCharacterSheet : Form, ICharacterSheetView
    {
        //*************************************************

        Character characterEventArgs;
        string auxString;
        ProgressBarFiller progressBarFiller;

        int edited = 0;	// EDITED = 0: NO CHANGES WERE PERFORMED. EDITED = 1: CHANGES WERE PERFORMED BUT NOT CONFIRMED. EDITED = 2: CHANGES WERE EPRFORMED AND CONFIRMED.
        int option = 0;
        int initialized = 0;

        ImagePicker _imagePicker;

        readonly CharacterSheetPresenter _characterSheetPresenter;
        readonly IRepository _characterService;
        readonly IVariables _variables;
        //*************************************************

        public FrmCharacterSheet(Character character, int option, IRepository charactersService, IVariables variables)
        {
            InitializeComponent();

            _characterService = charactersService;
            _variables = variables;
            _characterSheetPresenter = new CharacterSheetPresenter(this, _characterService, _variables, character, option);
            _imagePicker = new ImagePicker();

            if (option == 0) // IF THE FORM IS ONLY TO VIEW A CHAR, I DISABLE THE EDIT.
            {
                DisableAll();
                grpBox_Edit.Visible = false;
                btn_Accept.Enabled = false;
                btn_Cancel.Enabled = false;
                btn_Undo.Enabled = false;
            }
            else if (option == 1) // IF FOR NEW CHAR
            {
                lbl_Characer.Text = "New Character Sheet";
                this.Text = "New Character Sheet";
                EnableAll();
            }
            else
            {
                EnableAll();
                this.Text = "Character Sheet";
            }

            this.option = option;
        }

        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public int Option
        {
            get { return option; }
            set { option = value; }
        }

        public Character CharacterEventArgs
        {
            get { return characterEventArgs; }
            set { characterEventArgs = value; }
        }

        public string AuxString
        {
            get { return auxString; }
            set { auxString = value; }
        }

        public ProgressBarFiller ProgressBarFiller
        {
            get { return progressBarFiller; }
            set { progressBarFiller = value; }
        }

        public Character PresenterCharacter
        {
            get { return _characterSheetPresenter.Character; }
        }

        //-----------------------------------------------------
        //------------------ [ BUTTONS ]
        //-----------------------------------------------------

        void Btn_CancelClick(object sender, EventArgs e) // IF CHANGES ARE REJECTED, THE FAKE CHAR IS FILLED AGAIN WITH THE ORIGINAL VALUES.
        {
            edited = 0;
            this.Close();
        }

        //--------------------------------------------

        private void Btn_Undo_Click(object sender, EventArgs e)
        {
            Undo.Invoke(this, EventArgs.Empty);

            LoadCharacter();

            if (option != 1)
            {
                edited = 0;
            }
        }

        //--------------------------------------------

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            AcceptChanges();
            this.Close();
        }

        private void AcceptChanges()
        {
            edited = 2;
            ConfirmEdit(_characterSheetPresenter.FakeCharacter); // IF THE CHANGES ARE ACCEPTED, THE NEW VALUES ARE SET ON THE FAKE CHAR.

            EditCharData.Invoke(this, _characterSheetPresenter.FakeCharacter);

            MessageBox.Show("Changes saved.");
        }

        //--------------------------------------------

        private void Btn_AddNewNode_Click(object sender, EventArgs e)
        {
            FrmNewFamilyNode frmNewFamilyNode = new FrmNewFamilyNode(_characterService, _variables, _characterSheetPresenter);
            if (frmNewFamilyNode.ShowDialog() == DialogResult.OK)
            {
                AddFamilyTie(this, frmNewFamilyNode.Presenter.EventArgs);

                TreeNode newNode = new TreeNode(); // I CREATE A NEW TREE NODE.

                newNode.Text = frmNewFamilyNode.Presenter.EventArgs.Character.ToString(); // SET THE NODE'S TEXT AS THE CHAR IT REPRESENTS
                newNode.Name = frmNewFamilyNode.Presenter.EventArgs.Character.ID.ToString(); // AND THE ID IS THE CHAR'S ID.

                foreach (TreeNode tvNode in tv_Family.Nodes[0].Nodes)
                {
                    if (tvNode.Text == frmNewFamilyNode.Presenter.EventArgs.Tie)
                    {
                        tvNode.Nodes.Add(newNode);
                        tvNode.ExpandAll();
                        break;
                    }
                }
                InitializedConditional();
            }
        }

        //--------------------------------------------

        private void btn_RmvFamilyTie_Click(object sender, EventArgs e)
        {
            try
            {
                if (tv_Family.SelectedNode.Level == 2) // SELECTED NODE
                {
                    // HERE I USED TO REMOVE NODES ON THE CHARS THOSE NODES POINTED TO DIRECTLY. THIS CHANGED WHEN I IMPLEMENTED THE POV OF USING A FAKE
                    // CHAR INSTEAD OF WORKING DIRECTLY WITH THE ORIGINAL ONE.

                    RemoveFamilyTie.Invoke(this, Convert.ToInt32(tv_Family.SelectedNode.Name));

                    tv_Family.SelectedNode.Remove(); // I FINALLY REMOVE THE NODE FROM THE TREEVIEW.					
                    InitializedConditional();
                }
            }
            catch
            {

            }
        }

        //--------------------------------------------

        /// <summary>
        /// THERE'S NOT MUCH TO SAY ABOUT THIS METHOD. IT OPENS A NEW CHARACTER SHEET IN VIEW-ONLY MODE TO VIEW THE CHAR THE NODE
        /// REPRESENTS.
        /// </summary>
        private void tv_Family_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (tv_Family.SelectedNode.Level == 2)
            {
                foreach (Character aCharacter in _characterService.Characters)
                {
                    if (aCharacter.ID == Convert.ToInt32(e.Node.Name))
                    {
                        FrmCharacterSheet viewThisChar = new FrmCharacterSheet(aCharacter, 0, _characterService, _variables);
                        viewThisChar.Show();
                        break;
                    }
                }
            }
        }

        //--------------------------------------------

        /// <summary>
        /// FORM LOAD. HERE I LOAD THE CHARACTER AND POPULATE ALL THE MAIN COMBOBOXES.
        /// FINALLY I DRAW THE BARS AND TREEVIEW.
        /// </summary>
        void FrmViewCharLoad(object sender, EventArgs e)
        {
            LoadCharacter();


            foreach (string gender in _variables.Genders)
            {
                cmbBox_Gender.Items.Add(gender);
            }
            cmbBox_Gender.Text = _characterSheetPresenter.Character.Gender;

            foreach (Location location in _characterService.Locations)
            {
                cmbBox_Location.Items.Add(location);
            }
            cmbBox_Location.Text = _characterSheetPresenter.Character.SeenAtStr(_characterService.Locations);

            foreach (string language in _characterService.Languages)
            {
                cmbBox_Language.Items.Add(language);
            }
            cmbBox_Language.Text = _characterSheetPresenter.Character.Language;


            cmbBox_IsAlive.Items.Add("Yes");
            cmbBox_IsAlive.Items.Add("No");
            cmbBox_IsAlive.Text = _characterSheetPresenter.Character.IsAliveStr();

            DrawTreeView();
            initialized = 1; // THIS IS IMPORTANT FOR THE CASE OF GOLEMS.			
        }

        //--------------------------------------------

        void FrmViewCharFormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseCheck();
        }

        //--------------------------------------------

        private void OnCloseCheck()
        {
            // EDITED = 0: NO CHANGES WERE PERFORMED.
            // EDITED = 1: CHANGES WERE PERFORMED BUT NOT CONFIRMED.
            // EDITED = 2: CHANGES WERE EPRFORMED AND CONFIRMED.

            if (edited == 1 || option == 1) // IF THE CHARACTER IS EITHER EDITED BUT NOT CONFIRMED OR THE CHARACTER IS NEW
            {
                string warningText = "";

                if (option == 1 && edited == 1) // IF THE CHARACTER IS NEW AND UNCONFIRMED
                {
                    warningText = "Do you want to apply the current changes?\n\n" +
                        "If you click 'NO' the character is going to be discarded.";

                }
                else if (edited == 1) // IF THE CHANGES ARE UNCONFIRMED
                {
                    warningText = "Do you want to apply the current changes?";

                }
                else if (option == 1 && edited == 2) // IN THE SPECIFIC CASE OF A NEW CHAR WITH CONFIRMED CHANGES
                {
                    this.DialogResult = DialogResult.OK;
                    return; // I ESCAPE THE METHOD
                }
                else if (edited == 0)
                {
                    this.DialogResult = DialogResult.Cancel;
                    return;
                }

                DialogResult warning = MessageBox.Show(warningText, "Warning", MessageBoxButtons.YesNo);

                if (warning == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    AcceptChanges();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else if (edited == 2) // IF CHANGES ARE CONFIRMED
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        //--------------------------------------------

        private void ConfirmEdit(Character characterEventArgs)
        {
            characterEventArgs.Name = txtBox_Name.Text;
            characterEventArgs.Age = Convert.ToInt32(nud_Age.Value);
            nud_Age.Visible = false;

            characterEventArgs.Gender = cmbBox_Gender.Text;
            characterEventArgs.Description = rchTxtBox_Description.Rtf;
            characterEventArgs.Birthday = int.Parse(txtBox_Birthday.Text);
            characterEventArgs.Deathday = int.Parse(txtBox_Deathday.Text);
            characterEventArgs.Language = cmbBox_Language.Text;

            foreach (Location location in _characterService.Locations)
            {
                if (location.LocationName == cmbBox_Location.Text)
                {
                    characterEventArgs.SeenAt = location.Id;
                    break;
                }
            }

            if (cmbBox_IsAlive.Text == "Yes")
            {
                characterEventArgs.IsAlive = true;
            }
            else
            {
                characterEventArgs.IsAlive = false;
            }
        }

        //-----------------------------------------------------
        //------------------ [ TEXT FORMAT ]
        //-----------------------------------------------------

        void Btn_BoldClick(object sender, EventArgs e)
        {
            BoldText();
        }

        //--------------------------------------------

        private void BoldText()
        {
            Font new1, old1;
            old1 = rchTxtBox_Description.SelectionFont;
            if (old1.Bold)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Bold);
            }

            rchTxtBox_Description.SelectionFont = new1;
            rchTxtBox_Description.Focus();
        }

        //--------------------------------------------

        void Btn_ItalicClick(object sender, EventArgs e)
        {
            ItalicText();
        }

        //--------------------------------------------

        private void ItalicText()
        {
            Font new1, old1;
            old1 = rchTxtBox_Description.SelectionFont;
            if (old1.Italic)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Italic);
            }

            rchTxtBox_Description.SelectionFont = new1;
            rchTxtBox_Description.Focus();
        }

        //--------------------------------------------

        void Btn_UnderlineClick(object sender, EventArgs e)
        {
            UnderlineText();
        }

        //--------------------------------------------

        private void UnderlineText()
        {
            Font new1, old1;
            old1 = rchTxtBox_Description.SelectionFont;
            if (old1.Underline)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Underline);
            }

            rchTxtBox_Description.SelectionFont = new1;
            rchTxtBox_Description.Focus();
        }

        //-----------------------------------------------------
        //------------------ [ METHODS ]
        //-----------------------------------------------------

        private void DrawTreeView()
        {
            tv_Family.Nodes.Add("Character: " + _characterSheetPresenter.Character.Name);

            foreach (RelationshipUnit relationshipUnit in _variables.Relations)
            {
                tv_Family.Nodes[0].Nodes.Add(relationshipUnit.TieName);
            }

            tv_Family.Nodes[0].ExpandAll();

            PopulateTree();
        }

        //--------------------------------------------
        private void PopulateTree()
        {
            // OK, I NEED TO DOCUMENT THIS 'CUZ I'M STARTING TO LOSE THE FOCUS.

            foreach (FamilyTieNode tieNode in _characterSheetPresenter.Character.Family) // I CHECK THE FAMILY OF THE CHAR...
            {
                foreach (Character aCharacter in _characterService.Characters) // ... AGAINST THE LIST OF CHARS...
                {
                    if (aCharacter.ID == tieNode.Id) // WHENEVER I FIND THE CHAR...
                    {
                        foreach (TreeNode node in tv_Family.Nodes[0].Nodes) // I CHECK THE NODES...
                        {
                            if (node.Text == tieNode.Tie) // ... AND WHEN I FIND THE CORRECT TYPE OF FAMILY TIE...
                            {
                                TreeNode newNode = new TreeNode();

                                newNode.Text = aCharacter.ToString();
                                newNode.Name = aCharacter.ID.ToString();

                                node.Nodes.Add(newNode); // ... I ADD THE CHAR TO IT.
                            }
                        }
                    }
                }
            }
            tv_Family.ExpandAll();
        }

        //--------------------------------------------

        private void LoadCharacter()
        {
            PictureSerializer pictureSerializer = new PictureSerializer();
            Bitmap charPicture = pictureSerializer.TurnStringToImage(_characterSheetPresenter.Character.CharPicture);

            if (charPicture != null)
            {
                pictureBox1.BackgroundImage = charPicture;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }

            txtBox_Name.Text = _characterSheetPresenter.Character.Name;
            rchTxtBox_Description.Rtf = _characterSheetPresenter.Character.Description;
            txtBox_Age.Text = _characterSheetPresenter.Character.Age.ToString();
            nud_Age.Value = _characterSheetPresenter.Character.Age;
            txtBox_Birthday.Text = _characterSheetPresenter.Character.Birthday.ToString();
            nud_Birthday.Value = _characterSheetPresenter.Character.Birthday;
            txtBox_Deathday.Text = _characterSheetPresenter.Character.Deathday.ToString();
            nud_Deathday.Value = _characterSheetPresenter.Character.Deathday;

            if (_characterSheetPresenter.Character.Gender != null)
            {
                cmbBox_Gender.Text = _characterSheetPresenter.Character.Gender.ToString();
            }
            else
            {
                cmbBox_Gender.Text = "";
            }
        }

        //--------------------------------------------

        private void DisableAll()
        {
            nud_Age.Visible = false;

            txtBox_Name.Enabled = false;
            rchTxtBox_Description.Enabled = false;
            cmbBox_Gender.Enabled = false;
            cmbBox_IsAlive.Enabled = false;
            cmbBox_Language.Enabled = false;
            cmbBox_Location.Enabled = false;

            //---------- BUTTONS
            btn_Bold.Enabled = false;
            btn_Italic.Enabled = false;
            btn_Underline.Enabled = false;
            btn_LoadPicture.Enabled = false;
            btn_DiscardPicture.Enabled = false;

            btn_AddNewNode.Enabled = false;
            btn_RmvFamilyTie.Enabled = false;

            //---------- NUDS
            nud_Age.Enabled = false;
            nud_Birthday.Enabled = false;
            nud_Deathday.Enabled = false;
        }

        //--------------------------------------------

        private void EnableAll()
        {
            txtBox_Name.Enabled = true;
            nud_Age.Enabled = true; nud_Age.Visible = true;
            nud_Birthday.Enabled = true; nud_Birthday.Visible = true;
            nud_Deathday.Enabled = true; nud_Deathday.Visible = true;

            cmbBox_Gender.Enabled = true;
            cmbBox_Location.Enabled = true;
            cmbBox_Language.Enabled = true;
            rchTxtBox_Description.Enabled = true;
            cmbBox_IsAlive.Enabled = true;
            btn_Bold.Enabled = true;
            btn_Italic.Enabled = true;
            btn_Underline.Enabled = true;
            btn_AddNewNode.Enabled = true;
            btn_RmvFamilyTie.Enabled = true;
        }

        //-----------------------------------------------------
        //------------------ [ NUDS ]
        //-----------------------------------------------------

        private void nud_Age_ValueChanged(object sender, EventArgs e)
        {
            InitializedConditional();
            txtBox_Age.Text = nud_Age.Value.ToString();
        }
        //--------------------------------------------
        private void tv_Family_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                toolTip1.Show("Double-click the node to see the char!", this, PointToClient(MousePosition), 3000);
            }
        }

        //--------------------------------------------

        //-----------------------------------------------------
        //------------------ [ EVENTS ]
        //-----------------------------------------------------

        private void cmbBox_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializedConditional();
            _imagePicker.ImagePickerMain("Gender", cmbBox_Gender.Text, picBox_Gender);
        }

        private void txtBox_Name_TextChanged(object sender, EventArgs e)
        {
            if (initialized == 1)
            {
                edited = 1;
            }
        }

        private void InitializedConditional()
        {
            if (initialized == 1)
            {
                edited = 1;
            }
        }

        private void rchTxtBox_Description_TextChanged(object sender, EventArgs e)
        {
            InitializedConditional();
        }
        void CmbBox_IsAliveSelectedIndexChanged(object sender, EventArgs e)
        {
            InitializedConditional();
        }


        private void btn_LoadPictore_Click(object sender, EventArgs e)
        {
            PictureSerializer pictureSerializer = new PictureSerializer();
            _characterSheetPresenter.FakeCharacter.CharPicture = pictureSerializer.UploadImageAsString();

            Bitmap newImage = pictureSerializer.TurnStringToImage(_characterSheetPresenter.FakeCharacter.CharPicture);

            if (newImage != null)
            {
                pictureBox1.BackgroundImage = newImage;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }
        }

        private void btn_DiscardPicture_Click(object sender, EventArgs e)
        {
            _characterSheetPresenter.FakeCharacter.CharPicture = "";

            pictureBox1.BackgroundImage = null;
        }

        void FrmViewCharKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.B)
            {
                BoldText();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
            {
                ItalicText(); // THIS PARTICULAR ONE DOESN'T SEEM TO WORK WELL ...
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                UnderlineText();
            }
        }

        public event EventHandler Undo;
        public event EventHandler<Character> EditCharData;
        public event EventHandler<FamilyTieNodeEventArgs> AddFamilyTie;
        public event EventHandler<int> RemoveFamilyTie;
        public event EventHandler<ComboBox> PopulateFamilyCombobox;

        private void nud_Birthday_ValueChanged(object sender, EventArgs e)
        {
            InitializedConditional();
            txtBox_Birthday.Text = nud_Birthday.Value.ToString();
        }

        private void nud_Deathday_ValueChanged(object sender, EventArgs e)
        {
            InitializedConditional();
            txtBox_Deathday.Text = nud_Deathday.Value.ToString();
        }
    }
}