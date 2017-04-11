using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CookieMod.Items.Armor
{
	public class CrunchWoodLeggings : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Legs);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Crunch Leggings";
			item.width = 18;
			item.height = 18;
			AddTooltip("");
			AddTooltip2("");
			item.value = 35;
			item.rare = 2;
			item.defense = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrunchWood", 25);
			recipe.AddTile(TileID.Workbenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
