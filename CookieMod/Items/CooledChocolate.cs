
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
    public class CooledChocolate : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Chocolate";
			      item.maxStack = 99;
			      item.toolTip = "The smell is so delightful.";
			      item.rare = 3;
        }
    }
