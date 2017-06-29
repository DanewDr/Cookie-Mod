using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class CookieClaymore : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Claymore");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {         
            item.damage = 78;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 6f;        
            item.rare = 2;            //mana use
            item.autoReuse = true;
			item.shoot = mod.ProjectileType ("CookieClaymore");
			item.shootSpeed = 4f;
        }      
    }
}
