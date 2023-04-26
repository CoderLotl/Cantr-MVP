using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository
    {
        List<Character> Characters { get; set;  }
        List<string> Languages { get; set; }
        List<Location> Locations { get; set; }
        List<Continent> Continents { get; set; }
        DataAccess DataAccess { get; set; }
        int ID { get; set; }

        bool LoadData();
        void RemoveChar(int index);
        void Add(Character entity);
        void RemoveLocation(int index);
        void RemoveContinent(int index);
    }
}
