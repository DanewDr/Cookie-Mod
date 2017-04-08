using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	public class CookieLeggings : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Legs);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Cookie Leggings";
			item.width = 18;
			item.height = 18;
			AddTooltip("Run a little faster");
			AddTooltip2("5% increased movement speed");
			item.value = 35;
			item.rare = 2;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cookie", 35);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}