using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public int RecipeIngredientsID { get; set; }
        public string Name { get; set; }

        public Recipe()
        {

        }

        public Recipe(int recipeID, int recipeIngredientsID, string name)
        {
            RecipeID = recipeID;
            RecipeIngredientsID = recipeIngredientsID;
            Name = name;
        }
    }
}
