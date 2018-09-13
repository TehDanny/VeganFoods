using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    class DataController : IDataController
    {
        private VeganFoodsEntities context;

        public DataController()
        {
            context = new VeganFoodsEntities();
        }

        public void CreateRecipe(Recipe recipe)
        {
            context.recipes.Add(recipe);
            context.SaveChanges();
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
            var query = from recipe in context.recipes
                        orderby recipe.name
                        select recipe;

            return query;
        }

        public void UpdateRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }
    }
}
