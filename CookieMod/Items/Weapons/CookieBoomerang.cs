using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{
    public class CookieBoomerang : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cookie Boomerang";
            item.damage = 13;            
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 14;
            item.useAnimation = 25;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 8;
            item.rare = 6;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType ("CookieBoomerang");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
        public override void AddRecipes()
        {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.DirtBlock, 1);
                recipe.SetResult(this);
                recipe.AddRecipe();
        }
    }
}