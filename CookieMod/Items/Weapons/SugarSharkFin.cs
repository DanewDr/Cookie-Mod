using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SugarSharkFin : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Sugar Shark Fin";
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.damage = 3;
			item.knockBack = 4f;
			item.toolTip = "This is shark cruelty";
			item.rare = 2;
			item.consumable = true;
			item.ammo = item.type;
		}
	}
}