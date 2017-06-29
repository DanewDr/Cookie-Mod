using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CrunchWoodBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Breastplate");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 4500;
			item.rare = 2;
			item.defense = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrunchWood", 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
