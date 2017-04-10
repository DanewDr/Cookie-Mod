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
            player.AddBuff(mod.BuffType("WarmCozy"), 1); //this is an example of how to add your own buff
            player.statDefense += 6;  //
      	    player.meleeDamage -= .10f;
	    player.meleeSpeed -= .10f;
        }
    }
}
