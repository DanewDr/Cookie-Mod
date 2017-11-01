using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class HoneyBand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Band");
			Tooltip.SetDefault("Increases life regen and soaks the player in honey");
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
			player.lifeRegen += 1;
			player.honeyWet = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BandofRegeneration);
			recipe.needHoney = true;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
