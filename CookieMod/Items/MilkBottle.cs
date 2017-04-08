using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class MilkBottle : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BottledHoney);
            item.name = "Milk Bottle";
        }
    }
}