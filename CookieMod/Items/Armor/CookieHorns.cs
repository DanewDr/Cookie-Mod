using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	public class CookieHorns : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Cookie Horns";
			item.width = 18;
			item.height = 18;
			item.toolTip = "#putyourhelmetonhappy";
			item.value = 2500;
			item.rare = 2;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CookieBreastplate") && legs.type == mod.ItemType("CookieLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Incresead Summon  Damage + max number of minions";
			player.minionDamage *= 1.5f;
			player.maxMinions++;
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