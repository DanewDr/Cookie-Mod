using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class SpeedBand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Speed Band");
			Tooltip.SetDefault("16% increased movement speed");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.accessory = true;
			item.rare = 2;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.moveSpeed += .16f;
		}
	}
}
