using Abp.Domain.Entities;
using Dapper;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Data
{
    public class DataAccess
    {
        DapperContext dapperContext;

        public DapperContext DapperContext
        {
        	get { return dapperContext; }
        	set { dapperContext = value; }
        }

        public DataAccess(string path)
        {            
            this.dapperContext = new DapperContext(path);
        }

        // - - - CHARACTERS - - -
        public void InsertCharacters(Character entity)
        {
            using(var connection = dapperContext.GetConnection())
            {                
                string query = "INSERT INTO characters (id, name, age, isAlive, description, gender, charPicture, birthday, deathday, seenAt, language) ";
                query += "VALUES (@id, @name, @age, @isAlive, @description, @gender, @charPicture, @birthday, @deathday, @seenAt, @language)";

                var parameters = new { id = entity.ID, name = entity.Name, age = entity.Age, isAlive = entity.IsAlive, description = entity.Description,
                gender = entity.Gender, charPicture = entity.CharPicture, birthday = entity.Birthday, deathday = entity.Deathday, seenAt = entity.SeenAt,
                language = entity.Language};

                connection.Execute(query, parameters);
            }
        }

        public List<Character> RetrieveCharacters()
        {
            using(var connection = dapperContext.GetConnection())
            {
                string query = "SELECT * FROM characters ORDER BY id ASC";
                List<Character> characters = connection.Query<Character>(query).ToList();

                string familyQuery = "SELECT relatedTieId as Id, tieName as Tie FROM ties WHERE charId = @id";
                foreach(Character character in characters)
                {
                    var parameters = new { id = character.ID};
                    var nodes = connection.Query<FamilyTieNode>(familyQuery, parameters);
                    character.Family = nodes.ToList();
                }
                return characters;
            }
        }

        public Character RetrieveCharacter(int id)
        {
            using(var connection = dapperContext.GetConnection())
            {
                string query = "SELECT * FROM characters WHERE id = @id";
                var parameter = new { id = id };
                Character character = connection.QuerySingle(query, parameter);
                return character;
            }
        }

        public List<Character> SearchForCharacters(string criteria, object value)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "SELECT * FROM characters where " + criteria +" = @value";
                var parameters = new { value = value };
                List<Character> characters = connection.Query<Character>(query, parameters).ToList();

                
                string familyQuery = "SELECT relatedTieId as Id, tieName as Tie FROM ties WHERE charId = @id";
                foreach (Character character in characters)
                {
                    var familyParameters = new { id = character.ID };
                    var nodes = connection.Query<FamilyTieNode>(familyQuery, familyParameters);
                    character.Family = nodes.ToList();
                }
                return characters;
            }
        }

        public void DeleteCharacter(int characterID)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "DELETE FROM characters WHERE id = @id";
                var parameters = new { id = characterID };
                connection.Execute(query, parameters);

                string newQuery = "DELETE FROM ties WHERE charId = @id OR relatedTieId = @id";
                var newParameters = new { id = characterID };
                connection.Execute(newQuery, newParameters);
            }
        }

        public void UpdateCharacter(Character entity)
        {
            using(var connection = dapperContext.GetConnection())
            {
                string query = "UPDATE characters SET name = @name, age = @age, isAlive = @isAlive, description = @description," +
                                " gender = @gender, charPicture = @charPicture, birthday = @birthday, deathday = @deathday, seenAt = @seenAt, " +
                                "language = @language WHERE id = @id";
                var parameters = new
                {
                    id = entity.ID,
                    name = entity.Name,
                    age = entity.Age,
                    isAlive = entity.IsAlive,
                    description = entity.Description,
                    gender = entity.Gender,
                    charPicture = entity.CharPicture,
                    birthday = entity.Birthday,
                    deathday = entity.Deathday,
                    seenAt = entity.SeenAt,
                    language = entity.Language
                };
                connection.Execute(query, parameters);
            }
        }

        // - - - FAMILY TIE NODES - - -
        public void UpdateFamilyTieNode(FamilyTieNode node, int charID)
        {
            using(var connection = dapperContext.GetConnection())
            {
                string query = "UPDATE ties SET relatedTieId = @relatedTieId, tieName = @tieName WHERE charId = @charId";
                var parameters = new
                {
                    relatedTieId = node.Id,
                    tieName = node.Tie,
                    charId = charID
                };
                connection.Execute(query, parameters);
            }
        }

        public void UpdateFamilyTieNode(int charId, FamilyTieNode node)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "UPDATE ties SET tieName = @tieName WHERE charId = @charId AND relatedTieId = @relatedTieId";
                var parameters = new
                {
                    relatedTieId = node.Id,
                    tieName = node.Tie,
                    charId = charId
                };
                connection.Execute(query, parameters);
            }
        }

        public void InsertFamilyTieNode(FamilyTieNode node, int charID)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "INSERT INTO ties (charId, relatedTieId, tieName) VALUES (@charId, @relatedTieId, @tieName)";
                var parameters = new
                {
                    relatedTieId = node.Id,
                    tieName = node.Tie,
                    charId = charID
                };
                connection.Execute(query, parameters);
            }
        }

        public void DeleteFamilyTieNode(FamilyTieNode node, int charID)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "DELETE FROM ties WHERE charId = @charId";
                var parameters = new
                {
                    relatedTieId = node.Id,
                    tieName = node.Tie,
                    charId = charID
                };
                connection.Execute(query, parameters);
            }
        }

        // - - - LOCATIONS - - -
        public void InsertLocation(Location location)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "INSERT INTO locations (id, locationName, locationDescription, continentID) ";
                query += "VALUES (@id, @locationName, @locationDescription, @continentID)";

                var parameters = new
                {
                    id = location.Id,
                    locationName = location.LocationName,
                    locationDescription = location.LocationDescription,
                    continentID = location.ContinentID
                };

                connection.Execute(query, parameters);
            }
        }

        public void DeleteLocation(Location location)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "DELETE FROM locations WHERE id = @id";
                var parameters = new
                {
                    id = location.Id,
                };

                connection.Execute(query, parameters);
            }
        }

        public void UpdateLocation(Location location)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "UPDATE locations SET locationName = @locationName, locationDescription = @locationDescription, continentID = continentID " +
                                "WHERE id = @id";

                var parameters = new
                {
                    id = location.Id,
                    locationName = location.LocationName,
                    locationDescription = location.LocationDescription,
                    continentID = location.ContinentID
                };

                connection.Execute(query, parameters);
            }
        }

        public List<Location> RetrieveLocations()
        {
            List<Location> locations = new List<Location>();

            using (var connection = dapperContext.GetConnection())
            {
                string query = "SELECT * FROM locations";

                locations = connection.Query<Location>(query).ToList();

                return locations;
            }
        }

        // - - - CONTINENTS - - -

        public void InsertContinent(Continent location)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "INSERT INTO continents (id, continentName, continentDescription) ";
                query += "VALUES (@id, @continentName, @continentDescription)";

                var parameters = new
                {
                    id = location.Id,
                    continentName = location.ContinentName,
                    continentDescription = location.ContinentDescription
                };

                connection.Execute(query, parameters);
            }
        }

        public void UpdateContinent(Continent location)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "UPDATE continents SET continentName = @continentName, continentDescription = @continentDescription " +
                                "WHERE id = @id";

                var parameters = new
                {
                    id = location.Id,
                    continentName = location.ContinentName,
                    continentDescription = location.ContinentDescription,                    
                };

                connection.Execute(query, parameters);
            }
        }

        public void DeleteContinent(Continent location)
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "DELETE FROM continents WHERE id = @id";
                var parameters = new
                {
                    id = location.Id,
                };

                connection.Execute(query, parameters);
            }
        }

        public List<Continent> RetrieveContinents()
        {
            using (var connection = dapperContext.GetConnection())
            {
                string query = "SELECT * FROM continents";

                List<Continent> continents = connection.Query<Continent>(query).ToList();

                return continents;
            }
        }

        // - - - LANGUAGES - - -

        public List<string> RetrieveLanguages()
        {
            List<string> languages = new List<string>();

            using(var connection = dapperContext.GetConnection())
            {
                string query = "SELECT * FROM languages";

                languages = connection.Query<string>(query).ToList();

                return languages;
            }
        }
    }
}


