using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class Biscuit : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.BottledWater);
			item.name = "Biscuit";
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.toolTip = "A bit dry";
			item.rare = 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Flour", 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}