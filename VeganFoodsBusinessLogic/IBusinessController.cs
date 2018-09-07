using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    interface IBusinessController
    {
        List<string> GetAllRecipes();
        List<string> GetAllIngredientsOfType();
        void CreateRecipe(List<string> recipeData);
        void UpdateRecipe(int recipeID);
        void DeleteRecipe(int recipeID);
    }
}
