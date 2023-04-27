using Model;
using System;
using System.Windows.Forms;

namespace Views
{

    public interface ICharactersMain
    {
        string Lbl_Characters { set; }
        string Text { set; get; }
        DataGridView DataGridView { set; get; }

        void DisableAll();
        void EnableAll();

        event EventHandler AddCharacter;
        event EventHandler<int> RemoveCharacter;
        event EventHandler LoadFile;
        event EventHandler Clear;
        event EventHandler UpdateAmountOfCharacters;
        event EventHandler<Action<string>> CalculateCharsAge;
        event EventHandler SaveTableToHtmlFile;
        event EventHandler SaveTableToHtmlFileWithSelection;
        event EventHandler CreateDB;
        event EventHandler ViewMap;
        event EventHandler<int> DrawTable;
        event EventHandler<SearchCriteriaEventArgs> SearchCriteria;
    }
}
