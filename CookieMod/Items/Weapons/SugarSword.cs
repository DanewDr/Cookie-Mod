using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class SugarSword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Sword");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.damage = 11;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 1f;        
            item.rare = 2;            //mana use
            item.autoReuse = true;
        }    
	public override void AddRecipes()  //How to craft this sword
        {
	    ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SugarCookie", 8);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.SetResult(null, "SugarSword");
            recipe.AddTile(null, "CookieWorkbench");
            recipe.AddRecipe();
        }
    }
}
