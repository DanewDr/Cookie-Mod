using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            if (npc.type == NPCID.QueenBee) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!CookieModWorld.spawnSugar)
                {                                                          //Red  Green Blue
                    Main.NewText("Sugar has been released into the world!", 255, 255, 0);  //this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 60E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("SugarOre"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                    }
                }
                CookieModWorld.spawnSugar = true;   //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.Bunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
           if (npc.type == NPCID.BunnySlimed)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == NPCID.BunnyXmas)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == NPCID.GoldBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(10, 50));
                    }
                }
            }
            if (npc.type == NPCID.CrimsonBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == NPCID.PartyBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(5, 10));
                    }
                }
            }
            if (npc.type == NPCID.CorruptBunny)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(1) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnyFur"), Main.rand.Next(5, 10));
                    }
                }
            }
        }
    }
}
