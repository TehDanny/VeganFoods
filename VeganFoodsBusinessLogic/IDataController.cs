using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    interface IDataController
    {
        void CreateRecipe(Recipe recipe);
        IReadOnlyList<Recipe> GetAllRecipes();
        IReadOnlyList<Ingredient> GetAllIngredientsOfRecipe(int recipeID);
        IReadOnlyList<Ingredient> GetAllIngredientsOfType(string type);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int recipeID);
    }
}
