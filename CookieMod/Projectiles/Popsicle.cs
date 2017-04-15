﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class Popsicle : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.name = "Popsicle";
			aiType = ProjectileID.MusketBall;
			projectile.CloneDefaults(ProjectileID.MusketBall);
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.penetrate = 1;
			projectile.width = 8;
			projectile.height = 4;
			projectile.extraUpdates = 1;
		}
        }
 }
