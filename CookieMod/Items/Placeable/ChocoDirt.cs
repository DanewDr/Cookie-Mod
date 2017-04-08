using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class ChocoDirt : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Chocolate Dirt";
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			AddTooltip("You still shouldn't eat it.");
			item.rare = 2;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("ChocoDirt");
		}
	}
}