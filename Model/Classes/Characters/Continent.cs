using System.Collections.Generic;

namespace Model
{
    public class Continent
    {
        int id;
        string continentName;
        string continentDescription;

        public Continent()
        {

        }

        public Continent(int id, string continentName, string continentDescription)
        {
            this.id = id;
            this.continentName = continentName;
            this.continentDescription = continentDescription;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ContinentName
        {
            get { return continentName; }
            set { continentName = value; }
        }
        public string ContinentDescription
        {
            get { return continentDescription; }
            set { continentDescription = value; }
        }

        public static int ContinentID(List<Continent> continents, string continentName)
        {
            int continentID = 0;

            foreach (Continent continent in continents)
            {
                if (continent.ContinentName == continentName)
                {
                    continentID = continent.Id;
                    break;
                }
            }

            return continentID;
        }
    }
}
