namespace HospedagemDeAnimal
{
    partial class FormHospedagemCliente
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDtFim = new System.Windows.Forms.DateTimePicker();
            this.cbxAnimal = new System.Windows.Forms.ComboBox();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluirPet = new System.Windows.Forms.Button();
            this.btnAttPet = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.dtpDtInicio = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(438, 104);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 23);
            this.btnConfirmar.TabIndex = 68;
            this.btnConfirmar.Text = "Confirmar Hospedagem";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Check-out";
            // 
            // dtpDtFim
            // 
            this.dtpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtFim.Location = new System.Drawing.Point(171, 164);
            this.dtpDtFim.Name = "dtpDtFim";
            this.dtpDtFim.Size = new System.Drawing.Size(148, 20);
            this.dtpDtFim.TabIndex = 66;
            // 
            // cbxAnimal
            // 
            this.cbxAnimal.FormattingEnabled = true;
            this.cbxAnimal.Location = new System.Drawing.Point(15, 87);
            this.cbxAnimal.Name = "cbxAnimal";
            this.cbxAnimal.Size = new System.Drawing.Size(322, 21);
            this.cbxAnimal.TabIndex = 65;
            // 
            // dgvPet
            // 
            this.dgvPet.AllowUserToAddRows = false;
            this.dgvPet.AllowUserToDeleteRows = false;
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Location = new System.Drawing.Point(15, 222);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.ReadOnly = true;
            this.dgvPet.Size = new System.Drawing.Size(552, 282);
            this.dgvPet.TabIndex = 62;
            this.dgvPet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPet_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(460, 193);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(107, 23);
            this.btnVoltar.TabIndex = 61;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluirPet
            // 
            this.btnExcluirPet.Location = new System.Drawing.Point(438, 142);
            this.btnExcluirPet.Name = "btnExcluirPet";
            this.btnExcluirPet.Size = new System.Drawing.Size(129, 23);
            this.btnExcluirPet.TabIndex = 60;
            this.btnExcluirPet.Text = "Excluir Hospedagem";
            this.btnExcluirPet.UseVisualStyleBackColor = true;
            this.btnExcluirPet.Click += new System.EventHandler(this.btnExcluirPet_Click_1);
            // 
            // btnAttPet
            // 
            this.btnAttPet.Location = new System.Drawing.Point(438, 65);
            this.btnAttPet.Name = "btnAttPet";
            this.btnAttPet.Size = new System.Drawing.Size(129, 23);
            this.btnAttPet.TabIndex = 59;
            this.btnAttPet.Text = "Editar Hospedagem";
            this.btnAttPet.UseVisualStyleBackColor = true;
            this.btnAttPet.Click += new System.EventHandler(this.btnAttPet_Click_1);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(438, 27);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(129, 23);
            this.btnCadastro.TabIndex = 58;
            this.btnCadastro.Text = "Cadastrar Hospedagem";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click_1);
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(12, 147);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(49, 13);
            this.lblDtInicio.TabIndex = 57;
            this.lblDtInicio.Text = "Check-in";
            // 
            // dtpDtInicio
            // 
            this.dtpDtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDtInicio.Location = new System.Drawing.Point(15, 164);
            this.dtpDtInicio.Name = "dtpDtInicio";
            this.dtpDtInicio.Size = new System.Drawing.Size(130, 20);
            this.dtpDtInicio.TabIndex = 56;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 55;
            this.lblNome.Text = "Animal";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 54;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 53;
            this.lblID.Text = "Hospedagem";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(121, 23);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 52;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click_1);
            // 
            // FormHospedagemCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 518);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDtFim);
            this.Controls.Add(this.cbxAnimal);
            this.Controls.Add(this.dgvPet);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirPet);
            this.Controls.Add(this.btnAttPet);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblDtInicio);
            this.Controls.Add(this.dtpDtInicio);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLocalizar);
            this.Name = "FormHospedagemCliente";
            this.Text = "FormHospedagemCliente";
            this.Load += new System.EventHandler(this.FormHospedagemCliente_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDtFim;
        private System.Windows.Forms.ComboBox cbxAnimal;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluirPet;
        private System.Windows.Forms.Button btnAttPet;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.DateTimePicker dtpDtInicio;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLocalizar;
    }
}