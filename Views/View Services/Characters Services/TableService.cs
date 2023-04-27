using Model;
using Presenter;
using Presenters;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Views
{
    public class TableService
    {
        public void SaveTableToHtml(DataView dataTable)
        {
            string htmlTable = TurnTableToHtmlTable(dataTable);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, htmlTable);
            }
        }

        public string TurnTableToHtmlTable(DataView dataTable, int colspan = 9)
        {
            string table = "";
            if (dataTable != null)
            {
                string[] headers = { "Name", "Age", "Language", "Seen At", "Birth", "Death", "Gender", "Is Alive" };

                string tdCSS = "td\r\n{\r\n    padding: 10px 4px;\r\n    background-color: rgb(84, 121, 146);\r\n}";
                string thCSS = "th\r\n{\r\n    background-color: rgb(103, 189, 103);    \r\n}";
                string tableCSS = "table\r\n{\r\n    border-style:solid;\r\n    width: 100%;\r\n}";



                DataTable newTable = dataTable.ToTable();

                newTable.Columns[0].ColumnMapping = MappingType.Hidden;
                colspan = 8;

                table += "<!DOCTYPE html><html><style>table, th, td {text-align: center; } .header{ background-color: rgb(236, 147, 12);}" + tdCSS + thCSS + tableCSS + "</style><body><table style = " + '"' + "width:100%" + '"' + ">\r\n";
                table += "<thead><tr><th colspan = " + '"' + $"{colspan}" + '"' + ">Characters</th></tr><tbody><tr>\r\n";

                for (int i = 0; i < headers.Length; i++)
                {
                    table += $"<td class=" + "header" + $">{headers[i]}</td>\r\n";
                }

                foreach (DataRow row in newTable.Rows)
                {
                    table += "<tr>";
                    foreach (DataColumn column in newTable.Columns)
                    {
                        if (column.ColumnMapping != MappingType.Hidden)
                        {
                            table += "<td>" + row[column.ColumnName].ToString() + "</td>\r\n";
                        }
                    }
                    table += "</tr>\r\n";
                }

                table += "</tbody></table></body></html>";
            }
            return table;
        }

        public void SaveTableToHtmlWithSelection(DataGridView dataGridView)
        {
            string htmlTable = TurnTableToHtmlTableWithSelection(dataGridView);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, htmlTable);
            }
        }

        public string TurnTableToHtmlTableWithSelection(DataGridView dataGridView, int colspan = 9)
        {
            string table = "";
            if (dataGridView != null)
            {
                string[] headers = { "Name", "Age", "Language", "Seen At", "Birth", "Death", "Gender", "Is Alive" };

                string tdCSS = "td\r\n{\r\n    padding: 10px 4px;\r\n    background-color: rgb(84, 121, 146);\r\n}";
                string thCSS = "th\r\n{\r\n    background-color: rgb(103, 189, 103);    \r\n}";
                string tableCSS = "table\r\n{\r\n    border-style:solid;\r\n    width: 100%;\r\n}";


                DataTable newTable = new DataTable();
                newTable.Columns.Add("Name", typeof(string));
                newTable.Columns.Add("Age", typeof(int));
                newTable.Columns.Add("Language", typeof(string));
                newTable.Columns.Add("Seen at", typeof(string));
                newTable.Columns.Add("Birthday", typeof(int));
                newTable.Columns.Add("Deathday", typeof(int));
                newTable.Columns.Add("Gender", typeof(string));
                newTable.Columns.Add("Is Alive?", typeof(string));


                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["DGV_Select"].Value) == true)
                    {
                        DataRow newRow = newTable.NewRow();
                        newRow["Name"] = row.Cells["Name"].Value;
                        newRow["Age"] = row.Cells["Age"].Value;
                        newRow["Language"] = row.Cells["Language"].Value;
                        newRow["Seen at"] = row.Cells["Seen at"].Value;
                        newRow["Birthday"] = row.Cells["Birthday"].Value;
                        newRow["Deathday"] = row.Cells["Deathday"].Value;
                        newRow["Gender"] = row.Cells["Gender"].Value;
                        newRow["Is Alive?"] = row.Cells["Is Alive?"].Value;

                        newTable.Rows.Add(newRow);
                    }
                }

                colspan = 8;

                table += "<!DOCTYPE html><html><style>table, th, td {text-align: center; } .header{ background-color: rgb(236, 147, 12);}"
                    + tdCSS + thCSS + tableCSS + "</style><body><table style = " + '"' + "width:100%" + '"' + ">\r\n";
                table += "<thead><tr><th colspan = " + '"' + $"{colspan}" + '"' + ">Characters</th></tr><tbody><tr>\r\n";

                for (int i = 0; i < headers.Length; i++)
                {
                    table += $"<td class=" + "header" + $">{headers[i]}</td>\r\n";
                }

                foreach (DataRow row in newTable.Rows)
                {
                    table += "<tr>";
                    foreach (DataColumn column in newTable.Columns)
                    {
                        if (column.ColumnMapping != MappingType.Hidden)
                        {
                            table += "<td>" + row[column.ColumnName].ToString() + "</td>\r\n";
                        }
                    }
                    table += "</tr>\r\n";
                }

                table += "</tbody></table></body></html>";
            }
            return table;
        }

        public void DrawLocationsTable(int opt, DataGridView dataGridView, LocationsManagerPresenter presenter)
        {
            DataGridViewButtonColumn removeLocation = new DataGridViewButtonColumn()
            {
                Name = "DGV_RemoveLocation",
                Text = "Delete",
                HeaderText = "Delete",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn viewLocation = new DataGridViewButtonColumn()
            {
                Name = "DGV_ViewLocation",
                Text = "View",
                HeaderText = "View",
                UseColumnTextForButtonValue = true
            };

            if (opt == 1)
            {
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                presenter.LocationsDataTable = null;
            }

            if (presenter.LocationsDataTable == null)
            {
                presenter.LocationsDataTable = new DataTable();
            }

            presenter.LocationsDataTable.Columns.Add("ID", typeof(int));
            presenter.LocationsDataTable.Columns.Add("Name", typeof(string));
            presenter.LocationsDataTable.Columns.Add("Description", typeof(string));
            presenter.LocationsDataTable.Columns.Add("Region", typeof(string));

            foreach (Location aLocation in presenter.Repository.Locations)
            {
                presenter.LocationsDataTable.Rows.Add(aLocation.Id, aLocation.LocationName,
                    aLocation.LocationDescription, aLocation.ContinentToString(presenter.Repository.Continents));
            }

            dataGridView.DataSource = presenter.LocationsDataTable;
            dataGridView.Columns.Add(removeLocation);
            dataGridView.Columns.Add(viewLocation);
            presenter.LocationsDataView = presenter.LocationsDataTable.DefaultView;
        }

        public void DrawContinentsTable(int opt, DataGridView dataGridView, LocationsManagerPresenter presenter)
        {
            DataGridViewButtonColumn removeContinent = new DataGridViewButtonColumn()
            {
                Name = "DGV_RemoveContinent",
                Text = "Delete",
                HeaderText = "Delete",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn viewContinent = new DataGridViewButtonColumn()
            {
                Name = "DGV_ViewContinent",
                Text = "View",
                HeaderText = "View",
                UseColumnTextForButtonValue = true
            };

            if (opt == 1)
            {
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                presenter.ContinentsDataTable = null;
            }

            if (presenter.ContinentsDataTable == null)
            {
                presenter.ContinentsDataTable = new DataTable();
            }

            presenter.ContinentsDataTable.Columns.Add("ID", typeof(int));
            presenter.ContinentsDataTable.Columns.Add("Name", typeof(string));
            presenter.ContinentsDataTable.Columns.Add("Description", typeof(string));

            foreach (Continent aContinent in presenter.Repository.Continents)
            {
                presenter.ContinentsDataTable.Rows.Add(aContinent.Id, aContinent.ContinentName,
                    aContinent.ContinentDescription);
            }

            dataGridView.DataSource = presenter.ContinentsDataTable;
            dataGridView.Columns.Add(removeContinent);
            dataGridView.Columns.Add(viewContinent);
            presenter.ContinentsDataView = presenter.ContinentsDataTable.DefaultView;
        }

        public void DrawCharsTable(int opt, DataGridView dataGridView, CharactersMainPresenter presenter)
        {
            DataGridViewButtonColumn removeChar = new DataGridViewButtonColumn()
            {
                Name = "DGV_RemoveChar",
                Text = "Delete",
                HeaderText = "Delete",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn viewChar = new DataGridViewButtonColumn()
            {
                Name = "DGV_ViewChar",
                Text = "View",
                HeaderText = "View",
                UseColumnTextForButtonValue = true

            };

            if (opt == 1)
            {
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                presenter.CharsDT = null;
            }

            if (presenter.CharsDT == null)
            {
                presenter.CharsDT = new DataTable();
            }

            presenter.CharsDT.Columns.Add("ID", typeof(int));
            presenter.CharsDT.Columns.Add("Name", typeof(string));
            presenter.CharsDT.Columns.Add("Age", typeof(int));
            presenter.CharsDT.Columns.Add("Language", typeof(string));
            presenter.CharsDT.Columns.Add("Seen at", typeof(string));
            presenter.CharsDT.Columns.Add("Birthday", typeof(int));
            presenter.CharsDT.Columns.Add("Deathday", typeof(int));
            presenter.CharsDT.Columns.Add("Gender", typeof(string));
            presenter.CharsDT.Columns.Add("Is Alive?", typeof(string));

            foreach (Character aCharacter in presenter.CharactersService.Characters)
            {
                presenter.CharsDT.Rows.Add(aCharacter.ID, aCharacter.Name, aCharacter.Age, aCharacter.Language,
                                            aCharacter.SeenAtStr(presenter.CharactersService.Locations), aCharacter.Birthday,
                                            aCharacter.Deathday, aCharacter.Gender, aCharacter.IsAliveStr());
            }

            dataGridView.DataSource = presenter.CharsDT;
            dataGridView.Columns.Add(removeChar);
            dataGridView.Columns.Add(viewChar);
            presenter.CharsDTDV = presenter.CharsDT.DefaultView;
        }

        public void SearchChars(SearchCriteriaEventArgs criteriaEventArgs, CharactersMainPresenter presenter, DataGridView dataGridView)
        {
            object value = criteriaEventArgs.Value;
            string criteria = criteriaEventArgs.Criteria;
            string query = "";

            if (criteria == "Age")
            {
                int value2;
                if (int.TryParse((string)value, out value2) == true)
                {
                    query = criteriaEventArgs.Criteria + " IN " + "(" + value2 + ", " + ((int)value2 * 10) + ", " + ((int)value2 * 100) + ", " + ((int)value2 * 1000) + " )";
                }
                else
                {
                    value = "";
                }
            }
            else
            {
                query = (criteriaEventArgs.Criteria + " LIKE '" + value + "%'");
            }

            if (value != "")
            {
                presenter.CharsDTDV.RowFilter = query;
                dataGridView.DataSource = presenter.CharsDTDV;
            }
            else
            {
                presenter.CharsDTDV.RowFilter = "";
            }
        }

        public void DrawSelectCharsTable(DataGridView dataGridView, DataTable dataTable)
        {
            DataGridViewCheckBoxColumn selectChar = new DataGridViewCheckBoxColumn()
            {
                Name = "DGV_Select",
                HeaderText = "Select",
            };

            dataGridView.DataSource = dataTable;
            dataGridView.Columns.Add(selectChar);
        }
    }
}
