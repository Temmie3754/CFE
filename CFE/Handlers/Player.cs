using Exiled.API.Features.Items;
using Exiled.Events.EventArgs;
using MEC;

namespace CFE.Handlers
{
    class Player
    {
        public void OnFlippingCoin(FlippingCoinEventArgs ev)
        {
            if (!ev.IsTails) 
            {
                Timing.CallDelayed(1.83f, () =>
                {
                    new ExplosiveGrenade(ItemType.GrenadeHE, ev.Player) { FuseTime = 0.01f }.SpawnActive(ev.Player.Position, ev.Player);
                });
            }
        }
    }
}
