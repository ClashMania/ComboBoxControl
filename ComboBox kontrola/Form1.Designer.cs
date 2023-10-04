namespace ComboBox_kontrola
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.textBoxProfil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odaberite jedan od ponuđenih obrazovnih profila: ";
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.FormattingEnabled = true;
            this.comboBoxProfil.Items.AddRange(new object[] {
            "IT menadzement",
            "aplikativno programiranje",
            "internet programiranje",
            "informacijski sistemi"});
            this.comboBoxProfil.Location = new System.Drawing.Point(15, 62);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(379, 21);
            this.comboBoxProfil.TabIndex = 6;
            this.comboBoxProfil.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfil_SelectedIndexChanged);
            // 
            // textBoxProfil
            // 
            this.textBoxProfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxProfil.Location = new System.Drawing.Point(15, 132);
            this.textBoxProfil.Multiline = true;
            this.textBoxProfil.Name = "textBoxProfil";
            this.textBoxProfil.ReadOnly = true;
            this.textBoxProfil.Size = new System.Drawing.Size(379, 108);
            this.textBoxProfil.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 269);
            this.Controls.Add(this.textBoxProfil);
            this.Controls.Add(this.comboBoxProfil);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "ComboBox Kontrola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProfil;
        private System.Windows.Forms.TextBox textBoxProfil;
    }
}

