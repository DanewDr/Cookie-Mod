using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class Jawbreaker : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Jawbreaker";
            projectile.width = 8;
            projectile.height = 8;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
            projectile.CloneDefaults(ProjectileID.Bullet);
        }       
    }
}
