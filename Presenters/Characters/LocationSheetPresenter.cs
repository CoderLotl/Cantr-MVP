using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Presenters
{
    public class LocationSheetPresenter
    {
        ILocationSheet _locationSheet;
        DataAccess _dataAccess;
        IRepository _repository;
        bool nameChanged;
        bool descriptionChanged;
        bool continentChanged;
        int option; // 1 for create, 0 for view
        Location _location;

        public LocationSheetPresenter(ILocationSheet locationSheet, DataAccess dataAccess, IRepository repository, int opt, Location location)
        {
            _locationSheet = locationSheet;
            _dataAccess = dataAccess;
            _repository = repository;
            nameChanged = false;
            descriptionChanged = false;
            continentChanged = false;
            this.option = opt;
            _location = location;
            Subscribe();

            if(option == 0)
            {                
                _locationSheet.LocationName = _location.LocationName;
                _locationSheet.Description = _location.LocationDescription;
                _locationSheet.Continent.Text = _location.ContinentToString(_repository.Continents);
            }
            CheckDataFilled();
        }

        public void Subscribe()
        {
            _locationSheet.Load += (e, o) =>
            {
                PopulateCombobox();
            };

            _locationSheet.LocationNameChanged += (e, o) =>
            {
                CheckLocationNameChange();
            };

            _locationSheet.LocationDescriptionChanged += (e, o) =>
            {
                CheckDescriptionChange();
            };

            _locationSheet.LocationContinentChanged += (e, o) =>
            {
                CheckContinentChange();
            };

            _locationSheet.Accept += (e, o) =>
            {
                Accept();
            };
        }

        private void CheckContinentChange()
        {
            if (option == 1)
            {
                if (_locationSheet.Continent.Text != "")
                {
                    continentChanged = true;
                }
                else
                {
                    continentChanged = false;
                }
            }
            else
            {
                if (_locationSheet.Continent.Text != _location.ContinentToString(_repository.Continents))
                {
                    continentChanged = true;
                }
                else
                {
                    continentChanged = false;
                }
            }            
        }

        private void Accept()
        {
            if(nameChanged == true)
            {
                _location.LocationName = _locationSheet.LocationName;
                _location.LocationDescription = _locationSheet.Description;
                _location.ContinentID = Continent.ContinentID(_repository.Continents, _locationSheet.Continent.Text);                

                if(option == 1)
                {
                    _location.Id = (_repository.Locations.Max(t => t.Id) + 1);
                    _dataAccess.InsertLocation(_location);
                    _repository.Locations.Add(_location);
                }
                else
                {
                    _dataAccess.UpdateLocation(_location);
                }
            }
        }

        public void PopulateCombobox()
        {
            _locationSheet.Continent.Items.Add("");
            foreach(Continent continent in _repository.Continents)
            {
                _locationSheet.Continent.Items.Add(continent.ContinentName);
            }
        }

        public void CheckLocationNameChange()
        {
            if(option == 1)
            {
                if(_locationSheet.LocationName != "")
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
                if(_locationSheet.LocationName != _location.LocationName)
                {
                    nameChanged = true;
                }
                else
                {
                    nameChanged = false;
                }
            }
            CheckDataFilled();
        }

        public void CheckDescriptionChange()
        {
            if (option == 1)
            {
                if (_locationSheet.Description != "")
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
                if (_locationSheet.Description != _location.LocationDescription)
                {
                    descriptionChanged = true;
                }
                else
                {
                    descriptionChanged = false;
                }
            }
        }

        public void CheckDataFilled()
        {
            if(option == 1)
            {
                if(nameChanged == true)
                {
                    _locationSheet.BtnAccept.Enabled = true;
                }
                else
                {
                    _locationSheet.BtnAccept.Enabled = false;
                }
            }
            else if(_locationSheet.LocationName != "")
            {
                _locationSheet.BtnAccept.Enabled = true;            
            }
            else
            {
                _locationSheet.BtnAccept.Enabled = false;
            }
        }
    }
}

