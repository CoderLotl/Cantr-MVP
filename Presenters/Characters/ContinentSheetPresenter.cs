using Data;
using Model;
using System.Linq;
using Views;

namespace Presenters
{
    public class ContinentSheetPresenter
    {
        IContinentSheet _continentSheet;
        DataAccess _dataAccess;
        IRepository _repository;
        bool nameChanged;
        bool descriptionChanged;
        int option; // 1 for create, 0 for view
        Continent _continent;

        public ContinentSheetPresenter(IContinentSheet continentSheet, DataAccess dataAccess, IRepository repository, int opt, Continent location)
        {
            _continentSheet = continentSheet;
            _dataAccess = dataAccess;
            _repository = repository;
            nameChanged = false;
            descriptionChanged = false;
            this.option = opt;
            _continent = location;
            Subscribe();

            if (option == 0)
            {
                _continentSheet.LocationName = _continent.ContinentName;
                _continentSheet.Description = _continent.ContinentDescription;
            }
            CheckDataFilled();
        }

        public void Subscribe()
        {
            _continentSheet.ContinentNameChanged += (e, o) =>
            {
                CheckContinentNameChange();
            };

            _continentSheet.ContinentDescriptionChanged += (e, o) =>
            {
                CheckDescriptionChange();
            };

            _continentSheet.Accept += (e, o) =>
            {
                Accept();
            };
        }

        private void Accept()
        {
            if (nameChanged == true || descriptionChanged == true)
            {
                _continent.ContinentName = _continentSheet.LocationName;
                _continent.ContinentDescription = _continentSheet.Description;

                if (option == 1)
                {
                    _continent.Id = (_repository.Continents.Max(t => t.Id) + 1);
                    _dataAccess.InsertContinent(_continent);
                    _repository.Continents.Add(_continent);
                }
                else
                {
                    _dataAccess.UpdateContinent(_continent);
                }
            }
        }

        public void CheckContinentNameChange()
        {
            if (option == 1)
            {
                if (_continentSheet.LocationName != "")
                {
                    nameChanged = true;
                }
                else
                {
                    nameChanged = false;
                }
            }
            else
            {
                if (_continentSheet.LocationName != _continent.ContinentName)
                {
                    nameChanged = true;
                }
                else
                {
                    nameChanged = false;
                }
            }
        }

        public void CheckDescriptionChange()
        {
            if (option == 1)
            {
                if (_continentSheet.Description != "")
                {
                    descriptionChanged = true;
                }
                else
                {
                    descriptionChanged = false;
                }
            }
            else
            {
                if (_continentSheet.Description != _continent.ContinentDescription)
                {
                    descriptionChanged = true;
                }
                else
                {
                    descriptionChanged = false;
                }
            }
            CheckDataFilled();
        }
        public void CheckDataFilled()
        {
            if (option == 1)
            {
                if (nameChanged == true)
                {
                    _continentSheet.BtnAccept.Enabled = true;
                }
                else
                {
                    _continentSheet.BtnAccept.Enabled = false;
                }
            }
            else if (_continentSheet.LocationName != "")
            {
                _continentSheet.BtnAccept.Enabled = true;
            }
            else
            {
                _continentSheet.BtnAccept.Enabled = false;
            }
        }
    }
}

