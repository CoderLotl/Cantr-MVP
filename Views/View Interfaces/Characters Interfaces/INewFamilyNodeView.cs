using System;
using System.Windows.Forms;

namespace Views
{
    public interface INewFamilyNodeView
    {
        event EventHandler<Control> PopulateCharactersComboBox;
        event EventHandler<Control> PopulateRelationshipsComboBox;
    }
}
