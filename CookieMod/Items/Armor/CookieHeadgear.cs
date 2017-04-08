using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	public class CookieHeadgear : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Cookie Headgear";
			item.width = 18;
			item.height = 18;
			item.toolTip = "#putyourhelmetonhappy";
			item.value = 2500;
			item.rare = 2;
			item.defense = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CookieBreastplate") && legs.type == mod.ItemType("CookieLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Incresead Ranged Damge";
			player.rangedDamage *= 1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cookie", 25);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}