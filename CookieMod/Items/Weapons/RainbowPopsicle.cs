using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class RainbowPopsicle : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Rainbow Popsicle";
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 2;
			item.consumable = true;
			item.damage = 42;
			item.shoot = mod.ProjectileType ("RainbowPopsicle");
			item.ammo = mod.ItemType("Popsicle");
		}
	}
}