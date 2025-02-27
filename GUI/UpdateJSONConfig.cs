using SuchByte.MacroDeck.GUI.CustomControls;
using Newtonsoft.Json.Linq;
using FarLemon.JsonUtilityPlugin.Actions;

namespace FarLemon.JsonUtilityPlugin.GUI
{
    public partial class UpdateJSONConfig : ActionConfigControl
    {
        // Variable for instance of action
        private readonly UpdateJSON _pluginAction;


        // Initializes component
        public UpdateJSONConfig(UpdateJSON pluginAction)
        {
            _pluginAction = pluginAction;

            InitializeComponent();

            // Populates text fields
            if (!String.IsNullOrEmpty(pluginAction.Configuration))
            {
                JObject configuration = JObject.Parse(pluginAction.Configuration);
                textBoxFile_1_Path.Text = (string)configuration["file_1_path"]!;
                textBoxJSON.Text = (string)configuration["JSON"]!;
            }
        }


        // Called when saved
        public override bool OnActionSave()
        {
            JObject configuration = new()
            {
                { "file_1_path", textBoxFile_1_Path.Text },
                { "JSON", textBoxJSON.Text }
            };

            _pluginAction.Configuration = configuration.ToString();

            return true;
        }


        // Called on "Browse" button press
        private void ButtonFile_Click(object sender, EventArgs e)
        {
            // Open file select prompt
            var fileDialog = new System.Windows.Forms.OpenFileDialog();

            // If file select successful
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Save directory to file directory text box
                string fileToOpen = fileDialog.FileName;
                textBoxFile_1_Path.Text = fileToOpen;
            }
        }
    }
}
