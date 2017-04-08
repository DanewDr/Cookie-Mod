using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class BloodCookieWings : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Wings);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Blood Wings";
			item.width = 22;
			item.height = 20;
			item.toolTip = "The very wings of the Blood Cookie";
			item.value = 1200;
			item.rare = 11;
			item.accessory = true;
			item.expert = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 65;
		}

		public override void VerticalWingSpeeds(ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(ref float speed, ref float acceleration)
		{
			speed = 9f;
			acceleration *= 2.5f;
		}

	}
}