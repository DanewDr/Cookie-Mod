using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SugarBlaster : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sugar Blaster";
			item.damage = 15;
			item.ranged = true;
			item.noMelee = true;
			item.width = 34;
			item.height = 22;
			item.toolTip = "Fires sugar at your enemies.";
			item.rare = 2;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.autoReuse = true;
			item.shoot = 166;
			item.shootSpeed = 4f;
			item.useAmmo = AmmoID.Snowball;	//Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}


	}
}