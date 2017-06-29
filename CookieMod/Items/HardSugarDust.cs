using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class HardSugarDust : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rock Candy");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 99;
			item.rare = 3;
		}
	}
}
