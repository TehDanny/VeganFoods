using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    interface IBusinessController
    {
        List<string> GetAllRecipes();
        List<string> GetAllIngredientsOfType(string ingredientType);
        void CreateRecipe(string[] recipeData);
        void UpdateRecipe(int recipeID);
        void DeleteRecipe(int recipeID);
    }
}
