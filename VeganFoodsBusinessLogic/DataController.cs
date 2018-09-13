using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    class DataController : IDataController
    {
        private VeganFoodsEntities vfe;

        public DataController()
        {
            vfe = new VeganFoodsEntities();
        }

        public void CreateRecipe(Recipe recipe)
        {
            vfe.recipes.Add(recipe);
            vfe.SaveChanges();
        }

        public void DeleteRecipe(int recipeID)
        {
            vfe.recipes.Remove(recipeID);
            vfe.SaveChanges();
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
            var query = from recipe in vfe.recipes
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
