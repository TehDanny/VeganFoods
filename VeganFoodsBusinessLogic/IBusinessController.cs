using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    interface IBusinessController
    {
        string[] GetAllRecipes();
        string[] GetAllIngredientsOfType();
        void CreateRecipe();
        void UpdateRecipe();
    }
}
