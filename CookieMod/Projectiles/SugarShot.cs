using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class SugarShot : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			projectile.name = "Sugar Shark";
			aiType = ProjectileID.MiniSharkron;
			projectile.friendly = true;
		}


        }
 }