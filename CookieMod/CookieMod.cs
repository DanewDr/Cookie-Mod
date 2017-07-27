using System;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using CookieMod.Items;

namespace CookieMod
{
    public class CookieMod : Mod
    {
        public CookieMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
				AutoloadBackgrounds = true
            };
        }
	public override void AddRecipeGroups()
        {
		RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Corrupted Bar", new int[] //Souls is the name of the RecipeGroup
		{
			ItemID.DemoniteBar,
			ItemID.CrimtaneBar,
		});
            RecipeGroup.RegisterGroup("CorruptBar", group);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Cookie");
            recipe.SetResult(null, "CookieDust", 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SpellTome);
            recipe.AddIngredient(null, "Cookie", 15);
            recipe.AddIngredient(null, "CookieDust", 30);
            recipe.SetResult(null, "ChocolateBlast");
            recipe.AddTile(TileID.Bookcases);
            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "SugarDust", 5);
            recipe.SetResult(null, "HardSugarDust", 5);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "SugarCube", 30);
            recipe.AddIngredient(null, "CookieCrumbs", 5);
            recipe.SetResult(null, "SugarBlaster");
            recipe.AddTile(null, "CookieWorkbench");
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "SugarDust", 20);
            recipe.SetResult(null, "SoftSugarball", 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "HardSugarDust", 20);
	    recipe.AddIngredient(null, "SoftSugarball", 15);
            recipe.SetResult(null, "HardSugarball", 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.AddRecipe();
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.SetResult(null, "Milk");
            recipe.AddTile(null, "MilkTank");
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 9);
            recipe.AddIngredient(ItemID.EmptyBucket, 1);
            recipe.SetResult(null, "MilkTank");
            recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "SugarCookie", 6);
            recipe.AddIngredient(null, "Cookie", 1);
            recipe.AddIngredient(ItemID.Diamond);
            recipe.SetResult(null, "SugarWand");
            recipe.AddTile(null, "CookieWorkbench");
            recipe.AddRecipe();
        }
    }
}
