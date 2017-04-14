using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class SugarWand : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Sugar Wand";          
            item.damage = 11;                        
            item.magic = true;                     //this make the item do magic 
            item.width = 24;
            item.height = 28;
            item.toolTip = "Fires a blast of pure sugar energy!";
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
	    Item.staff[item.type] = true;
            item.noMelee = true;
            item.knockBack = 2f;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 9;             //mana use
            item.UseSound = SoundID.Item21;            //this is the 
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("SugarBeam");  //this make the item shoot 
            item.shootSpeed = 6f;    //projectile speed when shoot
        }      
    }
}
