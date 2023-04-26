using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SearchCriteriaEventArgs : EventArgs
    {
        string criteria;
        string critValue;

        public SearchCriteriaEventArgs(string criteria, string critValue)
        {
            this.criteria = criteria;
            this.critValue = critValue;
        }

        public SearchCriteriaEventArgs()
        {

        }

        public string Criteria
        {
        	get { return criteria; } set { criteria = value; }
        }
        public string Value
        {
        	get { return critValue; } set { this.critValue = value; }
        }
    }
}
