using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items 
{
	public class ChocolatePickaxe : ModItem
	{	
		public override void SetDefaults()
		{
			item.name = "Chocolate Pickaxe";
			item.damage = 9;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 9;
			item.useAnimation = 15;
			item.pick = 65;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1200;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cookie", 12);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}