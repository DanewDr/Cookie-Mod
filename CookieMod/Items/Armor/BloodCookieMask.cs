using System.Collections.Generic;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	public class BloodCookieMask : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Blood Cookie Mask";
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