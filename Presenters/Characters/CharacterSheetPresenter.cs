﻿using Data;
using Model;
using System.Drawing;
using System.Windows.Forms;
using Views;

namespace Presenter
{
    public class CharacterSheetPresenter
    {
        //*************************************************
        Character character;
        Character fakeCharacter;
        int edited = 0;	// EDITED = 0: NO CHANGES WERE PERFORMED. EDITED = 1: CHANGES WERE PERFORMED BUT NOT CONFIRMED. EDITED = 2: CHANGES WERE EPRFORMED AND CONFIRMED.
        bool newCharacter;
        int initialized = 0;
        Image raceImage; Image genderImage; Image conditionImage; Image spConditionImage;
        DataAccess _dataAccess;
        readonly IRepository _repository;
        readonly IVariables _variables;
        readonly ICharacterSheetView _iCharacterSheet;
        //*************************************************

        public CharacterSheetPresenter(ICharacterSheetView frmCharacterSheet, IRepository repository, IVariables variables, Character character, int option)
        {
            _iCharacterSheet = frmCharacterSheet;
            _repository = repository;
            _dataAccess = repository.DataAccess;
            _variables = variables;
            _iCharacterSheet.CharacterEventArgs = new Character(1);
            _iCharacterSheet.ProgressBarFiller = new ProgressBarFiller();

            switch (option)
            {
                case 0: // VIEW
                    this.character = character;
                    fakeCharacter = CopyCharacter(this.character);
                    break;
                case 1: // CREATE
                    this.newCharacter = true;
                    this.character = new Character(1);
                    this.character.ID = _repository.ID + 1;
                    fakeCharacter = CopyCharacter(this.character);
                    break;
                case 2: // EDIT
                    this.character = character;
                    fakeCharacter = CopyCharacter(this.character);
                    break;
            }

            Subscribe();
        }

        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public Character Character
        {
            get { return character; }
            set { character = value; }
        }

        public Character FakeCharacter
        {
            get { return fakeCharacter; }
            set { fakeCharacter = value; }
        }

        //-----------------------------------------------------
        //------------------ [ METHODS ]
        //-----------------------------------------------------

        private void Subscribe()
        {
            _iCharacterSheet.Undo += (e, o) => fakeCharacter = CopyCharacter(this.character);

            _iCharacterSheet.EditCharData += (e, o) =>
            {
                CharactersService charactersService = new CharactersService(this._dataAccess);

                charactersService.SyncFamilyTies(fakeCharacter, character, _repository.Characters, _variables);
                character = CopyCharacter(o);
                _dataAccess.UpdateCharacter(character);

                if (newCharacter == true)
                {
                    _repository.Add(this.character);
                }
            };

            _iCharacterSheet.AddFamilyTie += (e, o) => AddFamilyNode(o);

            _iCharacterSheet.RemoveFamilyTie += (e, o) => RemoveFamilyNode(o);

            _iCharacterSheet.PopulateFamilyCombobox += (e, o) => PopulateFamilyCombobox(o);
        }

        private Character CopyCharacter(Character copyFrom_Character)
        {
            Character auxChar = new Character(copyFrom_Character.ID, copyFrom_Character.Name, copyFrom_Character.Age, copyFrom_Character.Birthday, copyFrom_Character.Deathday, copyFrom_Character.Gender);

            foreach (FamilyTieNode familyNode in copyFrom_Character.Family)
            {
                FamilyTieNode newNode = new FamilyTieNode(familyNode.Id, familyNode.Tie);
                auxChar.Family.Add(newNode);
            }

            auxChar.Description = copyFrom_Character.Description;
            auxChar.IsAlive = copyFrom_Character.IsAlive;
            auxChar.CharPicture = copyFrom_Character.CharPicture;
            auxChar.SeenAt = copyFrom_Character.SeenAt;
            auxChar.Language = copyFrom_Character.Language;

            return auxChar;
        }

        private void AddFamilyNode(FamilyTieNodeEventArgs familyTieNodeEventArgs)
        {
            FamilyTieNode node = new FamilyTieNode(familyTieNodeEventArgs.Character.ID, familyTieNodeEventArgs.Tie);

            //--------------------------------------------

            foreach (FamilyTieNode anotherNode in fakeCharacter.Family)
            {
                if (node.Id == anotherNode.Id)
                {
                    return; // IF THE CHAR IS ALREADY A FAMILY MEMBER, THIS EXITS THE OPERATION.
                }
            }

            //--------------------------------------------

            fakeCharacter.Family.Add(node); // OTHERWISE I ADD THE FAMILY NODE TO THE FAKE CHAR.            
        }

        private void RemoveFamilyNode(int index)
        {
            foreach (FamilyTieNode anotherFamilyTieNode in fakeCharacter.Family) // THEN I WORK WITH THIS CHAR. I CHECK THEIR FAMILY...
            {
                if (anotherFamilyTieNode.Id == index) // WHEN I FIND THE FAMILY NODE I'M REMOVING...
                {
                    fakeCharacter.Family.Remove(anotherFamilyTieNode); // I REMOVE IT, THAT'S IT!
                    break;
                }
            }
        }

        private void PopulateFamilyCombobox(ComboBox comboBox)
        {
            CharactersComboboxPopulator familyComboboxPopulator = new CharactersComboboxPopulator(_repository, this);
            familyComboboxPopulator.PopulateCharsCmbBox(comboBox);
        }
    }
}
