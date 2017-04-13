using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons   //where is located
{
    public class DoughSword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dough Blade";     //Sword name
            item.damage = 9;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 30;              //Sword width
            item.height = 30;             //Sword height
            item.toolTip = "Dough rolled onto a wooden sword.";  //Item Description
            item.useTime = 24;          //how fast 
            item.useAnimation = 24;     
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 0;      //Sword knockback       
            item.rare = 1;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = false;   //if it's capable of autoswing.  			
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(null, "DoughBall", 10);
            recipe.AddIngredient(ItemID.WoodenSword);//you need 1 DirtBlock
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }	
    }
}