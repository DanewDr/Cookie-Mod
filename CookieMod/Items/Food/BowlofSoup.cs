using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Food
{
	public class BowlofSoup : CookClass
	{
		public override void SafeSetDefaults(Item item)
		{
			if (item.type == ItemID.BowlofSoup)
			{
				    item.width = 22;
			      item.height = 14;
      			item.damage = 16
      			item.crit = 4
      			item.useSound = SoundID.Item3;
			      item.maxStack = 30;
			      item.rare = 1;
			      item.consumable = true;
      			item.value = 400;
			}
		}
	}
}
