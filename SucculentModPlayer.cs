using SucculentMod.Utilities;
using Terraria.ModLoader;

namespace SucculentMod
{
    public class SucculentModPlayer : ModPlayer
    {
        public float Hungry;

        public override void ResetEffects()
        {
            Hungry = 100f;
        }

        public override void UpdateDead()
        {
            Hungry = 100f;
        }

        public override void PreUpdateBuffs()
        {
            if (Hungry > 75f)
            {
                player.AddBuff(mod.BuffType<Buffs.Satisfied>(), 10);
            }
            else if (Hungry < 15f)
            {
                player.AddBuff(mod.BuffType<Buffs.Empty>(), 10);
            }
        }

        public override void UpdateBadLifeRegen()
        {
            if (Hungry < 15f && player.lifeRegen > 0)
            {
                if (player.lifeRegen.IsEven())
                {
                    player.lifeRegen = player.lifeRegen / 2; 
                }
                else
                {
                    player.lifeRegen = player.lifeRegen + 1 / 2;
                }
            }
        }
    }
}
