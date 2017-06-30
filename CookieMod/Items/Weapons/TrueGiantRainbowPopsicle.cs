using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class TrueGiantRainbowPopsicle : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Giant Rainbow Popsicle");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {         
            item.damage = 80;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 2f;        
            item.rare = 1;            //mana use
            item.autoReuse = true;
	    item.shoot = mod.ProjectileType ("RainbowPopsicle");
	    item.shootSpeed = 6f;
        }   
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "GiantRainbowPopsicle");
		recipe.AddIngredient(ItemID.BrokenHeroSword);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
    }
}
