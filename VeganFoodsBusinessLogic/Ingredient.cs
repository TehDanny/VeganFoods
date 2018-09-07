using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    class Ingredient
    {
        public int IngredientID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Ingredient(int ingredientID, string name, string type)
        {
            IngredientID = ingredientID;
            Name = name;
            Type = type;
        }
    }
}
