using Data;
using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class CharactersService : ICharactersService
    {
        DataAccess _dataAccess;

        public CharactersService(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SyncFamilyTies(Character fakeCharacter, Character character, List<Character> characters, IVariables variables)
        {
            // SYNC BLOCK
            foreach (FamilyTieNode originalFamilyTieNode in character.Family)
            {
                foreach (FamilyTieNode fakeFamilyNode in fakeCharacter.Family)
                {
                    if (originalFamilyTieNode.Id == fakeFamilyNode.Id && originalFamilyTieNode.Tie != fakeFamilyNode.Tie)
                    {
                        originalFamilyTieNode.Tie = fakeFamilyNode.Tie;
                        _dataAccess.UpdateFamilyTieNode(character.ID, originalFamilyTieNode);

                        foreach (Character aCharacter in characters)
                        {
                            if (aCharacter.ID == originalFamilyTieNode.Id)
                            {
                                foreach (FamilyTieNode aFamilyNode in aCharacter.Family)
                                {
                                    if (aFamilyNode.Id == character.ID)
                                    {
                                        string opositeFamilyTie = "";
                                        foreach (RelationshipUnit tie in variables.Relations)
                                        {
                                            if (tie.TieName == originalFamilyTieNode.Tie)
                                            {
                                                opositeFamilyTie = tie.OppositeTie;
                                                break;
                                            }
                                        }

                                        aFamilyNode.Tie = opositeFamilyTie;
                                        _dataAccess.UpdateFamilyTieNode(aCharacter.ID, aFamilyNode);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            List<FamilyTieNode> nodesInFake = fakeCharacter.Family.Except(character.Family, new FamilyTieNodeComparer()).ToList();
            List<FamilyTieNode> nodesInOriginal = character.Family.Except(fakeCharacter.Family, new FamilyTieNodeComparer()).ToList();

            // ADD-INSERT BLOCK
            foreach (FamilyTieNode fakeFamilyNode in nodesInFake)
            {
                foreach (Character aCharacter in characters)
                {
                    if (aCharacter.ID == fakeFamilyNode.Id)
                    {
                        character.Family.Add(fakeFamilyNode);
                        _dataAccess.InsertFamilyTieNode(fakeFamilyNode, character.ID);

                        string opositeFamilyTie = "";
                        foreach (RelationshipUnit tie in variables.Relations)
                        {
                            if (tie.TieName == fakeFamilyNode.Tie)
                            {
                                opositeFamilyTie = tie.OppositeTie;
                                break;
                            }
                        }

                        FamilyTieNode newFamilyNode = new FamilyTieNode(character.ID, opositeFamilyTie);
                        aCharacter.Family.Add(newFamilyNode);
                        _dataAccess.InsertFamilyTieNode(newFamilyNode, aCharacter.ID);
                    }
                }
            }

            // DELETE BLOCK
            foreach (FamilyTieNode originalFamilyNode in nodesInOriginal)
            {
                foreach (Character anotherChar in characters)
                {
                    if (anotherChar.ID == originalFamilyNode.Id)
                    {
                        character.Family.Remove(originalFamilyNode);
                        _dataAccess.DeleteFamilyTieNode(originalFamilyNode, character.ID);

                        foreach (FamilyTieNode finalNode in anotherChar.Family)
                        {
                            if (finalNode.Id == character.ID)
                            {
                                anotherChar.Family.Remove(finalNode);
                                _dataAccess.DeleteFamilyTieNode(finalNode, anotherChar.ID);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public List<Character> CalculateValidRelationships(IRepository charactersService, CharacterSheetPresenter characterSheetPresenter)
        {
            List<Character> result = new List<Character>();

            foreach (Character aCharacter in charactersService.Characters)
            {
                if (aCharacter.ID != characterSheetPresenter.Character.ID)
                {
                    if (characterSheetPresenter.FakeCharacter.Family.Count > 0)
                    {
                        bool addChar = true;

                        foreach (FamilyTieNode familyTie in characterSheetPresenter.FakeCharacter.Family)
                        {
                            if (aCharacter.ID == familyTie.Id)
                            {
                                addChar = false;
                            }
                        }

                        if (addChar == true)
                        {
                            result.Add(aCharacter);
                        }

                    }
                    else
                    {
                        result.Add(aCharacter);
                    }
                }
            }

            return result;
        }

        public void SyncCharsAtRemoval(Character charToRemove, List<Character> characters)
        {
            // THIS MAY LOOK TRIVIAL, BUT IT'S VERY IMPORTANT SINCE IT'S AN UPDATE. - NOT ALL CHANGES ARE PERFORMED AT THE CHAR SHEET
            // AND THIS IS ONE OF THOSE.
            foreach (Character character in characters)
            {
                foreach (FamilyTieNode familyTieNode in character.Family)
                {
                    if (familyTieNode.Id == charToRemove.ID)
                    {
                        character.Family.Remove(familyTieNode);

                        _dataAccess.DeleteFamilyTieNode(familyTieNode, character.ID);
                        break;
                    }
                }
            }
        }

        public void CalcCharsAge(Action<string> message, List<Character> characters)
        {
            DateRetriever dateRetriever = new DateRetriever();
            int _date = dateRetriever.CurrentCantrDate;

            bool calcPerformed = false;

            foreach (Character character in characters)
            {
                if (character.IsAlive == true)
                {
                    if (character.Birthday != 0)
                    {
                        int baseAge = 400; // It's in days.
                        character.Age = (_date - character.Birthday + baseAge) / 20;
                        calcPerformed = true;
                    }
                }
            }
            if (calcPerformed == true)
            {
                message("All ages have been updated.");
            }
            else
            {
                message("No ages were updated.");
            }
        }
    }
}
