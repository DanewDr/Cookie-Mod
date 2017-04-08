using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class CremeYoyo : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Creamir";
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.shoot = mod.ProjectileType ("CremeYoyo");
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = .2f;
			item.damage = 40;
			item.value = Item.sellPrice(0, 0, 1, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Flour", 3);
			recipe.AddIngredient(null, "MilkBottle");
			recipe.AddIngredient(null, "CookieDust", 9);
			recipe.AddIngredient(ItemID.WoodYoyo);
			recipe.AddTile(null, "MilkTank");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
