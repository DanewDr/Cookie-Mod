using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class Honeyed : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffName[this.Type] = "Honied";
            Main.buffTip[this.Type] = "Decreases movementspeed";
            Main.debuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("Honyed"), 1); //this is an example of how to add your own buff
            player.moveSpeed -= 0.50f;;  //
        }
    }
}
