using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
	public class Popsicle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Popsicle");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 5;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.rare = 2;
			item.consumable = true;
			item.ammo = item.type;
			item.shoot = mod.ProjectileType ("Popsicle");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock);
			recipe.AddIngredient(ItemID.Wood);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}
