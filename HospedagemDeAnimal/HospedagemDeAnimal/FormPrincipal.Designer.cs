namespace HospedagemDeAnimal
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meusDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusPetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedarMeuPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusDadosToolStripMenuItem,
            this.meusPetsToolStripMenuItem,
            this.hospedarMeuPetToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meusDadosToolStripMenuItem
            // 
            this.meusDadosToolStripMenuItem.Name = "meusDadosToolStripMenuItem";
            this.meusDadosToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.meusDadosToolStripMenuItem.Text = "Meus dados";
            this.meusDadosToolStripMenuItem.Click += new System.EventHandler(this.meusDadosToolStripMenuItem_Click);
            // 
            // meusPetsToolStripMenuItem
            // 
            this.meusPetsToolStripMenuItem.Name = "meusPetsToolStripMenuItem";
            this.meusPetsToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.meusPetsToolStripMenuItem.Text = "Meus Pets";
            this.meusPetsToolStripMenuItem.Click += new System.EventHandler(this.meusPetsToolStripMenuItem_Click);
            // 
            // hospedarMeuPetToolStripMenuItem
            // 
            this.hospedarMeuPetToolStripMenuItem.Name = "hospedarMeuPetToolStripMenuItem";
            this.hospedarMeuPetToolStripMenuItem.Size = new System.Drawing.Size(159, 25);
            this.hospedarMeuPetToolStripMenuItem.Text = "Hospedar meu pet";
            this.hospedarMeuPetToolStripMenuItem.Click += new System.EventHandler(this.hospedarMeuPetToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.hospedagensToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.adminToolStripMenuItem.Text = "Administração";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // hospedagensToolStripMenuItem
            // 
            this.hospedagensToolStripMenuItem.Name = "hospedagensToolStripMenuItem";
            this.hospedagensToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hospedagensToolStripMenuItem.Text = "Hospedagens";
            this.hospedagensToolStripMenuItem.Click += new System.EventHandler(this.hospedagensToolStripMenuItem_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.Thistle;
            this.btnDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeslogar.Location = new System.Drawing.Point(507, 422);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(150, 31);
            this.btnDeslogar.TabIndex = 40;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = false;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Image = global::HospedagemDeAnimal.Properties.Resources.Hospedagem_500x500h;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(667, 461);
            this.Controls.Add(this.btnDeslogar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospedagem Animal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meusDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusPetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedarMeuPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedagensToolStripMenuItem;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}