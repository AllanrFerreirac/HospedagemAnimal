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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusDadosToolStripMenuItem,
            this.meusPetsToolStripMenuItem,
            this.hospedarMeuPetToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meusDadosToolStripMenuItem
            // 
            this.meusDadosToolStripMenuItem.Name = "meusDadosToolStripMenuItem";
            this.meusDadosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.meusDadosToolStripMenuItem.Text = "Meus dados";
            this.meusDadosToolStripMenuItem.Click += new System.EventHandler(this.meusDadosToolStripMenuItem_Click);
            // 
            // meusPetsToolStripMenuItem
            // 
            this.meusPetsToolStripMenuItem.Name = "meusPetsToolStripMenuItem";
            this.meusPetsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.meusPetsToolStripMenuItem.Text = "Meus Pets";
            this.meusPetsToolStripMenuItem.Click += new System.EventHandler(this.meusPetsToolStripMenuItem_Click);
            // 
            // hospedarMeuPetToolStripMenuItem
            // 
            this.hospedarMeuPetToolStripMenuItem.Name = "hospedarMeuPetToolStripMenuItem";
            this.hospedarMeuPetToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.hospedarMeuPetToolStripMenuItem.Text = "Hospedar meu pet";
            this.hospedarMeuPetToolStripMenuItem.Click += new System.EventHandler(this.hospedarMeuPetToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.hospedagensToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // hospedagensToolStripMenuItem
            // 
            this.hospedagensToolStripMenuItem.Name = "hospedagensToolStripMenuItem";
            this.hospedagensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hospedagensToolStripMenuItem.Text = "Hospedagens";
            this.hospedagensToolStripMenuItem.Click += new System.EventHandler(this.hospedagensToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 440);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.Text = "Hospedagem Animal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}