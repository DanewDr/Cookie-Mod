using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class CookieRod : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cookie Rod";          
            item.damage = 96;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.toolTip = "Fires a cookie!";
            item.useTime = 32;
            item.useAnimation = 32;
            item.useStyle = 5;        //this is how the item is holded
	    Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 4f;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 13;             //mana use
            item.UseSound = SoundID.Item21;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("FullCookie");  //this make the item shoot 
            item.shootSpeed = 6f;    //projectile speed when shoot
        }      
    }
}