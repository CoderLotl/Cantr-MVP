using Model;
using System.Windows.Forms;

namespace Views
{
    public class RelationshipsComboboxPopulator
    {
        public void PopulateRelationshipsCmbBox(ComboBox comboBox, IVariables variables)
        {
            comboBox.Items.Clear();
            foreach (RelationshipUnit relationshipUnit in variables.Relations)
            {
                comboBox.Items.Add(relationshipUnit.TieName);
            }
        }
    }
}
