using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CookieMod.Items
{
	public class CookieWingsB : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Wings);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Cookie Wings";
			item.width = 22;
			item.height = 20;
			item.toolTip = "Just don't eat them in midair";
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 90;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.5f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 2f;
			constantAscend = 0.100f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 9f;
			acceleration *= 2.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SoftCookie", 25);
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(null, "MilkTank");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}