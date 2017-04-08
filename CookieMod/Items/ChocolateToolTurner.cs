using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class ChocolateToolTurner : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Chocolate Tool Turner";
			item.width = 24;
			item.height = 28;
			item.toolTip = "This is a modded accessory.";
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 1000;
			item.lifeRegen = 19;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statDefense = 0;
			player.meleeDamage = 0.1f;
			player.thrownDamage = 0.1f;
			player.rangedDamage = 0.1f;
			player.magicDamage = 0.1f;
			player.minionDamage = 0.1f;
			player.lifeRegen = -120;
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