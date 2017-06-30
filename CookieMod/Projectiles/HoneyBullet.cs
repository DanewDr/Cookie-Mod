using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class HoneyBullet : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Bullet");     //The English name of the projectile
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 5;
            projectile.timeLeft = 600;
            projectile.alpha = 0;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
            projectile.CloneDefaults(ProjectileID.Bullet);
        }       
    }
}