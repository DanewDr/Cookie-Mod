using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class CelestialBand : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Celestial Band";
			item.width = 30;
			item.height = 20;
			item.accessory = true;
			item.toolTip = "The power of the gods flows through you";
			item.rare = 10;
			item.defense = 6;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.moveSpeed += 2f;
		player.thrownDamage += .25f;
		player.meleeDamage += .25f;
		player.magicDamage += .25f;
		player.rangedDamage += .25f;
		player.meleeSpeed += .5f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpeedBand");
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}