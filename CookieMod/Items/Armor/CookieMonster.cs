using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	public class CookieMonster : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Cookie Lover";
			item.width = 18;
			item.height = 18;
			item.toolTip = "Nom nom";
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