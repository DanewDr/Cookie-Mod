using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class ChocolateCyclone : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Cyclone");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			aiType = ProjectileID.MiniSharkron;
		}
		public override void AI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("ChocolateCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}

        }
 }
