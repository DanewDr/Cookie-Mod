using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class SugarSword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Sugar Sword";          
            item.damage = 11;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 1f;        
            item.rare = 3;            //mana use
            item.autoReuse = true;
        }      
    }
}