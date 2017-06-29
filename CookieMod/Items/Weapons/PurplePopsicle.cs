using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class PurplePopsicle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Popsicle");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 2;
			item.consumable = true;
			item.damage = 36;
			item.shoot = mod.ProjectileType ("PurplePopsicle");
			item.ammo = mod.ItemType("Popsicle");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Popsicle", 150);
			recipe.AddIngredient(ItemID.Ichor);
			recipe.SetResult(this, 150);
			recipe.AddRecipe();
		}
	}
}
