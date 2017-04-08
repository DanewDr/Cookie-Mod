using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class Flour : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Flour";
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.toolTip = "Used for baking";
			item.rare = 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hay);
			recipe.AddIngredient(null, "SugarDust", 20);
			recipe.AddTile(null, "MilkTank");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}