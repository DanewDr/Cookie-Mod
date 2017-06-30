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
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie");     //The English name of the projectile
			ProjectileID.Sets.Homing[projectile.type] = true;
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			aiType = ProjectileID.MiniSharkron;
			projectile.penetrate = -1;
			projectile.friendly = true;
		}


        }
 }
