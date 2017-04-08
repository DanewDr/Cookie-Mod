using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class GingerTome : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ginger Tome";          
            item.damage = 27;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.toolTip = "Fires a ball of ginger";
            item.useTime = 16;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 7.5f;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 10;             //mana use
            item.UseSound = SoundID.Item21;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("GingerBlob");  //this make the item shoot your projectile
            item.shootSpeed = 6f;    //projectile speed when shoot
        } 
		        public override void AddRecipes()  
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(null, "GingerCookie", 8);
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}