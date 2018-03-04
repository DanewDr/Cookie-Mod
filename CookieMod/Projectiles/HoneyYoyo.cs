using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class HoneyYoyo : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Yoyo");     //The English name of the projectile
		}
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodYoyo);
            projectile.penetrate = 5;  
            projectile.width = 22;
            projectile.height = 22;
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 4.5f;
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 250f;			
        }
        
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
           
            if (projectile.ai[0] > 30)
            {
                projectile.timeLeft = 50;
            }
            

        }

    }
}
