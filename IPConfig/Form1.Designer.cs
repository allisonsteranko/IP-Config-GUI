namespace IPConfig
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adapterBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.subnetBox = new System.Windows.Forms.TextBox();
            this.gatewayBox = new System.Windows.Forms.TextBox();
            this.adapterAddressLabel = new System.Windows.Forms.Label();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gatewayLabel = new System.Windows.Forms.Label();
            this.releaseButton = new System.Windows.Forms.Button();
            this.renewButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.adapterLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.ReleaseAllButton = new System.Windows.Forms.Button();
            this.RenewAllButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adapterBox
            // 
            this.adapterBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adapterBox.Location = new System.Drawing.Point(150, 140);
            this.adapterBox.Name = "adapterBox";
            this.adapterBox.ReadOnly = true;
            this.adapterBox.Size = new System.Drawing.Size(146, 20);
            this.adapterBox.TabIndex = 0;
            // 
            // ipBox
            // 
            this.ipBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ipBox.Location = new System.Drawing.Point(150, 62);
            this.ipBox.Name = "ipBox";
            this.ipBox.ReadOnly = true;
            this.ipBox.Size = new System.Drawing.Size(146, 20);
            this.ipBox.TabIndex = 1;
            // 
            // subnetBox
            // 
            this.subnetBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.subnetBox.Location = new System.Drawing.Point(150, 88);
            this.subnetBox.Name = "subnetBox";
            this.subnetBox.ReadOnly = true;
            this.subnetBox.Size = new System.Drawing.Size(146, 20);
            this.subnetBox.TabIndex = 2;
            // 
            // gatewayBox
            // 
            this.gatewayBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gatewayBox.Location = new System.Drawing.Point(150, 114);
            this.gatewayBox.Name = "gatewayBox";
            this.gatewayBox.ReadOnly = true;
            this.gatewayBox.Size = new System.Drawing.Size(146, 20);
            this.gatewayBox.TabIndex = 3;
            // 
            // adapterAddressLabel
            // 
            this.adapterAddressLabel.AutoSize = true;
            this.adapterAddressLabel.Location = new System.Drawing.Point(57, 143);
            this.adapterAddressLabel.Name = "adapterAddressLabel";
            this.adapterAddressLabel.Size = new System.Drawing.Size(88, 13);
            this.adapterAddressLabel.TabIndex = 4;
            this.adapterAddressLabel.Text = "Adapter Address:";
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(57, 65);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAddressLabel.TabIndex = 5;
            this.ipAddressLabel.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subnet Mask:";
            // 
            // gatewayLabel
            // 
            this.gatewayLabel.AutoSize = true;
            this.gatewayLabel.Location = new System.Drawing.Point(55, 117);
            this.gatewayLabel.Name = "gatewayLabel";
            this.gatewayLabel.Size = new System.Drawing.Size(89, 13);
            this.gatewayLabel.TabIndex = 7;
            this.gatewayLabel.Text = "Default Gateway:";
            // 
            // releaseButton
            // 
            this.releaseButton.Location = new System.Drawing.Point(146, 9);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(75, 29);
            this.releaseButton.TabIndex = 8;
            this.releaseButton.Text = "Release";
            this.releaseButton.UseVisualStyleBackColor = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click_1);
            // 
            // renewButton
            // 
            this.renewButton.Location = new System.Drawing.Point(268, 9);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(75, 29);
            this.renewButton.TabIndex = 9;
            this.renewButton.Text = "Renew";
            this.renewButton.UseVisualStyleBackColor = true;
            this.renewButton.Click += new System.EventHandler(this.renewButton_Click_1);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(19, 9);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 29);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // adapterLabel
            // 
            this.adapterLabel.AutoSize = true;
            this.adapterLabel.Location = new System.Drawing.Point(17, 15);
            this.adapterLabel.Name = "adapterLabel";
            this.adapterLabel.Size = new System.Drawing.Size(87, 13);
            this.adapterLabel.TabIndex = 12;
            this.adapterLabel.Text = "Network Adapter";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(19, 44);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 28);
            this.aboutButton.TabIndex = 14;
            this.aboutButton.Text = "About...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // ReleaseAllButton
            // 
            this.ReleaseAllButton.Location = new System.Drawing.Point(146, 44);
            this.ReleaseAllButton.Name = "ReleaseAllButton";
            this.ReleaseAllButton.Size = new System.Drawing.Size(75, 28);
            this.ReleaseAllButton.TabIndex = 15;
            this.ReleaseAllButton.Text = "Release All";
            this.ReleaseAllButton.UseVisualStyleBackColor = true;
            this.ReleaseAllButton.Click += new System.EventHandler(this.ReleaseAllButton_Click);
            // 
            // RenewAllButton
            // 
            this.RenewAllButton.Location = new System.Drawing.Point(268, 44);
            this.RenewAllButton.Name = "RenewAllButton";
            this.RenewAllButton.Size = new System.Drawing.Size(75, 28);
            this.RenewAllButton.TabIndex = 16;
            this.RenewAllButton.Text = "Renew All";
            this.RenewAllButton.UseVisualStyleBackColor = true;
            this.RenewAllButton.Click += new System.EventHandler(this.RenewAllButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.RenewAllButton);
            this.panel1.Controls.Add(this.releaseButton);
            this.panel1.Controls.Add(this.ReleaseAllButton);
            this.panel1.Controls.Add(this.renewButton);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Location = new System.Drawing.Point(12, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 84);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.adapterLabel);
            this.panel2.Controls.Add(this.adapterBox);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.ipBox);
            this.panel2.Controls.Add(this.subnetBox);
            this.panel2.Controls.Add(this.gatewayLabel);
            this.panel2.Controls.Add(this.gatewayBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.adapterAddressLabel);
            this.panel2.Controls.Add(this.ipAddressLabel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 177);
            this.panel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 289);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Configuration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adapterBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox subnetBox;
        private System.Windows.Forms.TextBox gatewayBox;
        private System.Windows.Forms.Label adapterAddressLabel;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gatewayLabel;
        private System.Windows.Forms.Button releaseButton;
        private System.Windows.Forms.Button renewButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label adapterLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button ReleaseAllButton;
        private System.Windows.Forms.Button RenewAllButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}

