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
        void UpdateRecipe(int recipeID);
        void DeleteRecipe(int recipeID);
    }
}
