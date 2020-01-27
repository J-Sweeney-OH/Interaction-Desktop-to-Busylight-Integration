namespace OHBusyLightUI
{
    partial class frmManage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.dgTypes = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colBlinkDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlinkRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMessages = new System.Windows.Forms.GroupBox();
            this.dgMessages = new System.Windows.Forms.DataGridView();
            this.colMessageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMessageBlinkDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageBlinkRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDefaultBlinkingInterval = new System.Windows.Forms.Label();
            this.txtDefaultBlinkingThreshold = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSchemaMgmtName = new System.Windows.Forms.Label();
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.linkCopy = new System.Windows.Forms.LinkLabel();
            this.gbTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTypes)).BeginInit();
            this.gbMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.dgTypes);
            this.gbTypes.Location = new System.Drawing.Point(16, 39);
            this.gbTypes.Margin = new System.Windows.Forms.Padding(4);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Padding = new System.Windows.Forms.Padding(4);
            this.gbTypes.Size = new System.Drawing.Size(556, 653);
            this.gbTypes.TabIndex = 6;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "Status Types";
            // 
            // dgTypes
            // 
            this.dgTypes.AllowUserToAddRows = false;
            this.dgTypes.AllowUserToDeleteRows = false;
            this.dgTypes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colColor,
            this.colBlinkDelay,
            this.colBlinkRate});
            this.dgTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTypes.Location = new System.Drawing.Point(4, 19);
            this.dgTypes.Margin = new System.Windows.Forms.Padding(4);
            this.dgTypes.MultiSelect = false;
            this.dgTypes.Name = "dgTypes";
            this.dgTypes.RowHeadersVisible = false;
            this.dgTypes.RowHeadersWidth = 51;
            this.dgTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgTypes.Size = new System.Drawing.Size(548, 630);
            this.dgTypes.TabIndex = 0;
            this.dgTypes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTypes_CellEndEdit);
            this.dgTypes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgTypes_CellValidating);
            this.dgTypes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgTypes_EditingControlShowing);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colColor
            // 
            this.colColor.DataPropertyName = "Color";
            this.colColor.HeaderText = "Color";
            this.colColor.Items.AddRange(new object[] {
            "BLUE",
            "GREEN",
            "ORANGE",
            "PURPLE",
            "RED",
            "WHITE",
            "YELLOW"});
            this.colColor.MinimumWidth = 6;
            this.colColor.Name = "colColor";
            this.colColor.Width = 125;
            // 
            // colBlinkDelay
            // 
            this.colBlinkDelay.DataPropertyName = "BlinkDelay";
            this.colBlinkDelay.HeaderText = "Blink Delay";
            this.colBlinkDelay.MinimumWidth = 6;
            this.colBlinkDelay.Name = "colBlinkDelay";
            this.colBlinkDelay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBlinkDelay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBlinkDelay.Width = 125;
            // 
            // colBlinkRate
            // 
            this.colBlinkRate.DataPropertyName = "BlinkRate";
            this.colBlinkRate.HeaderText = "Blink Rate";
            this.colBlinkRate.MinimumWidth = 6;
            this.colBlinkRate.Name = "colBlinkRate";
            this.colBlinkRate.Width = 125;
            // 
            // gbMessages
            // 
            this.gbMessages.Controls.Add(this.dgMessages);
            this.gbMessages.Location = new System.Drawing.Point(580, 40);
            this.gbMessages.Margin = new System.Windows.Forms.Padding(4);
            this.gbMessages.Name = "gbMessages";
            this.gbMessages.Padding = new System.Windows.Forms.Padding(4);
            this.gbMessages.Size = new System.Drawing.Size(646, 652);
            this.gbMessages.TabIndex = 7;
            this.gbMessages.TabStop = false;
            this.gbMessages.Text = "Status Messages";
            // 
            // dgMessages
            // 
            this.dgMessages.AllowUserToAddRows = false;
            this.dgMessages.AllowUserToDeleteRows = false;
            this.dgMessages.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMessageName,
            this.colMessageType,
            this.colMessageColor,
            this.colMessageBlinkDelay,
            this.colMessageBlinkRate});
            this.dgMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMessages.Location = new System.Drawing.Point(4, 19);
            this.dgMessages.Margin = new System.Windows.Forms.Padding(4);
            this.dgMessages.MultiSelect = false;
            this.dgMessages.Name = "dgMessages";
            this.dgMessages.RowHeadersVisible = false;
            this.dgMessages.RowHeadersWidth = 51;
            this.dgMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgMessages.Size = new System.Drawing.Size(638, 629);
            this.dgMessages.TabIndex = 1;
            this.dgMessages.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMessages_CellEndEdit);
            this.dgMessages.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgMessages_CellValidating);
            this.dgMessages.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgMessages_EditingControlShowing);
            // 
            // colMessageName
            // 
            this.colMessageName.DataPropertyName = "Name";
            this.colMessageName.HeaderText = "Name";
            this.colMessageName.MinimumWidth = 6;
            this.colMessageName.Name = "colMessageName";
            this.colMessageName.ReadOnly = true;
            this.colMessageName.Width = 125;
            // 
            // colMessageType
            // 
            this.colMessageType.DataPropertyName = "Type";
            this.colMessageType.HeaderText = "Type";
            this.colMessageType.MinimumWidth = 6;
            this.colMessageType.Name = "colMessageType";
            this.colMessageType.ReadOnly = true;
            this.colMessageType.Width = 125;
            // 
            // colMessageColor
            // 
            this.colMessageColor.DataPropertyName = "Color";
            this.colMessageColor.HeaderText = "Color";
            this.colMessageColor.Items.AddRange(new object[] {
            "BLUE",
            "GREEN",
            "ORANGE",
            "PURPLE",
            "RED",
            "WHITE",
            "YELLOW"});
            this.colMessageColor.MinimumWidth = 6;
            this.colMessageColor.Name = "colMessageColor";
            this.colMessageColor.Width = 125;
            // 
            // colMessageBlinkDelay
            // 
            this.colMessageBlinkDelay.DataPropertyName = "BlinkDelay";
            this.colMessageBlinkDelay.HeaderText = "Blink Delay";
            this.colMessageBlinkDelay.MinimumWidth = 6;
            this.colMessageBlinkDelay.Name = "colMessageBlinkDelay";
            this.colMessageBlinkDelay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMessageBlinkDelay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMessageBlinkDelay.Width = 125;
            // 
            // colMessageBlinkRate
            // 
            this.colMessageBlinkRate.DataPropertyName = "BlinkRate";
            this.colMessageBlinkRate.HeaderText = "Blink Rate";
            this.colMessageBlinkRate.MinimumWidth = 6;
            this.colMessageBlinkRate.Name = "colMessageBlinkRate";
            this.colMessageBlinkRate.Width = 125;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(16, 700);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1126, 700);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDefaultBlinkingInterval
            // 
            this.lblDefaultBlinkingInterval.AutoSize = true;
            this.lblDefaultBlinkingInterval.Location = new System.Drawing.Point(1001, 13);
            this.lblDefaultBlinkingInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefaultBlinkingInterval.Name = "lblDefaultBlinkingInterval";
            this.lblDefaultBlinkingInterval.Size = new System.Drawing.Size(150, 17);
            this.lblDefaultBlinkingInterval.TabIndex = 19;
            this.lblDefaultBlinkingInterval.Text = "Default Blinking Delay:";
            // 
            // txtDefaultBlinkingThreshold
            // 
            this.txtDefaultBlinkingThreshold.Location = new System.Drawing.Point(1169, 10);
            this.txtDefaultBlinkingThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.txtDefaultBlinkingThreshold.Name = "txtDefaultBlinkingThreshold";
            this.txtDefaultBlinkingThreshold.Size = new System.Drawing.Size(53, 22);
            this.txtDefaultBlinkingThreshold.TabIndex = 18;
            this.txtDefaultBlinkingThreshold.Validated += new System.EventHandler(this.txtDefaultBlinkingThreshold_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 7);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(501, 22);
            this.txtName.TabIndex = 17;
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // lblSchemaMgmtName
            // 
            this.lblSchemaMgmtName.AutoSize = true;
            this.lblSchemaMgmtName.Location = new System.Drawing.Point(12, 11);
            this.lblSchemaMgmtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchemaMgmtName.Name = "lblSchemaMgmtName";
            this.lblSchemaMgmtName.Size = new System.Drawing.Size(49, 17);
            this.lblSchemaMgmtName.TabIndex = 16;
            this.lblSchemaMgmtName.Text = "Name:";
            // 
            // errError
            // 
            this.errError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errError.ContainerControl = this;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(577, 707);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(434, 17);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Note: Blinking Delay should be a whole positive number of seconds.";
            // 
            // linkCopy
            // 
            this.linkCopy.AutoSize = true;
            this.linkCopy.Location = new System.Drawing.Point(214, 707);
            this.linkCopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkCopy.Name = "linkCopy";
            this.linkCopy.Size = new System.Drawing.Size(214, 17);
            this.linkCopy.TabIndex = 21;
            this.linkCopy.TabStop = true;
            this.linkCopy.Text = "Apply Types Colors to Messages";
            this.linkCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCopy_LinkClicked);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 741);
            this.ControlBox = false;
            this.Controls.Add(this.linkCopy);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbMessages);
            this.Controls.Add(this.gbTypes);
            this.Controls.Add(this.lblDefaultBlinkingInterval);
            this.Controls.Add(this.txtDefaultBlinkingThreshold);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSchemaMgmtName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busylight Color Schema Editor";
            this.Load += new System.EventHandler(this.frmManage_Load);
            this.gbTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTypes)).EndInit();
            this.gbMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.DataGridView dgTypes;
        private System.Windows.Forms.GroupBox gbMessages;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDefaultBlinkingInterval;
        private System.Windows.Forms.TextBox txtDefaultBlinkingThreshold;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSchemaMgmtName;
        private System.Windows.Forms.DataGridView dgMessages;
        private System.Windows.Forms.ErrorProvider errError;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.LinkLabel linkCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlinkDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlinkRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageType;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMessageColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageBlinkDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageBlinkRate;
    }
}