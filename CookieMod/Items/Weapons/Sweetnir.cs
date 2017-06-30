using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class Sweetnir : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sweetnir");
			Tooltip.SetDefault("All the sugar in the world combined into a single sword.");
		}
        public override void SetDefaults()
        {
            item.damage = 72;                        
            item.melee = true;                     
            item.width = 58;
            item.height = 58;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 1;        
            item.knockBack = 4f;        
            item.rare = 5;            
            item.autoReuse = true;
        }      
	public override void AddRecipes()
	{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VanillaSwirl");
            recipe.AddIngredient(null, "CookieClaymore");
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
