using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class SugarBand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Band");
			Tooltip.SetDefault("8% increased damage and melee speed\n12% increased damage and melee speed");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 18;
			item.accessory = true;
			item.rare = 2;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.meleeDamage += .08f;
		player.rangedDamage += .08f;
		player.thrownDamage += .08f;
		player.magicDamage += .08f;
		player.meleeSpeed += .08f;
		player.moveSpeed += .12f;
		}
	}
}
