using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SugarSharkLauncher : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sugar Shark Launcher";
			item.damage = 31;
			item.ranged = true;
			item.noMelee = true;
			item.width = 34;
			item.height = 22;
			item.toolTip = "Rapidly fires mini sugar sharks.";
			item.toolTip2 = "Uses sugar shark fins as ammo";
			item.rare = 2;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("SugarShark");
			item.shootSpeed = 6f;
			item.useAmmo = mod.ItemType("SugarSharkFin");
		}


	}
}
