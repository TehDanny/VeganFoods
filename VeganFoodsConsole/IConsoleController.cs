using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFoodsConsole
{
    interface IConsoleController
    {
        string[] GetAllRecipes();
        string[] GetAllIngredientsOfType();
        void CreateRecipe();
        void UpdateRecipe();
    }
}
