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
            ItemID.Sets.ItemNoGravity[item.type] = false;  //this make that the item will float in air
        }
 
       
 
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 5);
	    recipe.AddIngredient(null, "CooledChocolate", 1)
	    recipe.AddTile(null, "CookieWorkbench");
            recipe.AddRecipe();
        }
    }
}
