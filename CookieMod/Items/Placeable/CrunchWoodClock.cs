using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWoodClock: ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crunch Clock";
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			AddTooltip("Tells the time");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 500;
			item.createTile = mod.TileType("CrunchClockTile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glass, 6);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.AddIngredient(null, "CrunchWood", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
