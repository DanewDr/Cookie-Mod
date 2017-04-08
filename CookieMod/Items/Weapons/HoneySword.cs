using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons   //where is located
{
    public class HoneySword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Honey Sword";     //Sword name
            item.damage = 28;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 32;              //Sword width
            item.height = 32;             //Sword height
            item.useTime = 29;          //how fast 
            item.useAnimation = 25;     
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 3;      //Sword knockback
            item.value = 1000;        
            item.rare = 2;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = false;   //if it's capable of autoswing.
            item.useTurn = true;  			
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(null, "Cookie", 10);   //you need 1 DirtBlock
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}