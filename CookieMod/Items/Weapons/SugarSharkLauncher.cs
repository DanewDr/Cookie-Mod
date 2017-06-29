using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SugarSharkLauncher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugarshark");
			Tooltip.SetDefault("Rapidly fires mini sugar sharks.\nUses sugar shark fins as ammo");
		}
		public override void SetDefaults()
		{
			item.damage = 31;
			item.ranged = true;
			item.noMelee = true;
			item.width = 34;
			item.height = 22;
			item.rare = 2;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("SugarShark");
			item.shootSpeed = 13f;
			item.useAmmo = mod.ItemType("SugarSharkFin");
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() > .50f;
		}

	}
}
