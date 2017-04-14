using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class ChocolateStave : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Chocolate Stave";
			item.damage = 40;
			item.magic = true;
			item.mana = 13;
			item.width = 40;
			item.height = 40;
			item.toolTip = "100% chocolatey goodness.";
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 3f;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ChocolateBall");
			item.shootSpeed = 6f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChocolateWand");
			recipe.AddIngredient(null, "CookieDust", 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
