using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class ChocolateBall : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Ball");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			aiType = ProjectileID.Bullet;
			projectile.CloneDefaults(ProjectileID.Bullet);
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.penetrate = 1;
			projectile.width = 8;
			projectile.height = 4;
			projectile.extraUpdates = 1;
		}
		public override void AI()
		{
			projectile.velocity.Y += projectile.ai[0];
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("ChocolateCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}

    }
 }
