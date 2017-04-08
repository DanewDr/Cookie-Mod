using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class VanillaSwirl : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.name = "Vanilla Swirl";
			aiType = ProjectileID.NightBeam;
			projectile.melee = true;
			projectile.friendly = true;
		}


        }
 }