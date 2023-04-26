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
    public class LocationsManagerPresenter
    {
        //*************************************************	

        private ILocationsManager _locationsManager;
        IRepository _repository;
        DataTable locationsDataTable;
        DataView locationsDataView;
        DataTable continentsDataTable;
        DataView continentsDataView;
        DataAccess dataAccess;
        TableService tableService;

        public LocationsManagerPresenter(ILocationsManager locationsManager, IRepository repository, DataAccess dataAccess)
        {
            _locationsManager = locationsManager;
            _repository = repository;
            locationsDataTable = new DataTable();
            locationsDataView = new DataView();
            continentsDataTable = new DataTable();
            continentsDataView = new DataView();
            dataAccess = dataAccess;
            tableService = new TableService();
            Subscribe();
        }

        //*************************************************	

        public ILocationsManager LocationsManager
        {
            get { return _locationsManager; } set { this._locationsManager = value; }
        }        

        public IRepository Repository
        {
            get { return _repository; } set { this._repository = value; }
        }

        public DataTable LocationsDataTable { get => locationsDataTable; set => locationsDataTable = value; }
        public DataView LocationsDataView { get => locationsDataView; set => locationsDataView = value; }
        public DataTable ContinentsDataTable { get => continentsDataTable; set => continentsDataTable = value; }
        public DataView ContinentsDataView { get => continentsDataView; set => continentsDataView = value; }

        private void Subscribe()
        {
            _locationsManager.DrawLocationsTable += (e, o) =>
            {
                tableService.DrawLocationsTable(1, _locationsManager.Locations, this);
            };

            _locationsManager.DrawContinentsTable += (e, o) =>
            {
                tableService.DrawContinentsTable(1, _locationsManager.Continents, this);
            };

            _locationsManager.RemoveLocation += (e, o) =>
            {
                _repository.RemoveLocation(o);
            };

            _locationsManager.RemoveContinent += (e, o) =>
            {
                _repository.RemoveContinent(o);
            };
        }
    }
}
