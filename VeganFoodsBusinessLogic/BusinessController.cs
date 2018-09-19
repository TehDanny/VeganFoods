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
            Recipe recipe = ConvertRecipeStringArrayToRecipe(recipeData);
            dataController.CreateRecipe(recipe);
        }

        public List<string> GetAllRecipes()
        {
            IReadOnlyList<Recipe> recipeList = dataController.GetAllRecipes();
            List<string> recipeStringList = ConvertRecipeListToStringList(recipeList);
            return recipeStringList;
        }

        public List<string> GetAllRecipeIngredients(int recipeID)
        {
            IReadOnlyList<RecipeIngredient> recipeIngredientList = dataController.GetAllRecipeIngredients(recipeID);
            List<string> RecipeIngredientStringList = ConvertRecipeIngredientListToStringList(recipeIngredientList);
            return RecipeIngredientStringList;
        }

        public List<string> GetAllIngredientsOfType(string ingredientType)
        {
            IReadOnlyList<Ingredient> ingredientList = dataController.GetAllIngredientsOfType(ingredientType);

            List<string> IngredientsStringList = ConvertIngredientListToStringList(ingredientList);

            return IngredientsStringList;
        }

        public void UpdateRecipe(string[] recipeData)
        {
            Recipe recipe = ConvertRecipeStringArrayToRecipe(recipeData);
            dataController.UpdateRecipe(recipe);
        }

        public void DeleteRecipe(int recipeID)
        {
            dataController.DeleteRecipe(recipeID);
        }

        private List<string> ConvertRecipeListToStringList(IReadOnlyList<Recipe> recipeList)
        {
            var stringList = new List<string>();

            foreach (var recipe in recipeList)
            {
                stringList.Add(recipe.Name);
            }

            return stringList;
        }

        private List<string> ConvertIngredientListToStringList(IReadOnlyList<Ingredient> ingredientList)
        {
            var stringList = new List<string>();

            foreach (var ingredient in ingredientList)
            {
                stringList.Add(ingredient.Name);
            }

            return stringList;
        }

        private List<string> ConvertRecipeIngredientListToStringList(IReadOnlyList<RecipeIngredient> recipeIngredientList)
        {
            /*
            var stringList = new List<string>();
            Ingredient ingredient; 

            foreach (var recipeIngredient in recipeIngredientList)
            {
                ingredient = dataController.GetIngredient();
                stringList.Add(recipeIngredient.);
            }

            return stringList;
            */

            throw new NotImplementedException();
        }

        private Recipe ConvertRecipeStringArrayToRecipe(string[] recipeData)
        {
            return new Recipe(int.Parse(recipeData[0]), int.Parse(recipeData[1]), recipeData[2]);
        }
    }
}
