using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CookieMod.Items.Weapons
{
	public class HoneySceptor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Sceptor");
			Tooltip.SetDefault("Shoots a beam of honey to slow your foes");
		}
		public override void SetDefaults()
		{
			item.damage = 4;
			item.noMelee = true;
			item.magic = true;
			item.channel = true;                            //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 2;
			item.shootSpeed = 14f;				//Speed is not important here
			item.useAnimation = 20;                         
			item.shoot = mod.ProjectileType("HoneyStream");
			item.value = Item.sellPrice(0, 3, 0, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HoneyCookie", 10);
			recipe.AddTile(mod, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
