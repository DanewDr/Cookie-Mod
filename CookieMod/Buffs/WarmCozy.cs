using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class WarmCozy : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffName[this.Type] = "Warm and Cozy";
            Main.buffTip[this.Type] = "Increased defence but decreased damgae";
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("Calcium"), 1); //this is an example of how to add your own buff
            player.statDefense += 5;  //
      			player.meleeDamage = 0.5f;
				    player.thrownDamage = 0.5f;
				    player.rangedDamage = 0.5f;
				    player.magicDamage = 0.5f;
				    player.minionDamage = 0.5f;
        }
    }
}
