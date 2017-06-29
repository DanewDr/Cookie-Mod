using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CookieMonster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Lover");
			Tooltip.SetDefault("Nom nom");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 6);
			recipe.AddTile(null, "MilkTank");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
