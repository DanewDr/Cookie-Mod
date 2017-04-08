using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class SugarCrystal : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sugar Crystal";
			item.width = 16;
			item.height = 18;
			item.accessory = true;
			item.toolTip = "8% increased damage";
			item.toolTip2 = "10% increased melee speed";
			item.rare = 2;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.meleeDamage += .08f;
		player.rangedDamage += .08f;
		player.thrownDamage += .08f;
		player.magicDamage += .08f;
		player.meleeSpeed += .10f;
		}
	}
}