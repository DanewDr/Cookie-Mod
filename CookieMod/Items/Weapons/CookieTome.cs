using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class CookieTome : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cookie Tome";          
            item.damage = 20;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.toolTip = "Fires a Cookie!";
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = 1000;
            item.rare = 2;
            item.mana = 5;             //mana use
            item.UseSound = SoundID.Item21;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType ("CookieTome1");  //this make the item shoot your projectile
            item.shootSpeed = 8f;    //projectile speed when shoot
        } 
		        public override void AddRecipes()  
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(null, "Cookie", 8);
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}