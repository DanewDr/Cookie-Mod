using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class CookieDust : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cookie Dust";
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.rare = 3;
		}
	}
}