using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SoftSugarball : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Snowball);
			item.name = "Sugarball";
			item.damage = 11;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.toolTip = "Hurts quite a bit actually.";
			item.rare = 2;
			item.consumable = true;
			item.knockBack = 1f;
			item.ammo = item.type;
			item.shoot = mod.ProjectileType ("SoftSugarball");
		}
	}
}
