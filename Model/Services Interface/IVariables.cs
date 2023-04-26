using System;
using System.Collections.Generic;

namespace Model
{
	public interface IVariables
	{
		void LoadVariables();
		
		List<RelationshipUnit> Relations { get; set; }
		List<string> Genders { get; set; }
	}
}
