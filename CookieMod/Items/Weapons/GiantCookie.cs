using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class GiantCookie : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Giant Cookie";
			item.damage = 22;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 2;
			item.consumable = true;
			item.ammo = mod.ItemType("HardCookie");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HardCookie", 3);
			recipe.AddIngredient(null, "CookieDust", 15);
			recipe.AddTile(null, "MilkTank");
			recipe.SetResult(this, 6);
			recipe.AddRecipe();
		}
	}
}