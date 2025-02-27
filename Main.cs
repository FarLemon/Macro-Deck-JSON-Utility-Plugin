namespace FarLemon.JsonUtilityPlugin
{
    using System.Collections.Generic;
    using SuchByte.MacroDeck.Plugins;
    using FarLemon.JsonUtilityPlugin.Actions;


    public class Main : MacroDeckPlugin
    {
        // Silences recommendation
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0028:Simplify collection initialization", Justification = "<Pending>")]


        // Called when plugin is loaded
        public override void Enable()
        {
            // Adds instances of actions
            this.Actions = new List<PluginAction>{
                new UpdateJSON(),
            };
        }
    }
}