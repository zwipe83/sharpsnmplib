namespace SharpSnmpLib.UI.WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetOid = new Button();
            txtIpAddress = new TextBox();
            txtPort = new TextBox();
            lblDescription = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetOid
            // 
            btnGetOid.Location = new Point(12, 90);
            btnGetOid.Name = "btnGetOid";
            btnGetOid.Size = new Size(100, 23);
            btnGetOid.TabIndex = 0;
            btnGetOid.Text = "Get Description";
            btnGetOid.UseVisualStyleBackColor = true;
            btnGetOid.Click += btnGetOid_Click;
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(12, 32);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(100, 23);
            txtIpAddress.TabIndex = 1;
            txtIpAddress.Text = "192.168.0.157";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(12, 61);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 1;
            txtPort.Text = "161";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(118, 94);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(38, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1351, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 450);
            Controls.Add(lblDescription);
            Controls.Add(txtPort);
            Controls.Add(txtIpAddress);
            Controls.Add(btnGetOid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "SNMP Studio 0.0.0.1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetOid;
        private TextBox txtIpAddress;
        private TextBox txtPort;
        private Label lblDescription;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}
