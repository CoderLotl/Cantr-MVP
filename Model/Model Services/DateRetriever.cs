using System;
using System.IO;
using System.Net;

namespace Model
{
	public class DateRetriever : IDataRetriever
	{
		DateTime baseDate;		
		DateTime currentDate;
		int currentCantrYear;
		int currentCantrDate;

		public DateRetriever()
		{
			this.baseDate = new DateTime(2002, 6, 29);
            this.currentDate = DateTime.Today;
			CalcDate(); CalcYear();
        }

        public int CurrentCantrDate
        {
        	get { return currentCantrDate; }
        }

		private void CalcDate()
		{
            this.currentCantrDate = (this.currentDate - this.baseDate).Days;
        }

		private void CalcYear()
		{
			this.currentCantrYear = this.currentCantrDate / 20;
		}

        public string GetCantrDate()
		{
			string date = "Current Cantr Day: " + this.CurrentCantrDate + " | Current Cantr Year: " +  this.currentCantrYear;

			return date;
		}
		
	}
}
