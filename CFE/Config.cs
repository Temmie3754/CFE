using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CFE
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool ExplodeOnHeads { get; set; } = true;
    }
}
