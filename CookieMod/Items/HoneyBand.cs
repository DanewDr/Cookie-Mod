using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class HoneyBand : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Honey Band";
			item.width = 24;
			item.height = 28;
			item.toolTip = "Increases life regen but decreases movement speed";
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 1000;
			item.lifeRegen = 19;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffType = mod.BuffType("Honeyed");
			player.buffType = BuffID.Honey;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HoneyCookie", 60);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
