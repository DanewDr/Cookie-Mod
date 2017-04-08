using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class CookieRapier : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cookie Sword";          
            item.damage = 34;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 6f;        
            item.rare = 3;            //mana use
            item.autoReuse = true;
        }      
    }
}