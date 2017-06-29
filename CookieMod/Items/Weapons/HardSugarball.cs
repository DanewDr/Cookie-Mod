using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class HardSugarball : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardned Sugarball");
			Tooltip.SetDefault("This packs quite a punch");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Snowball);
			item.damage = 25;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 3;
			item.consumable = true;
			item.knockBack = 8f;
			item.ammo = mod.ItemType("SoftSugarball");
			item.shoot = mod.ProjectileType ("HardSugarball");
		}
	}
}
