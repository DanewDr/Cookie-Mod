using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWoodChair : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crunch Chair";
			item.width = 12;
			item.height = 30;
			item.maxStack = 99;
			AddTooltip("Probably not to comfortable");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("CrunchWoodChair");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenChair);
			recipe.AddIngredient(null, "CrunchWood", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}