using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class VanillaStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vanilla Staff");
			Tooltip.SetDefault("A staff made of sugar and chocolate");
		}
        public override void SetDefaults()
        {         
            item.damage = 46;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;        //this is how the item is holded
	    Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 2f;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 8;             //mana use
            item.UseSound = SoundID.Item21;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("SugarBeam");  //this make the item shoot 
            item.shootSpeed = 9f;    //projectile speed when shoot
        }      
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "ChocolateStave");
		recipe.AddIngredient(null, "SugarStaff");
		recipe.AddIngredient(null, "SugarDust", 20);
		recipe.AddIngredient(null, "CookieDust", 20);
    recipe.AddIngredient(ItemID.SoulofSight, 15);
		recipe.AddTile(null, "CookieWorkbench");
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
				item.useTime = 28;
				item.useAnimation = 28;
				item.damage = 48;
				item.shoot = mod.ProjectileType ("ChocolateBall");
				item.shootSpeed = 6f;
			}
			else
			{
				item.useTime = 22;
				item.useAnimation = 22;
				item.damage = 46;
				item.shoot = mod.ProjectileType ("SugarBeam");
				item.mana = 11;
			}
			return base.CanUseItem(player);
		}
    }
}
