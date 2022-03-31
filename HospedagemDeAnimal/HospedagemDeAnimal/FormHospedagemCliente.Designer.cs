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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Thistle;
            this.btnConfirmar.Location = new System.Drawing.Point(490, 241);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(264, 23);
            this.btnConfirmar.TabIndex = 68;
            this.btnConfirmar.Text = "Confirmar Hospedagem";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Check-out";
            // 
            // dtpDtFim
            // 
            this.dtpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtFim.Location = new System.Drawing.Point(257, 176);
            this.dtpDtFim.Name = "dtpDtFim";
            this.dtpDtFim.Size = new System.Drawing.Size(180, 20);
            this.dtpDtFim.TabIndex = 66;
            // 
            // cbxAnimal
            // 
            this.cbxAnimal.FormattingEnabled = true;
            this.cbxAnimal.Location = new System.Drawing.Point(15, 108);
            this.cbxAnimal.Name = "cbxAnimal";
            this.cbxAnimal.Size = new System.Drawing.Size(423, 21);
            this.cbxAnimal.TabIndex = 65;
            // 
            // dgvPet
            // 
            this.dgvPet.AllowUserToAddRows = false;
            this.dgvPet.AllowUserToDeleteRows = false;
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.GridColor = System.Drawing.Color.Thistle;
            this.dgvPet.Location = new System.Drawing.Point(10, 306);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.ReadOnly = true;
            this.dgvPet.Size = new System.Drawing.Size(744, 199);
            this.dgvPet.TabIndex = 62;
            this.dgvPet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPet_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(636, 270);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 23);
            this.btnVoltar.TabIndex = 61;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluirPet
            // 
            this.btnExcluirPet.Location = new System.Drawing.Point(490, 270);
            this.btnExcluirPet.Name = "btnExcluirPet";
            this.btnExcluirPet.Size = new System.Drawing.Size(140, 23);
            this.btnExcluirPet.TabIndex = 60;
            this.btnExcluirPet.Text = "Excluir Hospedagem";
            this.btnExcluirPet.UseVisualStyleBackColor = true;
            this.btnExcluirPet.Click += new System.EventHandler(this.btnExcluirPet_Click_1);
            // 
            // btnAttPet
            // 
            this.btnAttPet.BackColor = System.Drawing.Color.Thistle;
            this.btnAttPet.Location = new System.Drawing.Point(490, 212);
            this.btnAttPet.Name = "btnAttPet";
            this.btnAttPet.Size = new System.Drawing.Size(264, 23);
            this.btnAttPet.TabIndex = 59;
            this.btnAttPet.Text = "Editar Hospedagem";
            this.btnAttPet.UseVisualStyleBackColor = false;
            this.btnAttPet.Click += new System.EventHandler(this.btnAttPet_Click_1);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Thistle;
            this.btnCadastro.Location = new System.Drawing.Point(490, 183);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(264, 23);
            this.btnCadastro.TabIndex = 58;
            this.btnCadastro.Text = "Cadastrar Hospedagem";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click_1);
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(12, 159);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(49, 13);
            this.lblDtInicio.TabIndex = 57;
            this.lblDtInicio.Text = "Check-in";
            // 
            // dtpDtInicio
            // 
            this.dtpDtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDtInicio.Location = new System.Drawing.Point(15, 176);
            this.dtpDtInicio.Name = "dtpDtInicio";
            this.dtpDtInicio.Size = new System.Drawing.Size(181, 20);
            this.dtpDtInicio.TabIndex = 56;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 55;
            this.lblNome.Text = "Animal";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 20);
            this.txtID.TabIndex = 54;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 53;
            this.lblID.Text = "Hospedagem";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Thistle;
            this.btnLocalizar.Location = new System.Drawing.Point(202, 39);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 52;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospedagemDeAnimal.Properties.Resources._9b15800648867d00a7c9054dff041710;
            this.pictureBox1.Location = new System.Drawing.Point(490, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Atenção!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "A entrada e saida de pets ocorrem no nosso horário comercial.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Horário de funcionamento: das 8:00 às 19:00.";
            // 
            // FormHospedagemCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(766, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minhas Hospedagens";
            this.Load += new System.EventHandler(this.FormHospedagemCliente_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}