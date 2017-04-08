using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class CookiePistol : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cookie Pistol";
			item.toolTip = "33% not to consume ammo";
			item.damage = 8;
			item.ranged = true;
			item.noMelee = true;
			item.width = 34;
			item.height = 22;
			item.rare = 2;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.autoReuse = true;
			item.shoot = ProjectileID.Bullet;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;	//Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() > .33f;
		}


	}
}