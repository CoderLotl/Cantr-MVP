using Model;
using System;
using System.Windows.Forms;

namespace Views
{
    public interface ICharacterSheetView
    {
        int Option { get; set; }
        Character CharacterEventArgs { get; set; }
        string AuxString { get; set; }

        ProgressBarFiller ProgressBarFiller { get; set; }

        event EventHandler Undo;
        event EventHandler<Character> EditCharData;
        event EventHandler<FamilyTieNodeEventArgs> AddFamilyTie;
        event EventHandler<int> RemoveFamilyTie;
        event EventHandler<ComboBox> PopulateFamilyCombobox;
    }
}
