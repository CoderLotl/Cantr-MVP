using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public interface IContinentSheet
    {
        string LocationName { get; set; }        
        string Description { get; set; }
        Button BtnAccept { get; set; }

        event EventHandler Accept;        
        event EventHandler ContinentNameChanged;
        event EventHandler ContinentDescriptionChanged;        
    }
}
