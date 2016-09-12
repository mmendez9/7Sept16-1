namespace _7Sept16_1
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
            this.lblFlavors = new System.Windows.Forms.Label();
            this.lbxFlavors = new System.Windows.Forms.ListBox();
            this.exit = new System.Windows.Forms.Button();
            this.lbxFlavor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFlavors
            // 
            this.lblFlavors.AutoSize = true;
            this.lblFlavors.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlavors.Location = new System.Drawing.Point(12, 17);
            this.lblFlavors.Name = "lblFlavors";
            this.lblFlavors.Size = new System.Drawing.Size(172, 26);
            this.lblFlavors.TabIndex = 0;
            this.lblFlavors.Text = "Ice Cream Flavors";
            // 
            // lbxFlavors
            // 
            this.lbxFlavors.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFlavors.FormattingEnabled = true;
            this.lbxFlavors.ItemHeight = 16;
            this.lbxFlavors.Location = new System.Drawing.Point(17, 46);
            this.lbxFlavors.Name = "lbxFlavors";
            this.lbxFlavors.Size = new System.Drawing.Size(167, 100);
            this.lbxFlavors.TabIndex = 1;
            this.lbxFlavors.SelectedIndexChanged += new System.EventHandler(this.lbxFlavors_SelectedIndexChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(17, 210);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(71, 27);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lbxFlavor
            // 
            this.lbxFlavor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbxFlavor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbxFlavor.Enabled = false;
            this.lbxFlavor.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFlavor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbxFlavor.Location = new System.Drawing.Point(12, 166);
            this.lbxFlavor.Name = "lbxFlavor";
            this.lbxFlavor.Size = new System.Drawing.Size(260, 22);
            this.lbxFlavor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbxFlavor);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lbxFlavors);
            this.Controls.Add(this.lblFlavors);
            this.Name = "Form1";
            this.Text = "Ice Cream";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlavors;
        private System.Windows.Forms.ListBox lbxFlavors;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label lbxFlavor;
    }
}

