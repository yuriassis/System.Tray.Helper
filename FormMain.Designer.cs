namespace ART.Dynamic.Tools
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.checkBoxIsExe = new System.Windows.Forms.CheckBox();
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.labelArgs = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxScripts = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Image = global::System.Tray.Helper.Properties.Resources.delete;
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(137, 349);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 29);
            this.buttonRemove.TabIndex = 21;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::System.Tray.Helper.Properties.Resources.setting_tools;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(73, 349);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(58, 29);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Save";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::System.Tray.Helper.Properties.Resources.add;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(9, 349);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(58, 29);
            this.buttonNew.TabIndex = 19;
            this.buttonNew.Text = "New";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // checkBoxIsExe
            // 
            this.checkBoxIsExe.AutoSize = true;
            this.checkBoxIsExe.Location = new System.Drawing.Point(9, 317);
            this.checkBoxIsExe.Name = "checkBoxIsExe";
            this.checkBoxIsExe.Size = new System.Drawing.Size(58, 17);
            this.checkBoxIsExe.TabIndex = 18;
            this.checkBoxIsExe.Text = "Is EXE";
            this.checkBoxIsExe.UseVisualStyleBackColor = true;
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.Location = new System.Drawing.Point(50, 291);
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.Size = new System.Drawing.Size(248, 20);
            this.textBoxArgs.TabIndex = 17;
            // 
            // labelArgs
            // 
            this.labelArgs.AutoSize = true;
            this.labelArgs.Location = new System.Drawing.Point(6, 294);
            this.labelArgs.Name = "labelArgs";
            this.labelArgs.Size = new System.Drawing.Size(28, 13);
            this.labelArgs.TabIndex = 16;
            this.labelArgs.Text = "Args";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(50, 265);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(248, 20);
            this.textBoxPath.TabIndex = 15;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 268);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 14;
            this.labelPath.Text = "Path";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(50, 239);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 242);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // listBoxScripts
            // 
            this.listBoxScripts.FormattingEnabled = true;
            this.listBoxScripts.Location = new System.Drawing.Point(9, 15);
            this.listBoxScripts.Name = "listBoxScripts";
            this.listBoxScripts.Size = new System.Drawing.Size(289, 212);
            this.listBoxScripts.TabIndex = 11;
            this.listBoxScripts.SelectedIndexChanged += new System.EventHandler(this.listBoxScripts_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::System.Tray.Helper.Properties.Resources.disk_multiple;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(218, 349);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 29);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save All";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Script & App Runner";
            this.notifyIcon.Visible = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 388);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.checkBoxIsExe);
            this.Controls.Add(this.textBoxArgs);
            this.Controls.Add(this.labelArgs);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxScripts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.CheckBox checkBoxIsExe;
        private System.Windows.Forms.TextBox textBoxArgs;
        private System.Windows.Forms.Label labelArgs;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxScripts;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

