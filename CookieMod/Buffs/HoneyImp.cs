using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Buffs
{
	public class HoneyImp : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Honey Imp";
			Main.buffTip[Type] = "Here to slow your foes";
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("HoneyImp")] > 0)
			{
				modPlayer.ChocMin = true;
			}
			if (!modPlayer.ChocMin)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}