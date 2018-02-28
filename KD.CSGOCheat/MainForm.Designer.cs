namespace KD.CSGOCheat
{
    partial class MainForm
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
            this.GB_Wallhack = new System.Windows.Forms.GroupBox();
            this.CB_Wallhack_Active = new System.Windows.Forms.CheckBox();
            this.GB_Aimbot = new System.Windows.Forms.GroupBox();
            this.CB_Aimbot_Active = new System.Windows.Forms.CheckBox();
            this.GB_Triggerbot = new System.Windows.Forms.GroupBox();
            this.CB_Triggerbot_Active = new System.Windows.Forms.CheckBox();
            this.GB_ConnectionStatus = new System.Windows.Forms.GroupBox();
            this.TB_ConnectionStatus = new System.Windows.Forms.TextBox();
            this.B_ConnectToCsgo = new System.Windows.Forms.Button();
            this.GB_Wallhack.SuspendLayout();
            this.GB_Aimbot.SuspendLayout();
            this.GB_Triggerbot.SuspendLayout();
            this.GB_ConnectionStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Wallhack
            // 
            this.GB_Wallhack.Controls.Add(this.CB_Wallhack_Active);
            this.GB_Wallhack.Location = new System.Drawing.Point(12, 83);
            this.GB_Wallhack.Name = "GB_Wallhack";
            this.GB_Wallhack.Size = new System.Drawing.Size(200, 100);
            this.GB_Wallhack.TabIndex = 0;
            this.GB_Wallhack.TabStop = false;
            this.GB_Wallhack.Text = "Wallhack";
            // 
            // CB_Wallhack_Active
            // 
            this.CB_Wallhack_Active.AutoSize = true;
            this.CB_Wallhack_Active.Location = new System.Drawing.Point(7, 20);
            this.CB_Wallhack_Active.Name = "CB_Wallhack_Active";
            this.CB_Wallhack_Active.Size = new System.Drawing.Size(56, 17);
            this.CB_Wallhack_Active.TabIndex = 0;
            this.CB_Wallhack_Active.Text = "Active";
            this.CB_Wallhack_Active.UseVisualStyleBackColor = true;
            this.CB_Wallhack_Active.CheckedChanged += new System.EventHandler(this.CB_Triggerbot_Active_CheckedChanged);
            // 
            // GB_Aimbot
            // 
            this.GB_Aimbot.Controls.Add(this.CB_Aimbot_Active);
            this.GB_Aimbot.Location = new System.Drawing.Point(218, 83);
            this.GB_Aimbot.Name = "GB_Aimbot";
            this.GB_Aimbot.Size = new System.Drawing.Size(200, 100);
            this.GB_Aimbot.TabIndex = 1;
            this.GB_Aimbot.TabStop = false;
            this.GB_Aimbot.Text = "Aimbot";
            // 
            // CB_Aimbot_Active
            // 
            this.CB_Aimbot_Active.AutoSize = true;
            this.CB_Aimbot_Active.Location = new System.Drawing.Point(7, 20);
            this.CB_Aimbot_Active.Name = "CB_Aimbot_Active";
            this.CB_Aimbot_Active.Size = new System.Drawing.Size(56, 17);
            this.CB_Aimbot_Active.TabIndex = 0;
            this.CB_Aimbot_Active.Text = "Active";
            this.CB_Aimbot_Active.UseVisualStyleBackColor = true;
            // 
            // GB_Triggerbot
            // 
            this.GB_Triggerbot.Controls.Add(this.CB_Triggerbot_Active);
            this.GB_Triggerbot.Location = new System.Drawing.Point(11, 189);
            this.GB_Triggerbot.Name = "GB_Triggerbot";
            this.GB_Triggerbot.Size = new System.Drawing.Size(200, 100);
            this.GB_Triggerbot.TabIndex = 1;
            this.GB_Triggerbot.TabStop = false;
            this.GB_Triggerbot.Text = "Triggerbot";
            // 
            // CB_Triggerbot_Active
            // 
            this.CB_Triggerbot_Active.AutoSize = true;
            this.CB_Triggerbot_Active.Location = new System.Drawing.Point(7, 20);
            this.CB_Triggerbot_Active.Name = "CB_Triggerbot_Active";
            this.CB_Triggerbot_Active.Size = new System.Drawing.Size(56, 17);
            this.CB_Triggerbot_Active.TabIndex = 0;
            this.CB_Triggerbot_Active.Text = "Active";
            this.CB_Triggerbot_Active.UseVisualStyleBackColor = true;
            this.CB_Triggerbot_Active.CheckedChanged += new System.EventHandler(this.CB_Triggerbot_Active_CheckedChanged);
            // 
            // GB_ConnectionStatus
            // 
            this.GB_ConnectionStatus.Controls.Add(this.TB_ConnectionStatus);
            this.GB_ConnectionStatus.Controls.Add(this.B_ConnectToCsgo);
            this.GB_ConnectionStatus.Location = new System.Drawing.Point(12, 13);
            this.GB_ConnectionStatus.Name = "GB_ConnectionStatus";
            this.GB_ConnectionStatus.Size = new System.Drawing.Size(406, 64);
            this.GB_ConnectionStatus.TabIndex = 2;
            this.GB_ConnectionStatus.TabStop = false;
            this.GB_ConnectionStatus.Text = "Connection Status";
            // 
            // TB_ConnectionStatus
            // 
            this.TB_ConnectionStatus.BackColor = System.Drawing.Color.White;
            this.TB_ConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.TB_ConnectionStatus.Location = new System.Drawing.Point(129, 27);
            this.TB_ConnectionStatus.Name = "TB_ConnectionStatus";
            this.TB_ConnectionStatus.ReadOnly = true;
            this.TB_ConnectionStatus.Size = new System.Drawing.Size(140, 20);
            this.TB_ConnectionStatus.TabIndex = 1;
            this.TB_ConnectionStatus.Text = "Not Connected";
            // 
            // B_ConnectToCsgo
            // 
            this.B_ConnectToCsgo.Location = new System.Drawing.Point(7, 20);
            this.B_ConnectToCsgo.Name = "B_ConnectToCsgo";
            this.B_ConnectToCsgo.Size = new System.Drawing.Size(116, 32);
            this.B_ConnectToCsgo.TabIndex = 0;
            this.B_ConnectToCsgo.Text = "Connect to CSGO";
            this.B_ConnectToCsgo.UseVisualStyleBackColor = true;
            this.B_ConnectToCsgo.Click += new System.EventHandler(this.B_ConnectToCsgo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 298);
            this.Controls.Add(this.GB_ConnectionStatus);
            this.Controls.Add(this.GB_Triggerbot);
            this.Controls.Add(this.GB_Aimbot);
            this.Controls.Add(this.GB_Wallhack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "KD.CSGOCheat v0.1";
            this.GB_Wallhack.ResumeLayout(false);
            this.GB_Wallhack.PerformLayout();
            this.GB_Aimbot.ResumeLayout(false);
            this.GB_Aimbot.PerformLayout();
            this.GB_Triggerbot.ResumeLayout(false);
            this.GB_Triggerbot.PerformLayout();
            this.GB_ConnectionStatus.ResumeLayout(false);
            this.GB_ConnectionStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Wallhack;
        private System.Windows.Forms.CheckBox CB_Wallhack_Active;
        private System.Windows.Forms.GroupBox GB_Aimbot;
        private System.Windows.Forms.CheckBox CB_Aimbot_Active;
        private System.Windows.Forms.GroupBox GB_Triggerbot;
        private System.Windows.Forms.CheckBox CB_Triggerbot_Active;
        private System.Windows.Forms.GroupBox GB_ConnectionStatus;
        private System.Windows.Forms.TextBox TB_ConnectionStatus;
        private System.Windows.Forms.Button B_ConnectToCsgo;
    }
}

