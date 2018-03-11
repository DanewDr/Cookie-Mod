using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class SugarCookie : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Cookie");
			Tooltip.SetDefault("Warm and toasty");
		}

        public override void SetDefaults()
        {
            item.damage = 14;
	    item.consumable = true;
	    item.shoot = mod.ProjectileType ("ThrowingCookieSugar");
	    item.ammo = mod.ItemType("SlingshotAmmo");
	    item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 2;
            item.maxStack = 999;
	}   
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie");
	    recipe.AddIngredient(null, "SugarDust");
	    recipe.AddTile(null, "CookieWorkbench");
	    recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
