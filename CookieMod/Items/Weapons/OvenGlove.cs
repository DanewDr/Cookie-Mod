using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Items.Weapons
{
	public class ExampleDualUseWeapon : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Oven Mitten";
			item.damage = 12;
			item.melee = true;
			item.width = 24;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 6.5f;
      item.noUseGraphic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.Loom);
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
        item.useAmmo = mod.ItemType("HotChocolate");
				item.shoot = mod.ProjectileType("HotChocolate");
			}
			else
			{
				item.shoot = 0;
        item.useAmmo = 0;
			}
			return base.CanUseItem(player);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if (player.altFunctionUse == 2)
			{
			}
			else
			{
				target.AddBuff(BuffID.Frostburn, 3);
			}
		}
	}
}
