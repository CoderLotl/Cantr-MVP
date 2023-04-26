using Dapper;
using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Net.Mime.MediaTypeNames;

namespace Model
{
    public class DataBaseService
    {
        public DataBaseService() { }

        public void GenerateDataBase()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DB files (*.db)|*.db";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;                
                var file = File.Create(filename);
                file.Close();
                CreateTables(filename);
            }
        }

        private void CreateTables(string path)
        {
            DapperContext dapperContext = new DapperContext(path);

            using(var connection = dapperContext.GetConnection())
            {
                string createTable = "CREATE TABLE";
                string query = createTable + " characters(id INT, name TEXT, age INT, isAlive INT, description TEXT, gender TEXT, charPicture TEXT, birthday INT, deathday INT, seenAt INT, language TEXT); ";
                query += createTable + " continents(id INT, continentName TEXT, continentDescription TEXT); ";
                query += createTable + " languages(languages TEXT);";
                query += createTable + " locations(id INTEGER, locationName TEXT, locationDescription TEXT, locationRegion TEXT); ";                
                query += createTable + " ties(id INTEGER NOT NULL, charId INTEGER NOT NULL, relatedTieId INTEGER NOT NULL, tieName TEXT NOT NULL);";

                connection.Execute(query);
            }            
        }
    }
}
