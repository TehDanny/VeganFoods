using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFoodsConsole
{
    interface IConsoleController
    {
        List<string> GetAllRecipes();
        List<string> GetAllIngredientsOfType();
        void CreateRecipe(string[] recipeData);
        void UpdateRecipe(int recipeID);
        void DeleteRecipe(int recipeID);
    }
}
