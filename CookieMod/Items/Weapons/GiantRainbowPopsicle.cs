using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class GiantRainbowPopsicle : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Rainbow Popsickle");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {         
            item.damage = 57;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 1f;        
            item.rare = 1;            //mana use
            item.autoReuse = true;
        }   
    }
}
