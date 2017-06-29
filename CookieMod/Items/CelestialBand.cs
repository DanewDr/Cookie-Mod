using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class CelestialBand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminite Band");
			Tooltip.SetDefault("The power of the gods flows through you");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.accessory = true;
			item.rare = 10;
			item.defense = 4;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.moveSpeed *= 2f;
		player.thrownDamage += .25f;
		player.meleeDamage += .25f;
		player.magicDamage += .25f;
		player.rangedDamage += .25f;
		player.meleeSpeed += .10f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpeedBand");
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.LunarOre);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
