using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    class BusinessController : IBusinessController
    {
        public void CreateRecipe(List<string> recipeData)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllIngredientsOfType()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public void UpdateRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }

        private List<string> ConvertRecipeListToStringList(List<Recipe> recipeList)
        {
            var stringList = new List<string>();

            foreach (var recipe in recipeList)
            {
                stringList.Add(recipe.Name);
            }

            return stringList;
        }

        private List<string> ConvertIngredientListToStringList(List<Ingredient> ingredientList)
        {
            var stringList = new List<string>();

            foreach (var ingredient in ingredientList)
            {
                stringList.Add(ingredient.Name);
            }

            return stringList;
        }
    }
}
