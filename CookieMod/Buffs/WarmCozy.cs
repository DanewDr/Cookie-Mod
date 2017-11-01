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
 			DisplayName.SetDefault("Warm and Cozy");
			Description.SetDefault("Decreased melee abilities, increased defense");
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("WarmCozy"), 1); //this is an example of how to add your own buff
            player.statDefense += 8;  //
      	    player.meleeDamage -= .14f;
	    player.meleeSpeed -= .07f;
        }
    }
}
