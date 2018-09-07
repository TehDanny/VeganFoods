using System;
using System.Collections.Generic;
using System.Text;

namespace VeganFoodsBusinessLogic
{
    class BusinessController : IBusinessController
    {
        DataController dataController = new DataController();

        public void CreateRecipe(string[] recipeData)
        {
            //Recipe recipe = ConvertRecipeStringArrayToRecipe(recipeData);
            //dataController.Create(recipe);
            throw new NotImplementedException();
        }

        public void DeleteRecipe(int recipeID)
        {
            //dataController.Delete(recipeID);
            throw new NotImplementedException();
        }

        public List<string> GetAllIngredientsOfType(string ingredientType)
        {
            //dataController.Read(ingredientType);
            throw new NotImplementedException();
        }

        public List<string> GetAllRecipes()
        {
            //dataController.Read();
            throw new NotImplementedException();
        }

        public void UpdateRecipe(int recipeID)
        {
            //dataController.Update(recipeID);
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

        private Recipe ConvertRecipeStringArrayToRecipe(string[] recipeData)
        {
            return new Recipe(int.Parse(recipeData[0]), int.Parse(recipeData[1]), recipeData[2]);
        }
    }
}
