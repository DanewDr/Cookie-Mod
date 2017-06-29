using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class ChocolateToolTurner : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Tool Turner");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.lifeRegen = 19;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statDefense = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChocolateCookie", 60);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
