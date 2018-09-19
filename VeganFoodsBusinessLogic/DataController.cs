using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            context.recipes.Add(new recipes { RecipeID = recipe.RecipeID, RecipeIngredientsID = recipe.RecipeIngredientsID, Name = recipe.Name });
            context.SaveChanges();
        }

        public void DeleteRecipe(int recipeID)
        {
            var recipe = context.recipes.Find(recipeID);

            context.recipes.Remove(recipe);
            context.SaveChanges();
        }

        public IReadOnlyList<Ingredient> GetAllIngredientsOfType(string type)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<RecipeIngredient> GetAllRecipeIngredients(int recipeID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Recipe> GetAllRecipes()
        {
            var query = from recipe in context.recipes
                        orderby recipe.Name
                        select new Recipe
                        {
                            Name = recipe.Name,
                            RecipeID = recipe.RecipeID,
                            RecipeIngredientsID = recipe.RecipeIngredientsID
                        };

            return query.ToList();
        }

        public void UpdateRecipe(Recipe recipe)
        {
            var oldRecipe = context.recipes.Find(recipe.RecipeID);
            oldRecipe.Name = recipe.Name;
            context.SaveChanges();
        }
    }
}
