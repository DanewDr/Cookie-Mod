using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchWood : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Crunchwood";
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			AddTooltip("Don't know why you'd think to eat it.");
			item.rare = 2;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("CrunchWoodTile");
		}
	}
}
