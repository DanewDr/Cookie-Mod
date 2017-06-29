using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWoodDresser: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Dresser");
			Tooltip.SetDefault("Change clothes and even stor items!");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 500;
			item.createTile = mod.TileType("CrunchWoodDresser");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Dresser);
			recipe.AddIngredient(null, "CrunchWood", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
