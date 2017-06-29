using System.Collections.Generic;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CorruptCookieMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupt Cookie Mask");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.rare = 1;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}
