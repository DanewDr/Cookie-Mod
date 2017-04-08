using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class ChocolateCookie : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Chocolate Cookie";
            item.width = 20;
            item.height = 20;
            item.toolTip = "This makes me feel, Happy!";
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
	}   
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 5);
	    recipe.AddIngredient(null, "CooledChocolate", 1)
	    recipe.AddTile(null, "CookieWorkbench");
	    recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}
