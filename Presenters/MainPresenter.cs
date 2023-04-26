using System;
using System.Collections.Generic;
using Views;
using Model;

namespace Presenter
{
	public class MainPresenter
	{
		//*************************************************	
		
		private readonly IMainView _iMainView;
		readonly public IRepository _repository;
		readonly public IVariables variables;
		string date;
		
		//*************************************************	
		
		public MainPresenter(IMainView iMainView)
		{
			_iMainView = iMainView;
			_repository = new Repository();
			variables = new Variables();
			
			iMainView.RetrieveData += (o, e) =>
			{
				DateRetriever retriever = new DateRetriever();
				date = retriever.GetCantrDate();
				Retrieve(date);
			};			
			
		}		

		//-----------------------------------------------------
		//------------------ [ METHODS ]
		//-----------------------------------------------------
		
		public void Retrieve(string date)
		{			
			_iMainView.Lbl_MaroDate = date;
		}
	}
}