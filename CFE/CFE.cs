using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using System;

namespace CFE
{
    public class CFE : Plugin<Config>
    {
        private static CFE Singleton;
        public static CFE Instance => Singleton;
        public override string Author => "TemmieGamerGuy";
        public override string Name => "CFE";
        public override Version Version => new Version(1, 0, 5);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        private Handlers.Player player;

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            Player.FlippingCoin += player.OnFlippingCoin;
        }

        public void UnregisterEvents()
        {
            Player.FlippingCoin -= player.OnFlippingCoin;
            player = null;
        }

        public override void OnEnabled()
        {
            Singleton = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            Singleton = null;
            base.OnDisabled();
        }
    }
}
