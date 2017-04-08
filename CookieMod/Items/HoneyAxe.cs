using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class HoneyAxe : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Honey Axe";
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "This is a modded axe.";
			item.useTime = 10;
			item.useAnimation = 10;
			item.axe = 30;	//x5 is displayed
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