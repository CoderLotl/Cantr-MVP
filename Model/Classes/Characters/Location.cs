using System.Collections.Generic;

namespace Model
{
    public class Location
    {
        int id;
        string locationName;
        string locationDescription;
        int continentID;

        public Location() { }

        public Location(int id, string locationName, string locationDescription, int continentID)
        {
            this.id = id;
            this.locationName = locationName;
            this.locationDescription = locationDescription;
            this.continentID = continentID;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }
        public string LocationDescription
        {
            get { return locationDescription; }
            set { locationDescription = value; }
        }
        public int ContinentID
        {
            get { return continentID; }
            set { continentID = value; }
        }

        public override string ToString()
        {
            return this.locationName;
        }

        public string ContinentToString(List<Continent> continents)
        {
            string continentStr = "";
            bool found = false;

            foreach (Continent continent in continents)
            {
                if (continent.Id == this.continentID)
                {
                    continentStr = continent.ContinentName;
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                continentStr = "NOT SET";
            }

            return continentStr;
        }

        public static int MaxId(List<Location> locations)
        {
            int maxId = 0;

            foreach (Location location in locations)
            {
                if (location.id > maxId)
                {
                    maxId = location.id;
                }
            }

            return maxId;
        }
    }
}
