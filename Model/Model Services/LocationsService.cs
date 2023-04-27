using System.Collections.Generic;

namespace Model
{
    public class LocationsService
    {
        public LocationsService() { }

        public void SyncLocations(Location location, List<Character> characters)
        {
            foreach (Character character in characters)
            {
                if (character.SeenAt == location.Id)
                {
                    character.SeenAt = 0;
                }
            }
        }

        public void SyncContinents(Continent continent, List<Location> locations)
        {
            foreach (Location location in locations)
            {
                if (location.ContinentID == continent.Id)
                {
                    location.ContinentID = 0;
                }
            }
        }
    }
}
