using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class Dorpan : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			projectile.name = "Dorpan";
			aiType = ProjectileID.MiniSharkron;
			projectile.friendly = true;
		}


        }
 }