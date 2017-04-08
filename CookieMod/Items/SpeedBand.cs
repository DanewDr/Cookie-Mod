using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class SpeedBand : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Speed Band";
			item.width = 30;
			item.height = 20;
			item.accessory = true;
			item.toolTip = "16% increased movement speed";
			item.rare = 2;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.moveSpeed += .16f;
		}
	}
}