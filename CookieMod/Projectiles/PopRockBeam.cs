using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class PopRockBeam : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pop Rock");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			aiType = ProjectileID.MiniSharkron;
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.penetrate = 1;
			projectile.width = 30;
			projectile.height = 20;
			projectile.extraUpdates = 1;
		}
        	public override void AI()
        	{            
              		projectile.ai[0] += 1f;
            		if (projectile.ai[0] >= 75f)       //how much time the projectile can travel before landing
          		{
               			projectile.velocity.Y = projectile.velocity.Y + 0.05f;    // projectile fall velocity
                		projectile.velocity.X = projectile.velocity.X * 1f;    // projectile velocity
            		}
        	}


        }
 }

