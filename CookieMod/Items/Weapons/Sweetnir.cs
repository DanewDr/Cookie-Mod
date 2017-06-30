using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class Sweetnir : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sweetnir");
			Tooltip.SetDefault("All the sugar in the world combined into a single sword.");
		}
        public override void SetDefaults()
        {
            item.damage = 110;                        
            item.melee = true;                     
            item.width = 58;
            item.height = 58;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 1;        
            item.knockBack = 4f;        
            item.value = 1000;
            item.rare = 5;            
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("SuperSwirl");  //this make the item shoot 
            item.shootSpeed = 12f;    //projectile speed when shoot
        }      
    }
}
