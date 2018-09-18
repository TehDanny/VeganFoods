using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFoodsBusinessLogic
{
    class RecipeIngredient
    {
        public int RecipeID { get; set; }
        public int IngredientID { get; set; }
        public int Measurement { get; set; }
        public string MeasurementType { get; set; }

        public RecipeIngredient()
        {

        }

        public RecipeIngredient(int recipeID, int ingredientID, int measurement, string measurementType)
        {
            RecipeID = recipeID;
            IngredientID = ingredientID;
            Measurement = measurement;
            MeasurementType = measurementType;
        }
    }
}
