using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class VanillaSwirl : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Vanilla Swirl";          
            item.damage = 48;                        
            item.melee = true;                     //this make the item do magic 
            item.width = 28;
            item.height = 28;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 1;        //this is how the item is holded
            item.knockBack = 4f;        
            item.rare = 2;            //mana use
            item.autoReuse = true;
        }      
    }
}