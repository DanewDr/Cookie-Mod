using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class SugarWater : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Water");
			Tooltip.SetDefault("");
		}
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LesserHealingPotion);
        }
    }
}
