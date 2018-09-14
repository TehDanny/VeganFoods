using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    interface IDataController
    {
        void CreateRecipe(Recipe recipe);
        List<Recipe> GetAllRecipes();
        List<Ingredient> GetAllIngredientsOfRecipe(int recipeID);
        List<Ingredient> GetAllIngredientsOfType(string type);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int recipeID);
    }
}
