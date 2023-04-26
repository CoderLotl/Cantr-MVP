using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public interface ILocationsManager
    {
        DataGridView Locations { get; set; }
        DataGridView Continents { get; set; }

        event EventHandler DrawLocationsTable;
        event EventHandler DrawContinentsTable;
        event EventHandler<int> RemoveLocation;
        event EventHandler<int> RemoveContinent;
    }
}
