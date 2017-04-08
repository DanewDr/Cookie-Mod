using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class ChocolateBottle : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.HealingPotion);
            item.name = "Chocolate Milk";
        }
    }
}