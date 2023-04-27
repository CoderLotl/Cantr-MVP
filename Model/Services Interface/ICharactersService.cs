using Presenter;
using System;
using System.Collections.Generic;

namespace Model
{
    public interface ICharactersService
    {
        void SyncFamilyTies(Character fakeCharacter, Character character, List<Character> characters, IVariables variables);
        void SyncCharsAtRemoval(Character charToRemove, List<Character> characters);
        List<Character> CalculateValidRelationships(IRepository charactersService, CharacterSheetPresenter characterSheetPresenter);
        void CalcCharsAge(Action<string> message, List<Character> characters);
    }
}
