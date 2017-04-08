using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class SugarBand : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sugar Band";
			item.width = 16;
			item.height = 18;
			item.accessory = true;
			item.toolTip = "8% increased damage and melee speed";
			item.toolTip2 = "12% increased movement speed";
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