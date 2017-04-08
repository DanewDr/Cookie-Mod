using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class GingerRoot : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Ginger Root";
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.rare = 3;
			item.toolTip = "Mmmh.";
		}
	}
}