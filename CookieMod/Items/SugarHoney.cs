using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class SugarHoney : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Artificial Honey");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.HealingPotion);
        }
    }
}
