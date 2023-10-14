using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;

namespace ART.Dynamic.Tools
{
    public partial class FormMain : Form
    {
        private List<ScriptInfo> scripts = new List<ScriptInfo>();
        private NotifyIcon trayIcon;
        private string jsonFilePath;
        private bool minimizeToTrayOnClose;

        public FormMain()
        {
            InitializeComponent();

            minimizeToTrayOnClose = bool.Parse(ConfigurationManager.AppSettings["MinimizeToTrayOnClose"]);
            jsonFilePath = ConfigurationManager.AppSettings["JsonFilePath"];

            if (!Directory.Exists(Path.GetDirectoryName(jsonFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath));
            }

            InitializeTrayIcon();
            RefreshScriptList();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (minimizeToTrayOnClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;  // Cancel the form close operation
                this.WindowState = FormWindowState.Minimized;  // Minimize the form
                this.Hide();  // Hide the form (optional, depending on desired behavior)
            }
            else
            {
                // Optionally, you might want to add a confirmation dialog here to prevent accidental closure
                base.OnFormClosing(e);
            }
        }

        private void InitializeTrayIcon()
        {
            notifyIcon.Text = "Script & App Runner";
            notifyIcon.Icon = this.Icon;
            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = GetTrayMenu();

            notifyIcon.DoubleClick += (sender, args) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            };
        }

        private void UpdateTrayMenu()
        {
            notifyIcon.ContextMenuStrip = GetTrayMenu();
        }

        private ContextMenuStrip GetTrayMenu()
        {
            contextMenuStrip.Items.Clear();
            LoadScripts();

            if (scripts != null)
            {
                foreach (var script in scripts)
                {
                    var item = new ToolStripMenuItem(script.Name);
                    item.Click += (sender, e) =>
                    {
                        try
                        {
                            if (script.IsExe && !string.IsNullOrEmpty(script.Arguments))
                                System.Diagnostics.Process.Start(script.Path, script.Arguments);
                            else
                                System.Diagnostics.Process.Start(script.Path);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to run {script.Name}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    contextMenuStrip.Items.Add(item);
                }

                contextMenuStrip.Items.Add(new ToolStripSeparator());
            }

            var configureItem = new ToolStripMenuItem("Configure");
            configureItem.Click += (sender, e) =>
            {
                this.Show();  // Show the main form
                this.WindowState = FormWindowState.Normal;  // Ensure it's not minimized
                this.BringToFront();  // Bring the form to the front
            };
            contextMenuStrip.Items.Add(configureItem);

            var exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += (sender, e) =>
            {
                if (MessageBox.Show("Are you sure you want to exit? \n (All unsaved changes will be lost)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //trayIcon.Visible = false;  // Hide the tray icon
                    Application.Exit();        // Exit the application
                }
            };
            contextMenuStrip.Items.Add(exitItem);

            return contextMenuStrip;
        }

        private void LoadScripts()
        {
            // string filePath = "scripts.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                scripts = JsonConvert.DeserializeObject<List<ScriptInfo>>(json);

                if(scripts == null ) 
                {
                    scripts = new List<ScriptInfo>();
                }
            }
        }

        private void SaveScripts()
        {
            string json = JsonConvert.SerializeObject(scripts, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);

            UpdateTrayMenu();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void RefreshScriptList()
        {
            listBoxScripts.Items.Clear();
            if (scripts != null)
            {
                foreach (var script in scripts)
                {
                    listBoxScripts.Items.Add(script.Name);
                }
            }
        }

        private void LoadSelectedScript()
        {
            if (listBoxScripts.SelectedIndex != -1)
            {
                var script = scripts[listBoxScripts.SelectedIndex];
                textBoxName.Text = script.Name;
                textBoxPath.Text = script.Path;
                checkBoxIsExe.Checked = script.IsExe;
                textBoxArgs.Text = script.Arguments;
            }
        }

        private void AddScript()
        {
            var script = new ScriptInfo(textBoxName.Text, textBoxPath.Text, checkBoxIsExe.Checked, textBoxArgs.Text);
            scripts.Add(script);

            SaveScripts();
            RefreshScriptList();
        }

        private void EditScript()
        {
            if (listBoxScripts.SelectedIndex != -1)
            {
                var script = scripts[listBoxScripts.SelectedIndex];
                script.Name = textBoxName.Text;
                script.Path = textBoxPath.Text;
                script.IsExe = checkBoxIsExe.Checked;
                script.Arguments = textBoxArgs.Text;

                SaveScripts();
                RefreshScriptList();
            }
        }

        private void RemoveScript()
        {
            if (listBoxScripts.SelectedIndex != -1)
            {
                scripts.RemoveAt(listBoxScripts.SelectedIndex);

                SaveScripts();
                RefreshScriptList();
            }
        }

        public List<ScriptInfo> UpdatedScripts
        {
            get { return scripts; }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            AddScript();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditScript();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveScript();
        }

        private void listBoxScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedScript();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveScripts();
            RefreshScriptList();
        }
    }

}
