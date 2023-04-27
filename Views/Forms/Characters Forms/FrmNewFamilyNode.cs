using Model;
using Presenter;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmNewFamilyNode : Form, INewFamilyNodeView
    {
        //*************************************************

        readonly NewFamilyNodePresenter newFamilyNodePresenter;

        //*************************************************

        public NewFamilyNodePresenter Presenter
        {
            get { return newFamilyNodePresenter; }
        }

        public FrmNewFamilyNode(IRepository charactersService, IVariables variables, CharacterSheetPresenter characterSheetPresenter)
        {
            InitializeComponent();
            newFamilyNodePresenter = new NewFamilyNodePresenter(this, charactersService, variables, characterSheetPresenter);

            PopulateCharactersComboBox.Invoke(this, comboBox1);
            PopulateRelationshipsComboBox.Invoke(this, comboBox2);
        }

        //-----------------------------------------------------
        //------------------ [ BUTTONS ]
        //-----------------------------------------------------

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                newFamilyNodePresenter.EventArgs.Character = (Character)comboBox1.SelectedItem;
                newFamilyNodePresenter.EventArgs.Tie = comboBox2.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        //-----------------------------------------------------
        //------------------ [ EVENTS ]
        //-----------------------------------------------------

        public event EventHandler<Control> PopulateRelationshipsComboBox;
        public event EventHandler<Control> PopulateCharactersComboBox;

    }
}
