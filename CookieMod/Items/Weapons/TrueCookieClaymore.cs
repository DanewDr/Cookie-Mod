using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class TrueCookieClaymore : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "True Cookie Claymore";          
            item.damage = 98;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 6f;        
            item.rare = 2;            //mana use
            item.autoReuse = true;
	    item.shoot = mod.ProjectileType ("CookieClaymore");
	    item.shootSpeed = 6f;
        }      
    }
}