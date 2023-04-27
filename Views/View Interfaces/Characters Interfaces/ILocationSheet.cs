using System;
using System.Windows.Forms;

namespace Views
{
    public interface ILocationSheet
    {
        string LocationName { get; set; }
        ComboBox Continent { get; set; }
        string Description { get; set; }
        Button BtnAccept { get; set; }

        event EventHandler Accept;
        event EventHandler Load;
        event EventHandler LocationNameChanged;
        event EventHandler LocationDescriptionChanged;
        event EventHandler LocationContinentChanged;
    }
}
