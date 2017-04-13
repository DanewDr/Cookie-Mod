using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class JawBreakerBlade : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Jawbreaker Blade";          
            item.damage = 38;                        
            item.melee = true;                     
            item.width = 38;
            item.height = 38;
	    item.toolTip = "Don't chew on it!";
            item.useTime = 31;
            item.useAnimation = 31;
            item.useStyle = 1;        
            item.knockBack = 6f;        
            item.rare = 3;            
            item.autoReuse = true;
        }     
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "HardSugarDust", 30);
		recipe.AddTile(null, "CookieWorkbench");
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}
