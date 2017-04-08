using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class FullCookie : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			projectile.name = "Cookie";
			aiType = ProjectileID.MiniSharkron;
			ProjectileID.Sets.Homing[projectile.type] = true;
			projectile.penetrate = -1;
			projectile.friendly = true;
		}


        }
 }