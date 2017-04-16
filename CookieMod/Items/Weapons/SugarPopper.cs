using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SugarPopper : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sugar Popper";
			item.damage = 20;
			item.melee = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 5;
			item.knockBack = 4;
			item.rare = 3;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.shootSpeed = 5f;
     			item.useAmmo = AmmoID.Arrow;
			item.channel = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HardSugarDust", 15);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.shoot = ProjectileID.Bullet;
        item.useAmmo = AmmoID.Bullet;
			}
			else
			{
        item.shoot = ProjectileID.WoodenArrowFriendly;
        item.useAmmo = AmmoID.Arrow;
			}
			return base.CanUseItem(player);
		}
	}
}
