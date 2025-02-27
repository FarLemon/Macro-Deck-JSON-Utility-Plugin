using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using Newtonsoft.Json.Linq;

namespace FarLemon.JsonUtilityPlugin.Actions
{
    public class UpdateJSON : PluginAction
    {
        public override string Name => "Update JSON File";
        public override string Description => "Merges the JSON file and input JSON (Adding new keys and updating existing ones)";


        // Configuration
        public override bool CanConfigure => true;
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new GUI.UpdateJSONConfig(this);
        }


        // Primary call function
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            // Error handling
            try
            {
                if (!string.IsNullOrWhiteSpace(Configuration))
                {
                    // Parses inputs into JObjects
                    JObject configuration = JObject.Parse(Configuration);
                    JObject file1Path = JObject.Parse(File.ReadAllText((string)configuration["file_1_path"]!));

                    // Merges JObjects (Adds new keys and updates existing ones)
                    file1Path.Merge(JObject.Parse((string)configuration["JSON"]!), new JsonMergeSettings
                    {
                        MergeArrayHandling = MergeArrayHandling.Union,
                        MergeNullValueHandling = MergeNullValueHandling.Ignore
                    });

                    // Output updated JSON to file
                    File.WriteAllText((string)configuration["file_1_path"]!, file1Path.ToString());
                }
            }
            // Called if error
            catch (Exception err)
            {
                Console.WriteLine("Exception: " + err.Message);
            }
        }
    }
}
