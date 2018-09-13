using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganFoodsDataLogic
{
    public class Class1
    {
        private vegan_foodsEntities context;

        public Class1()
        {
            context = new vegan_foodsEntities();
        }

        public void CreateRecipe(Recipe recipe)
        {
            context.recipes.Add(recipe);
            context.SaveChanges();
        }

        public List<Recipe> GetAllRecipes()
        {
            var query = from recipe in context.recipes
                        orderby recipe.Name
                        select recipe;

            return query;
        }
    }
}
