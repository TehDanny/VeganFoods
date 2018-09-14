using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            var query = from recipe in vfe.recipes
                        where recipe.RecipeID == recipeID
                        select recipe;

            vfe.recipes.Remove(query);
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
                        orderby recipe.Name
                        select recipe;

            return query;
        }

        public void UpdateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
