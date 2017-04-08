using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class SoftCookie : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cookie";
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.toolTip = "An actually edible cookie.";
			item.rare = 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Flour", 3);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}