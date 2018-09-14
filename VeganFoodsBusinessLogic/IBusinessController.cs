using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    interface IBusinessController
    {
        void CreateRecipe(string[] recipeData);
        List<string> GetAllRecipes();
        List<string> GetAllIngredientsOfRecipe(int recipeID);
        List<string> GetAllIngredientsOfType(string ingredientType);
        void UpdateRecipe(string[] recipeData);
        void DeleteRecipe(int recipeID);
    }
}
