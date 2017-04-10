using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Items
{
	public class AleThrowingGlove : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.AleThrowingGlove)
			{
				item.name = "Mug Tosser";		//Changed original CopperShortsword's damage to 50!
			}
		}
	}
}
