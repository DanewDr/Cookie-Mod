using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class MoltenChocolate : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Molten Chocolate";
			item.maxStack = 999;
			item.toolTip = "It burns with the heat of Hell.";
			item.rare = 3;
        }
    }
}
