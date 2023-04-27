using Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Model
{
    public class Repository : IRepository
    {
        List<Character> characters;
        List<Location> locations;
        List<Continent> continents;
        List<string> languages;
        int id;
        DataAccess dataAccess;

        public Repository()
        {
            this.characters = new List<Character>();
            this.locations = new List<Location>();
            this.continents = new List<Continent>();
            this.languages = new List<string>();
            this.id = 0;
        }

        public List<Character> Characters
        {
            get { return characters; }
            set { characters = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public List<Location> Locations
        {
            get { return locations; }
            set { locations = value; }
        }
        public List<Location> Locations1
        {
            get { return locations; }
            set { locations = value; }
        }
        public List<string> Languages
        {
            get { return languages; }
            set { languages = value; }
        }
        public DataAccess DataAccess
        {
            get { return dataAccess; }
            set { dataAccess = value; }
        }

        public List<Continent> Continents { get => continents; set => continents = value; }

        public bool LoadData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DB Files( *.db)| *.db";
            bool open = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.CheckPathExists == true && openFileDialog.CheckFileExists == true)
            {
                this.dataAccess = new DataAccess(openFileDialog.FileName);

                characters = dataAccess.RetrieveCharacters();
                languages = dataAccess.RetrieveLanguages();
                continents = dataAccess.RetrieveContinents();
                locations = dataAccess.RetrieveLocations();
                if (Characters.Count > 0)
                {
                    ID = Characters[Characters.Count - 1].ID;
                }
                else
                {
                    ID = 0;
                }
                open = true;
            }
            return open;
        }

        public void Add(Character entity)
        {
            Characters.Add(entity);

            dataAccess.InsertCharacters(entity);

            ID++;
        }

        public void RemoveChar(int index)
        {
            CharactersService charactersService = new CharactersService(this.dataAccess);
            charactersService.SyncCharsAtRemoval(Characters[index], Characters);

            dataAccess.DeleteCharacter(Characters[index].ID);

            Characters.RemoveAt(index);
        }

        public void RemoveLocation(int index)
        {
            LocationsService locationsService = new LocationsService();
            locationsService.SyncLocations(Locations[index], Characters);

            dataAccess.DeleteLocation(Locations[index]);

            Locations.RemoveAt(index);
        }

        public void RemoveContinent(int index)
        {
            LocationsService locationsService = new LocationsService();
            locationsService.SyncContinents(Continents[index], Locations);

            dataAccess.DeleteContinent(continents[index]);

            Continents.RemoveAt(index);
        }
    }
}
