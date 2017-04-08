using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class HardSugarball : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Snowball);
			item.name = "Hardened Sugarball";
			item.damage = 25;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.toolTip = "This packs quite a punch.";
			item.rare = 3;
			item.consumable = true;
			item.knockBack = 8f;
			item.ammo = AmmoID.Snowball;
		}
	}
}