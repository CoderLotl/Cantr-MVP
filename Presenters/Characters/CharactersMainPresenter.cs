﻿using System;
using System.Data;
using System.Collections.Generic;
using Model;
using Views;
using Data;
using System.Drawing;
using Maro_MVP;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Maro_MVP.Views.Forms.Characters_Forms;

namespace Presenter
{
	public class CharactersMainPresenter
	{
		//*************************************************	
		
		private readonly ICharactersMain _iCharacters;
		private readonly IRepository _repository;
		DataAccess _dataAccess;
		TableService _tableService;
        DataTable charsDT;
        DataView charsDTDV;
		string mainName;
		string dbName;
        
		//*************************************************	


        //-----------------------------------------------------
        //------------------ [ CONSTRUCTOR ]
        //-----------------------------------------------------
        public CharactersMainPresenter(ICharactersMain iCharacters, IRepository repository)
		{
			_iCharacters = iCharacters;
			_repository = repository;
			_dataAccess = repository.DataAccess;
			_tableService = new TableService();
			mainName = _iCharacters.Text;

			_iCharacters.RemoveCharacter += (e, o) =>	_repository.RemoveChar(o);
			
			_iCharacters.LoadFile += (e, o) =>
			{
				if(_repository.LoadData() == true)
				{
                    dbName = _repository.DataAccess.DapperContext.ConnectionString;
                    _iCharacters.Text = mainName + " - - - " + dbName;
					_iCharacters.EnableAll();
                    UpdateCharacterLabel();
                }
				else
				{
					_iCharacters.DisableAll();
				}
			};			
			
			_iCharacters.Clear += (e, o) =>
			{
				_repository.Characters.Clear();
				_iCharacters.Text = mainName;
                _iCharacters.DisableAll();
				UpdateCharacterLabel();
			};

			_iCharacters.UpdateAmountOfCharacters += (e, o) =>	UpdateCharacterLabel();

			_iCharacters.CalculateCharsAge += (e, o) =>
			{
				DataAccess dataAccess = _repository.DataAccess;
				CharactersService charactersService1 = new CharactersService(_dataAccess);
				charactersService1.CalcCharsAge(o, _repository.Characters);
				foreach(Character character in _repository.Characters)
				{
					dataAccess.UpdateCharacter(character);
				}
			};

			_iCharacters.SaveTableToHtmlFileWithSelection += (e, o) =>
			{				
				FrmCharactersDataGridSelector selector = new FrmCharactersDataGridSelector(charsDTDV.ToTable());
				selector.Show();
			};

			_iCharacters.SaveTableToHtmlFile += (e, o) =>
			{
                _tableService.SaveTableToHtml(this.CharsDTDV);
            };

			_iCharacters.CreateDB += (e, o) =>
			{
				DataBaseService dataBaseService = new DataBaseService();
				dataBaseService.GenerateDataBase();
			};

			_iCharacters.ViewMap += (e, o) =>
			{
                string runningPath = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = string.Format("{0}Resources\\getimg.jpg", Path.GetFullPath(Path.Combine(runningPath, @"..\..\")));

				var process = new Process();
                process.StartInfo.FileName = fileName;
                process.Start();
            };

            _iCharacters.DrawTable += (e, o) =>
            {
                _tableService.DrawCharsTable(o, _iCharacters.DataGridView, this);
            };

			_iCharacters.SearchCriteria += (e, o) =>
			{
				_tableService.SearchChars(o, this, _iCharacters.DataGridView);
			};
		}

        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public DataTable CharsDT
        {
            get { return charsDT; }
            set { charsDT = value; }
        }

        public DataView CharsDTDV
        {
            get { return charsDTDV; }
            set { charsDTDV = value; }
        }

        public IRepository CharactersService
        {
        	get { return _repository; }
        }

        //-----------------------------------------------------
        //------------------ [ METHODS ]
        //-----------------------------------------------------

        private void UpdateCharacterLabel()
		{
			_iCharacters.Lbl_Characters = _repository.Characters.Count.ToString();
		}
    }
}