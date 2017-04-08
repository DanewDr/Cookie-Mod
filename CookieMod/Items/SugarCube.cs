using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class SugarCube : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sugar Cube";
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.toolTip = "Yummy!";
			item.rare = 2;
			
		}
	}
}