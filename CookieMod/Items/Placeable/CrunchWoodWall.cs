using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWoodWall : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crunch Wall";
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			AddTooltip("");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("CrunchWoodWall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrunchWood");
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}