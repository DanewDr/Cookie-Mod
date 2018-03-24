using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class Pancake : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pancake");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			aiType = ProjectileID.WoodenArrowFriendly;
			projectile.CloneDefaults(ProjectileID.WoodenArrowFriendly);
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
            		if (projectile.ai[0] >= 75f)
          		{
               			projectile.velocity.Y = projectile.velocity.Y + 0.05f;
                		projectile.velocity.X = projectile.velocity.X * 1f;
            		}
        	}


        }
 }
