using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace VeganFoodsBusinessLogic
{
    class DataController : IDataController
    {
        private VeganFoodsDataContext context;

        public DataController()
        {
            context = new VeganFoodsDataContext();
        }

        public void CreateRecipe(Recipe recipe)
        {
            context.InsertOnSubmit(recipe);
            context.SubmitChanges();
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
            var query = from recipe in context.Recipes
                        orderby recipe.Name
                        select recipe;

            return query;
        }

        public void UpdateRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }
    }
}
