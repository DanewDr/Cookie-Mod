using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class PopsiclePopper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lollipopper");
			Tooltip.SetDefault("Let's blow this popsicle stand");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.ranged = true;
			item.noMelee = true;
			item.width = 40;
			item.height = 24;
			item.rare = 2;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.autoReuse = true;
			item.shootSpeed = 6f;
			item.shoot = mod.ProjectileType ("Popsicle");
			item.useAmmo = mod.ItemType("Popsicle");	//Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 7);
			recipe.AddIngredient(null, "Popsicle", 12);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


	}
}