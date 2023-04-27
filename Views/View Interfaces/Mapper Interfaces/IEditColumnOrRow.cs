using System;
using System.Windows.Forms;

namespace Views
{
    public interface IEditColumnOrRow
    {
        ComboBox ComboBox1 { get; set; }
        Label Label1 { get; set; }
        GroupBox GroupBox2 { get; set; }
        DialogResult DialogResult { get; set; }

        event EventHandler Accept;
    }
}
