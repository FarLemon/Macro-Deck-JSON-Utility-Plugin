namespace FarLemon.JsonUtilityPlugin.GUI
{
    partial class UpdateJSONConfig
    {
        private System.ComponentModel.IContainer components = null;


        // Cleanup used resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            labelFile_1_Path = new Label();
            textBoxFile_1_Path = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            buttonFile_1_Path = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            labelJSON = new Label();
            textBoxJSON = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            SuspendLayout();
            // 
            // labelFile_1_Path
            // 
            labelFile_1_Path.AutoSize = true;
            labelFile_1_Path.ForeColor = Color.FromArgb(244, 242, 227);
            labelFile_1_Path.Location = new Point(10, 10);
            labelFile_1_Path.Name = "labelFile_1_Path";
            labelFile_1_Path.Padding = new Padding(0, 3, 0, 4);
            labelFile_1_Path.Size = new Size(85, 30);
            labelFile_1_Path.TabIndex = 0;
            labelFile_1_Path.Text = "Directory";
            labelFile_1_Path.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFile_1_Path
            // 
            textBoxFile_1_Path.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxFile_1_Path.BackColor = Color.FromArgb(65, 65, 65);
            textBoxFile_1_Path.Font = new Font("Arial", 8F, FontStyle.Italic);
            textBoxFile_1_Path.ForeColor = Color.FromArgb(244, 242, 227);
            textBoxFile_1_Path.Icon = null;
            textBoxFile_1_Path.Location = new Point(100, 10);
            textBoxFile_1_Path.Margin = new Padding(0);
            textBoxFile_1_Path.MaxCharacters = 32767;
            textBoxFile_1_Path.Multiline = false;
            textBoxFile_1_Path.Name = "textBoxFile_1_Path";
            textBoxFile_1_Path.Padding = new Padding(8);
            textBoxFile_1_Path.PasswordChar = false;
            textBoxFile_1_Path.PlaceHolderColor = Color.Gray;
            textBoxFile_1_Path.PlaceHolderText = "File Directory";
            textBoxFile_1_Path.ReadOnly = false;
            textBoxFile_1_Path.ScrollBars = ScrollBars.None;
            textBoxFile_1_Path.SelectionStart = 0;
            textBoxFile_1_Path.Size = new Size(510, 31);
            textBoxFile_1_Path.TabIndex = 0;
            textBoxFile_1_Path.TextAlignment = HorizontalAlignment.Left;
            // 
            // buttonFile_1_Path
            // 
            buttonFile_1_Path.AutoSize = true;
            buttonFile_1_Path.BorderRadius = 8;
            buttonFile_1_Path.Cursor = Cursors.Hand;
            buttonFile_1_Path.FlatAppearance.BorderSize = 0;
            buttonFile_1_Path.FlatStyle = FlatStyle.Flat;
            buttonFile_1_Path.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonFile_1_Path.BackColor = Color.FromArgb(90, 185, 126);
            buttonFile_1_Path.ForeColor = Color.FromArgb(244, 242, 227);
            buttonFile_1_Path.HoverColor = Color.FromArgb(90, 185, 126);
            buttonFile_1_Path.Icon = null;
            buttonFile_1_Path.Location = new Point(620, 10);
            buttonFile_1_Path.Name = "buttonFile_1_Path";
            buttonFile_1_Path.Progress = 0;
            buttonFile_1_Path.ProgressColor = Color.FromArgb(52, 70, 59);
            buttonFile_1_Path.Size = new Size(80, 30);
            buttonFile_1_Path.TabIndex = 2;
            buttonFile_1_Path.Text = "Browse";
            buttonFile_1_Path.UseVisualStyleBackColor = false;
            buttonFile_1_Path.UseWindowsAccentColor = true;
            buttonFile_1_Path.WriteProgress = true;
            buttonFile_1_Path.Click += ButtonFile_Click;
            // 
            // labelJSON
            // 
            labelJSON.AutoSize = true;
            labelJSON.ForeColor = Color.FromArgb(244, 242, 227);
            labelJSON.Location = new Point(10, 50);
            labelJSON.Name = "labelJSON";
            labelJSON.Padding = new Padding(0, 3, 0, 4);
            labelJSON.Size = new Size(55, 30);
            labelJSON.TabIndex = 0;
            labelJSON.Text = "JSON";
            labelJSON.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxJSON
            // 
            textBoxJSON.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxJSON.BackColor = Color.FromArgb(65, 65, 65);
            textBoxJSON.Font = new Font("Arial", 8F);
            textBoxJSON.ForeColor = Color.FromArgb(244, 242, 227);
            textBoxJSON.Icon = null;
            textBoxJSON.Location = new Point(100, 50);
            textBoxJSON.Margin = new Padding(0);
            textBoxJSON.MaxCharacters = 32767;
            textBoxJSON.Multiline = true;
            textBoxJSON.Name = "textBoxJSON";
            textBoxJSON.Padding = new Padding(8);
            textBoxJSON.PasswordChar = false;
            textBoxJSON.PlaceHolderColor = Color.Gray;
            textBoxJSON.PlaceHolderText = "";
            textBoxJSON.ReadOnly = false;
            textBoxJSON.ScrollBars = ScrollBars.Vertical;
            textBoxJSON.SelectionStart = 0;
            textBoxJSON.Size = new Size(600, 350);
            textBoxJSON.TabIndex = 0;
            textBoxJSON.TextAlignment = HorizontalAlignment.Left;
            // 
            // UpdateJSONConfig
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelFile_1_Path);
            Controls.Add(textBoxFile_1_Path);
            Controls.Add(buttonFile_1_Path);
            Controls.Add(labelJSON);
            Controls.Add(textBoxJSON);
            Name = "UpdateJSONConfig";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.Label labelFile_1_Path;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox textBoxFile_1_Path;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonFile_1_Path;
        private System.Windows.Forms.Label labelJSON;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox textBoxJSON;
    }
}
