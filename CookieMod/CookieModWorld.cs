using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;
 
 
namespace CookieMod
{
    public class CookieModWorld : ModWorld
    {
		public static bool downedCookieBoss = false;		
		public override void Initialize()
		{
			downedCookieBoss = false;
		}			
		public static int customBiome = 0;
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (genIndex == -1)
            {
                return;
            }
            tasks.Insert(genIndex + 1, new PassLegacy("Cookie Biome", delegate (GenerationProgress progress)
            {
                progress.Message = "Adding some cookie-fied dirt";
                for (int i = 0; i < Main.maxTilesX / 2600; i++)       //900 is how many biomes. the bigger is the number = less biomes
                {
                    int X = WorldGen.genRand.Next(Main.maxTilesX);
                    int Y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh + 125);//this make the biome spawn on surface.
                    int TileType = mod.TileType("CookieDirtTile");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block
 
                    WorldGen.TileRunner(X, Y, 550, WorldGen.genRand.Next(100, 300), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.
                }
 
            }));
        }
		public override void TileCountsAvailable(int[] tileCounts)
        {
            customBiome = tileCounts[mod.TileType("CookieDirtTile")];       //this make the public static int customBiome counts as customtileblock
        }
        public static bool spawnSugar = false;
        public static bool spawnCookie = false;
    }
}
