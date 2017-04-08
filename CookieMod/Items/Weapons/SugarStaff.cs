using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class SugarStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Vanilla Staff";          
            item.damage = 98;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.toolTip = "The staff every baker wants.";
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;        //this is how the item is holded
	    Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 2f;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 13;             //mana use
            item.UseSound = SoundID.Item21;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("SugarBeam");  //this make the item shoot 
            item.shootSpeed = 8f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "CookieRod");
		recipe.AddIngredient(null, "SugarWand");
		recipe.AddIngredient(ItemID.BeetleHusk, 8);
		recipe.AddIngredient(null, "SugarDust", 20);
		recipe.AddIngredient(null, "CookieDust", 20);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
	public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useTime = 25;
				item.useAnimation = 25;
				item.damage = 102;
				item.shoot = mod.ProjectileType ("FullCookie");
				item.shootSpeed = 5f;
			}
			else
			{
				item.useTime = 18;
				item.useAnimation = 18;
				item.damage = 76;
				item.shoot = mod.ProjectileType ("SugarBeam");
				item.mana = 9;
			}
			return base.CanUseItem(player);
		}
    }
}
