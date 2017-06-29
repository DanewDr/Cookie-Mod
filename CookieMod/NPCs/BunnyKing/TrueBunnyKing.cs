using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.NPCs.BunnyKing
{
	[AutoloadBossHead]
    public class TrueBunnyKing : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny King");
			Main.npcFrameCount[npc.type] = 16; // make sure to set this for your modnpcs.
		}
        public override void SetDefaults()
        {
            npc.aiStyle = 26;  //5 is the flying AI
            npc.lifeMax = 5000;   //boss life
            npc.damage = 20;  //boss damage
            npc.defense = 6;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 338;
            npc.height = 170;
            animationType = NPCID.Unicorn;   //this boss will behavior like the DemonEye 
            npc.value = Item.buyPrice(0, 5, 0, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/Crunch");
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/LongCrunch");
            npc.buffImmune[24] = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BunnyKing");
            npc.netAlways = true;
        }
        


		
		public override void BossLoot(ref string name, ref int potionType)
		{
			name = "Bunny King";
		}
		
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;	
			
			if (npc.ai[0] % 600 ==3)
			{
				NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("GoldenBunnyWarrior"));
			}
			npc.ai[1] += 0;	
		}
    }
}
