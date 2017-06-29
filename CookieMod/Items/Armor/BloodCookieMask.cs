using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class BloodCookieMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Cookie Mask");
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
