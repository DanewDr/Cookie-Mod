using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
 
namespace CookieMod.Projectiles
{
    public class HotChocolate : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hot Chocolate");     //The English name of the projectile
		}
        public override void SetDefaults()
        {
        projectile.width = 14;
        projectile.height = 14;
        projectile.aiStyle = 68;
        projectile.friendly = true;
        projectile.penetrate = 1;
        projectile.alpha = (int) byte.MaxValue;
        projectile.thrown = true;
        projectile.noEnchantments = true;
	}
    }
}
