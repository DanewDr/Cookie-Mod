
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class FoodPoisoning : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
 			DisplayName.SetDefault("Food Poisoning");
			Description.SetDefault("You feel you're dying!");
            Main.debuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("FoodPoisoning"), 1); //this is an example of how to add your own buff
            player.lifeRegen -= 6;
            player.stinky = true;
        }
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.AddBuff(mod.BuffType("FoodPoisoning"), 1);
		  npc.lifeRegen -= 3;
		}		
    }
}
