using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs
{
    public class CookieAddict : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Addict");
			Main.npcFrameCount[npc.type] = 5; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.width = 42;
            npc.height = 67;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 200;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath13;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 3;
            Main.npcFrameCount[npc.type] = 5; 
            aiType = NPCID.Zombie;  //npc behavior
            animationType = NPCID.Zombie;
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.5F; // Determines the animation speed. Higher value = faster animation.
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;

            npc.spriteDirection = npc.direction;
        }
		 public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)          //this make so when the npc has 0 life(dead) he will spawn this
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict1"), 1f);   //make sure you put the right folder name where your gores is located and the right name of gores
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict2"), 1f);     // 1f is the gore sprite size, you can change it but i suggest to keep it to 1f
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict3"), 1f);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Addict4"), 1f);
            }
        }
		 public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return Main.dayTime && Main.tile[(spawnInfo.spawnTileX), (spawnInfo.spawnTileY)].type == mod.TileType("CookieDirtTile") ? 5000f : 0f; //100f is the spown rate so If you want your NPC to be rarer just change that value less the 100f or something.
			return !Main.dayTime && Main.tile[(spawnInfo.spawnTileX), (spawnInfo.spawnTileY)].type == mod.TileType("CookieDirtTile") ? 10000f : 0f;
		}      //Main.dayTime is day time, !Main.dayTime is night time   |||     Main.tile[(spawnInfo.spawnTileX), (spawnInfo.spawnTileY)].type == mod.TileType("CustomTileBlock") make the npc spawn only on this block/tile, make sure u add the tile that your using for the biome
        public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DoughBall"), 2); //Item spawn
            }

        }
    }
}
