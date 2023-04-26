using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
	public class Variables : IVariables
    {
        List<RelationshipUnit> _relations;
        List<string> _genders;

        public Variables()
        {
            _relations = new List<RelationshipUnit>();
            _genders = new List<string>();
            
            LoadVariables();
        }

        public List<RelationshipUnit> Relations { get { return _relations; }	set { _relations = value; }	}
        public List<string> Genders { get { return _genders; }	set { _genders = value; }	}
        
        public void LoadVariables()
        {
        	JSONSerializer<List<string>> jsonSerializer;
        	
        	string variable = "Genders";        	
        	jsonSerializer = new JSONSerializer<List<string>>(variable, 1); this._genders = jsonSerializer.DeSerialize();
        	
        	// ---------------------
        	
        	JSONSerializer<List<RelationshipUnit>> anotherJsonSerializer;
        	variable = "Relationships";
        	anotherJsonSerializer = new JSONSerializer<List<RelationshipUnit>>(variable, 1);
        	this._relations = anotherJsonSerializer.DeSerialize();        	
        }
    }
}
