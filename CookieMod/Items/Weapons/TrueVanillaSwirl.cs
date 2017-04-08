using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class TrueVanillaSwirl : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "True Vanilla Swirl";          
            item.damage = 92;                        
            item.melee = true;                     
            item.width = 58;
            item.height = 58;
            item.useTime = 26;
            item.useAnimation = 24;
            item.useStyle = 1;        
            item.knockBack = 4;        
            item.value = 1000;
            item.rare = 5;            
            item.autoReuse = false;
            item.shoot = mod.ProjectileType ("VanillaSwirl");  //this make the item shoot 
            item.shootSpeed = 7f;    //projectile speed when shoot
        }      
    }
}