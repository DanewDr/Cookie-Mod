using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class SugarSharkFin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Shark Fin");
			Tooltip.SetDefault("This is shark cruelty");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.damage = 3;
			item.knockBack = 4f;
			item.rare = 2;
			item.consumable = true;
			item.ammo = item.type;
		}
	}
}
