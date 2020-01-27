namespace OHBusyLightUI
{
    partial class ColorSchemaUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOHBusyLightManagement = new System.Windows.Forms.TabControl();
            this.tabColorSelector = new System.Windows.Forms.TabPage();
            this.gpConfigSelector = new System.Windows.Forms.GroupBox();
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            this.linkNew = new System.Windows.Forms.LinkLabel();
            this.linkDelete = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.cbColorSchema = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.linkCurrentSchema = new System.Windows.Forms.LinkLabel();
            this.tabOHBusyLightManagement.SuspendLayout();
            this.tabColorSelector.SuspendLayout();
            this.gpConfigSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOHBusyLightManagement
            // 
            this.tabOHBusyLightManagement.Controls.Add(this.tabColorSelector);
            this.tabOHBusyLightManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOHBusyLightManagement.Location = new System.Drawing.Point(0, 0);
            this.tabOHBusyLightManagement.Name = "tabOHBusyLightManagement";
            this.tabOHBusyLightManagement.SelectedIndex = 0;
            this.tabOHBusyLightManagement.Size = new System.Drawing.Size(670, 450);
            this.tabOHBusyLightManagement.TabIndex = 0;
            // 
            // tabColorSelector
            // 
            this.tabColorSelector.BackColor = System.Drawing.SystemColors.Control;
            this.tabColorSelector.Controls.Add(this.gpConfigSelector);
            this.tabColorSelector.Location = new System.Drawing.Point(4, 22);
            this.tabColorSelector.Name = "tabColorSelector";
            this.tabColorSelector.Padding = new System.Windows.Forms.Padding(3);
            this.tabColorSelector.Size = new System.Drawing.Size(662, 424);
            this.tabColorSelector.TabIndex = 0;
            this.tabColorSelector.Text = "Busylight Color Selector";
            // 
            // gpConfigSelector
            // 
            this.gpConfigSelector.Controls.Add(this.linkCurrentSchema);
            this.gpConfigSelector.Controls.Add(this.linkRefresh);
            this.gpConfigSelector.Controls.Add(this.linkNew);
            this.gpConfigSelector.Controls.Add(this.linkDelete);
            this.gpConfigSelector.Controls.Add(this.linkEdit);
            this.gpConfigSelector.Controls.Add(this.lblName);
            this.gpConfigSelector.Controls.Add(this.cbColorSchema);
            this.gpConfigSelector.Controls.Add(this.btnApply);
            this.gpConfigSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpConfigSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpConfigSelector.Location = new System.Drawing.Point(3, 3);
            this.gpConfigSelector.Name = "gpConfigSelector";
            this.gpConfigSelector.Size = new System.Drawing.Size(656, 418);
            this.gpConfigSelector.TabIndex = 3;
            this.gpConfigSelector.TabStop = false;
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Location = new System.Drawing.Point(113, 104);
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size(51, 13);
            this.linkRefresh.TabIndex = 9;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "Refresh";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRefresh_LinkClicked);
            // 
            // linkNew
            // 
            this.linkNew.AutoSize = true;
            this.linkNew.Location = new System.Drawing.Point(260, 63);
            this.linkNew.Name = "linkNew";
            this.linkNew.Size = new System.Drawing.Size(32, 13);
            this.linkNew.TabIndex = 8;
            this.linkNew.TabStop = true;
            this.linkNew.Text = "New";
            this.linkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNew_LinkClicked);
            // 
            // linkDelete
            // 
            this.linkDelete.AutoSize = true;
            this.linkDelete.Enabled = false;
            this.linkDelete.Location = new System.Drawing.Point(333, 63);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(44, 13);
            this.linkDelete.TabIndex = 7;
            this.linkDelete.TabStop = true;
            this.linkDelete.Text = "Delete";
            this.linkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelete_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Enabled = false;
            this.linkEdit.Location = new System.Drawing.Point(298, 63);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(29, 13);
            this.linkEdit.TabIndex = 6;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "Edit";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Current Schema:";
            // 
            // cbColorSchema
            // 
            this.cbColorSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorSchema.FormattingEnabled = true;
            this.cbColorSchema.Location = new System.Drawing.Point(9, 60);
            this.cbColorSchema.Name = "cbColorSchema";
            this.cbColorSchema.Size = new System.Drawing.Size(245, 21);
            this.cbColorSchema.TabIndex = 1;
            this.cbColorSchema.DropDown += new System.EventHandler(this.cbColorSchema_DropDown);
            this.cbColorSchema.SelectedIndexChanged += new System.EventHandler(this.cbColorSchema_SelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(9, 99);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(98, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply Colors";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // linkCurrentSchema
            // 
            this.linkCurrentSchema.AutoSize = true;
            this.linkCurrentSchema.Location = new System.Drawing.Point(113, 33);
            this.linkCurrentSchema.Name = "linkCurrentSchema";
            this.linkCurrentSchema.Size = new System.Drawing.Size(50, 13);
            this.linkCurrentSchema.TabIndex = 10;
            this.linkCurrentSchema.TabStop = true;
            this.linkCurrentSchema.Text = "schema";
            this.linkCurrentSchema.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCurrentSchema_LinkClicked);
            // 
            // ColorSchemaUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabOHBusyLightManagement);
            this.Name = "ColorSchemaUi";
            this.Size = new System.Drawing.Size(670, 450);
            this.Load += new System.EventHandler(this.ColorSchemaUi_Load);
            this.tabOHBusyLightManagement.ResumeLayout(false);
            this.tabColorSelector.ResumeLayout(false);
            this.gpConfigSelector.ResumeLayout(false);
            this.gpConfigSelector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOHBusyLightManagement;
        private System.Windows.Forms.TabPage tabColorSelector;
        private System.Windows.Forms.GroupBox gpConfigSelector;
        private System.Windows.Forms.ComboBox cbColorSchema;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkDelete;
        private System.Windows.Forms.LinkLabel linkEdit;
        private System.Windows.Forms.LinkLabel linkNew;
        private System.Windows.Forms.LinkLabel linkRefresh;
        private System.Windows.Forms.LinkLabel linkCurrentSchema;
    }
}
