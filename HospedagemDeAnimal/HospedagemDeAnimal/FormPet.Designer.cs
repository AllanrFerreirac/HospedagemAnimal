namespace HospedagemDeAnimal
{
    partial class FormPet
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
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTutor = new System.Windows.Forms.TextBox();
            this.btnBuscarPets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPets = new System.Windows.Forms.TextBox();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluirPet = new System.Windows.Forms.Button();
            this.btnAttPet = new System.Windows.Forms.Button();
            this.btnCadastroPet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDt_N = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(285, 160);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(144, 20);
            this.txtSexo.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "CPF Tutor";
            // 
            // txtIdTutor
            // 
            this.txtIdTutor.Location = new System.Drawing.Point(285, 221);
            this.txtIdTutor.Name = "txtIdTutor";
            this.txtIdTutor.Size = new System.Drawing.Size(144, 20);
            this.txtIdTutor.TabIndex = 45;
            // 
            // btnBuscarPets
            // 
            this.btnBuscarPets.Location = new System.Drawing.Point(121, 318);
            this.btnBuscarPets.Name = "btnBuscarPets";
            this.btnBuscarPets.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarPets.TabIndex = 44;
            this.btnBuscarPets.Text = "Buscar meus pets";
            this.btnBuscarPets.UseVisualStyleBackColor = true;
            this.btnBuscarPets.Click += new System.EventHandler(this.btnBuscarPets_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Digite seu cpf";
            // 
            // txtBuscarPets
            // 
            this.txtBuscarPets.Location = new System.Drawing.Point(15, 320);
            this.txtBuscarPets.Name = "txtBuscarPets";
            this.txtBuscarPets.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPets.TabIndex = 42;
            // 
            // dgvPet
            // 
            this.dgvPet.AllowUserToAddRows = false;
            this.dgvPet.AllowUserToDeleteRows = false;
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Location = new System.Drawing.Point(15, 347);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.ReadOnly = true;
            this.dgvPet.Size = new System.Drawing.Size(552, 169);
            this.dgvPet.TabIndex = 41;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(460, 218);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(107, 23);
            this.btnVoltar.TabIndex = 40;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluirPet
            // 
            this.btnExcluirPet.Location = new System.Drawing.Point(492, 117);
            this.btnExcluirPet.Name = "btnExcluirPet";
            this.btnExcluirPet.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPet.TabIndex = 39;
            this.btnExcluirPet.Text = "Excluir";
            this.btnExcluirPet.UseVisualStyleBackColor = true;
            this.btnExcluirPet.Click += new System.EventHandler(this.btnExcluirPet_Click_1);
            // 
            // btnAttPet
            // 
            this.btnAttPet.Location = new System.Drawing.Point(492, 77);
            this.btnAttPet.Name = "btnAttPet";
            this.btnAttPet.Size = new System.Drawing.Size(75, 23);
            this.btnAttPet.TabIndex = 38;
            this.btnAttPet.Text = "Atualizar";
            this.btnAttPet.UseVisualStyleBackColor = true;
            this.btnAttPet.Click += new System.EventHandler(this.btnAttPet_Click_1);
            // 
            // btnCadastroPet
            // 
            this.btnCadastroPet.Location = new System.Drawing.Point(492, 39);
            this.btnCadastroPet.Name = "btnCadastroPet";
            this.btnCadastroPet.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPet.TabIndex = 37;
            this.btnCadastroPet.Text = "Cadastrar";
            this.btnCadastroPet.UseVisualStyleBackColor = true;
            this.btnCadastroPet.Click += new System.EventHandler(this.btnCadastroPet_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data de Nascimento";
            // 
            // dtpDt_N
            // 
            this.dtpDt_N.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDt_N.Location = new System.Drawing.Point(268, 38);
            this.dtpDt_N.Name = "dtpDt_N";
            this.dtpDt_N.Size = new System.Drawing.Size(161, 20);
            this.dtpDt_N.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sexo";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(15, 221);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(220, 20);
            this.txtEspecie.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Espécie";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(15, 160);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(220, 20);
            this.txtBreed.TabIndex = 31;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(12, 144);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(33, 13);
            this.lblBreed.TabIndex = 30;
            this.lblBreed.Text = "Raça";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(414, 20);
            this.txtNome.TabIndex = 29;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 27;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 13);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "Identificador";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(121, 35);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 25;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click_1);
            // 
            // FormPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 529);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdTutor);
            this.Controls.Add(this.btnBuscarPets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPets);
            this.Controls.Add(this.dgvPet);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirPet);
            this.Controls.Add(this.btnAttPet);
            this.Controls.Add(this.btnCadastroPet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDt_N);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLocalizar);
            this.Name = "FormPet";
            this.Text = "FormPet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTutor;
        private System.Windows.Forms.Button btnBuscarPets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPets;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluirPet;
        private System.Windows.Forms.Button btnAttPet;
        private System.Windows.Forms.Button btnCadastroPet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDt_N;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLocalizar;
    }
}