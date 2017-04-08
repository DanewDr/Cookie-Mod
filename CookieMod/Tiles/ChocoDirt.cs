using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
 
namespace CookieMod.Tiles
{
    public class ChocoDirt : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileBlockLight[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;      
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("ChocoDirt");   //this is what will drop when this block is destroyed.
            AddMapEntry(new Color(0, 0, 200));      
            soundType = 19;
            soundStyle = 2;
	    minPick = 70;
            SetModTree(new SugarTree());  //this make the tree spawn on this block/tile.  change CustomTreeTile with u'r tree name
        }
        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("SugarSapling");        //this make the spaling spawn the custom tree/sapling on this block/tile.    change CustomSaplingTile with u'r sapling name
        }
    }
}