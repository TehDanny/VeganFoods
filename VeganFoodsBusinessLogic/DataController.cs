using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace VeganFoodsBusinessLogic
{
    class DataController : IDataController
    {
        private MySqlConnection connectionString;

        public DataController()
        {
            connectionString = new MySqlConnection("Server=localhost;database=VeganFoods;uid=root;Pwd=admin");
        }

        public void CreateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAllIngredientsOfRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAllIngredientsOfType(string type)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public void UpdateRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }
    }
}
