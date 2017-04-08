using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class CookieGlove : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cookie Tosser";
			item.damage = 18;
			item.thrown = true;
			item.noMelee = true;
			item.width = 34;
			item.height = 22;
			item.toolTip = "Throws hard cookies.";
			item.rare = 2;
			item.useTime = 25;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.autoReuse = false;
			item.shoot = mod.ProjectileType ("ThrowingCookie");
			item.shootSpeed = 6f;
			item.useAmmo = mod.ItemType("HardCookie");	//Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
			item.noUseGraphic = true;
		}


	}
}