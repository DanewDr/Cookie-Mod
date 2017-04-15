using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.player[Main.myPlayer].ZoneDungeon)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
                {
                    if (Main.rand.Next(9) == 0)      //this is the item rarity, so 9 = 1 in 10 chance that the npc will drop the item.
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GingerRoot"), Main.rand.Next(5, 10));//this is where you set what item to drop ,ItemID.VileMushroom is an example of how to add vanila items , Main.rand.Next(5, 10) it's the quantity,so it will chose a number from 5 to 10
                    }
                }
            }
            if (Main.player[Main.myPlayer].ZoneUnderworld
                {
                    if (Main.rand.Next(9) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MoltenChocolate"), Mian.rand.Next(5, 15));
                    }
                }
            }
            if (npc.type == NPCID.QueenBee)   
            {
                if (Main.rand.Next(1) == 0) 
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SugarCube"), Main.rand.Next(25, 40));
                    }
                }
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
