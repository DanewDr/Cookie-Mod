using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CookieWorkbench : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cookie Factory";
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			AddTooltip("Used to craft cookie things. Can also be used as a normal Workbench!");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 1000;
			item.createTile = mod.TileType("CookieWorkbench");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddRecipeGroup("CorruptBar", 6);
			recipe.AddIngredient(null, "Dough", 2);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}	
	}
}
