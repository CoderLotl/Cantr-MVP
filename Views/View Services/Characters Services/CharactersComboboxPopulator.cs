using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Presenter;
using Data;

namespace Views
{
    public class CharactersComboboxPopulator
    {
        readonly IRepository _repository;
        readonly CharacterSheetPresenter _characterSheetPresenter;
        DataAccess _dataAccess;

        public CharactersComboboxPopulator(IRepository repository, CharacterSheetPresenter characterSheetPresenter)
        {
            _repository = repository;
            _characterSheetPresenter = characterSheetPresenter;
            _dataAccess = repository.DataAccess;
        }

        public void PopulateCharsCmbBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            CharactersService charactersService = new CharactersService(_dataAccess);

            List<Character> validCharacters = charactersService.CalculateValidRelationships(_repository, _characterSheetPresenter);

            foreach (Character character in validCharacters)
            {
                comboBox.Items.Add(character);
            }
        }
    }
}
