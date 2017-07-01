using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class Slingshot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slingshot");
			Tooltip.SetDefault("Allows you to use extra cookies as ammo");
		}
		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.noMelee = true;
			item.width = 34;
			item.height = 22;
			item.rare = 2;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType ("ThrowingCookie");
			item.shootSpeed = 6f;
			item.useAmmo = mod.ItemType("SlingshotAmmo");	//Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}
		public override void AddRecipes()
        	{
            		ModRecipe recipe = new ModRecipe(mod);
            		recipe.AddIngredient(null, "Wood", 5);
	   		recipe.AddRecipeGroup("IronBar", 2);
           		recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
           		recipe.AddRecipe();
      		}
	}
}
