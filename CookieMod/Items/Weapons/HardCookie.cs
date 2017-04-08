using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class HardCookie : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Hard Cookie";
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.toolTip = "Too hard to do anything with right now,";
			item.toolTip2 = "but it smells like cinnamon!";
			item.rare = 2;
			item.consumable = true;
			item.ammo = item.type;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Flour", 5);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}