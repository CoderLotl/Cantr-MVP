using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
