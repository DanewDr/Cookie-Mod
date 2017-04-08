using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class HoneyHammer : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Honey Hammer";
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "This is a modded hammer";
			item.useTime = 15;
			item.useAnimation = 15;
			item.hammer = 100;		//How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HoneyCookie", 10);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
