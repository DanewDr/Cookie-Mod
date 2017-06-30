using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class CookieLongsword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Longsword");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {         
            item.damage = 42;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 3f;        
            item.rare = 5;            //mana use
            item.autoReuse = true;
        }   
	public override void AddRecipes()
	{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 4);
            recipe.AddIngredient(null, "Cookie", 12);
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
