using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CorruptCookie1Trophy : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Corrupt Cookie Trophy";
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;			
			item.rare = 2;
			item.createTile = mod.TileType("CorruptCookie1Trophey");
			item.placeStyle = 0;
		}
	}
}