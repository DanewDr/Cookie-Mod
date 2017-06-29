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
 			DisplayName.SetDefault("Honeyed");
			Description.SetDefault("Your speed is slowed");
            Main.debuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("Honeyed"), 1); //this is an example of how to add your own buff
            player.moveSpeed -= 0.50f;;  //
        }
    }
}
