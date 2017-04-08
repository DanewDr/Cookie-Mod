using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons
{  
    public class MinionS : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cookie Staff";
            item.damage = 14;
            item.summon = true;
            item.mana = 10;
            item.width = 26;
            item.height = 28;
            item.toolTip = "Summons, umm, something, to fight for you!";
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item44;
            item.shoot = mod.ProjectileType("CookieMinion");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
			item.buffType = mod.BuffType("MinionBuff");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cookie", 10);
            recipe.SetResult(this);
			recipe.AddTile(null, "CookieWorkbench"); 
            recipe.AddRecipe();
        }
    }
}