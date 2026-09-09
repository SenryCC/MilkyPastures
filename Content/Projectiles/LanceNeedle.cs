using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilkyPasture.Content.Projectiles
{
		public class LanceNeedle : ModProjectile
	{
		public override void SetDefaults() {
			// The width and height don't really matter here because we have custom collision.
			Projectile.width = 16;
			Projectile.height = 16;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Melee;
			Projectile.penetrate = 3; // The projectile can hit 3 enemies.
			Projectile.usesLocalNPCImmunity = true;
			Projectile.localNPCHitCooldown = -1;
			Projectile.tileCollide = false;
			Projectile.ignoreWater = true;
			Projectile.ownerHitCheck = true; // A line of sight check so the projectile can't deal damage through tiles.
			Projectile.ownerHitCheckDistance = 300f; // The maximum range that the projectile can hit a target. 300 pixels is 18.75 tiles.
			Projectile.usesOwnerMeleeHitCD = true; // This will make the projectile apply the standard number of immunity frames as normal melee attacks.
			// Normally, projectiles die after they have hit all the enemies they can.
			// But, for this case, we want the projectile to continue to live so we can have the visuals of the swing.
			Projectile.stopsDealingDamageAfterPenetrateHits = true;
		}
	}
}