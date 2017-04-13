using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

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
