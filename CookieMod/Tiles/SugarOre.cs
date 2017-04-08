using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Tiles
{
	public class SugarOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("SugarCube");
			AddMapEntry(new Color(192, 192, 192));
			minPick = 70;
		}

	}
}