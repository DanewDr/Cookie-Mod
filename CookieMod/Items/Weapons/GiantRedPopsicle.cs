using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class GiantRedPopsicle : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Giant Red Popsicle";          
            item.damage = 53;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 1f;        
            item.rare = 1;            //mana use
            item.autoReuse = true;
        }   
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.HallowedBar, 4);
		recipe.AddIngredient(null, "RedPopsicle", 2);
		recipe.AddTile(null, "MilkTank");
		recipe.SetResult(this);
		recipe.AddRecipe();
	}   
    }
}