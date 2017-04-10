using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
 
namespace CookieMod.Items
{
    public class HotChocolate : ModItem
    {
        public override void SetDefaults()
        {
        this.name = "Hot Chocolate";
        this.width = 14;
        this.height = 14;
        this.aiStyle = 68;
        this.friendly = true;
        this.penetrate = 1;
        this.alpha = (int) byte.MaxValue;
        this.thrown = true;
        this.noEnchantments = true;
	}
    }
}
