using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Buffs
{
    public class Calcium : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffName[this.Type] = "Calcium";
            Main.buffTip[this.Type] = "The Calcium from the milk increases your defence by 10!";
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("Calcium"), 1); //this is an example of how to add your own buff
            player.statDefense += 10;  //
        }
    }
}