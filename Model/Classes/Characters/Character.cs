using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Drawing;
using Newtonsoft.Json;

namespace Model
{	
		
	public class Character
	{
		// ----------------------------- ATTRIBUTES

		int id;
        string name;
        int age;		
		bool isAlive;
		int birthday;
		int deathday;
		string description;      
		string gender;		
		string charPicture;
		int seenAt;
		string language;

        // - - - FAMILY

        List<FamilyTieNode> family;

        // ----------------------------- SETTERS & GETTERS


        public int ID{
			set{	id = value;		}	get{	return id;		}
		}
		public string Name{
			set{	name = value;	}	get{	return name;	}
		}
		public int Age{
			set{	age = value;	}	get{	return age;		}
		}
		public bool IsAlive{
			set{	isAlive = value;	}	get { return isAlive; }
		}
		public string Description {
			get {	return description;	}set {	description = value;	}
		}
        public string Gender{
			set{	gender = value;	}	get{	return gender;	}
		}	
        public string CharPicture {
        	get{ return charPicture; 	}	set{ charPicture = value; }
        }
        public List<FamilyTieNode> Family{
        	get{ return family; } set{ family = value; }
        }
        public int Birthday
        {
        	get { return birthday; } set { birthday = value; }
        }
        public int Deathday
        {
        	get { return deathday; } set { deathday = value; }
        }
        public int SeenAt
        {
        	get { return seenAt; } set { seenAt = value; }
        }
        public string Language
        {
        	get { return language; } set { language = value; }
        }

        // ----------------------------- CONSTRUCTOR

        public Character(int id, string name, int age, int birthday, int deathday, string gender){
			this.id = id;			
			this.name = name;
			this.age = age;
			this.birthday = birthday;
			this.deathday = deathday;
			this.gender = gender;
            this.family = new List<FamilyTieNode>();
		}

		public Character()
		{

		}

		public Character(int filler)
		{
			this.id = 0;
			this.name = "fill this field";
			this.age = 0;
			this.gender = "";
			this.isAlive = false;                  
			this.family = new List<FamilyTieNode>();
		}
		
		public string IsAliveStr()
		{
            if (isAlive == true) { return "Yes"; } else { return "No"; }
        }

		public string SeenAtStr(List<Location> locations)
		{
			string locationName = "";
			foreach(Location location in locations)
			{
				if(location.Id == this.SeenAt)
				{
					locationName = location.LocationName;
					break;
				}
			}
			return locationName;
		}

        public override string ToString()
		{			
			return String.Format("Name: {0,-20} |  {1} years old.", this.Name, this.Age);
		}

	}
}