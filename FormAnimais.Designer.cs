
namespace PetTech
{
    partial class FormAnimais
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
            this.dgvAnimais = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.cbxPorte = new System.Windows.Forms.ComboBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.lblDatanascimento = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDanimal = new System.Windows.Forms.Label();
            this.txtDatanascimento = new System.Windows.Forms.TextBox();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.cbxPelagem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimais
            // 
            this.dgvAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimais.Location = new System.Drawing.Point(12, 180);
            this.dgvAnimais.Name = "dgvAnimais";
            this.dgvAnimais.Size = new System.Drawing.Size(431, 168);
            this.dgvAnimais.TabIndex = 51;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(368, 111);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 50;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(368, 81);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 49;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(368, 52);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 48;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(368, 23);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 47;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Location = new System.Drawing.Point(125, 23);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 46;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // cbxPorte
            // 
            this.cbxPorte.FormattingEnabled = true;
            this.cbxPorte.Items.AddRange(new object[] {
            "Mini",
            "Pequeno",
            "Médio",
            "Grande",
            "Gigante"});
            this.cbxPorte.Location = new System.Drawing.Point(125, 142);
            this.cbxPorte.Name = "cbxPorte";
            this.cbxPorte.Size = new System.Drawing.Size(109, 21);
            this.cbxPorte.TabIndex = 45;
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Femea",
            "Macho"});
            this.cbxSexo.Location = new System.Drawing.Point(241, 142);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(109, 21);
            this.cbxSexo.TabIndex = 44;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(125, 87);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 42;
            this.lblEspecie.Text = "Espécie";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(242, 126);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 41;
            this.lblSexo.Text = "Sexo";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Location = new System.Drawing.Point(125, 126);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(32, 13);
            this.lblPorte.TabIndex = 40;
            this.lblPorte.Text = "Porte";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(12, 142);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(108, 20);
            this.txtPeso.TabIndex = 39;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 126);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 38;
            this.lblPeso.Text = "Peso";
            // 
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.Location = new System.Drawing.Point(242, 87);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Size = new System.Drawing.Size(48, 13);
            this.lblPelagem.TabIndex = 36;
            this.lblPelagem.Text = "Pelagem";
            // 
            // lblDatanascimento
            // 
            this.lblDatanascimento.AutoSize = true;
            this.lblDatanascimento.Location = new System.Drawing.Point(12, 87);
            this.lblDatanascimento.Name = "lblDatanascimento";
            this.lblDatanascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDatanascimento.TabIndex = 34;
            this.lblDatanascimento.Text = "Data de Nascimento";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(242, 64);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(108, 20);
            this.txtRaca.TabIndex = 33;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(242, 48);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 32;
            this.lblRaca.Text = "Raça";
            // 
            // txtNome
            // 
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNome.Location = new System.Drawing.Point(12, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 20);
            this.txtNome.TabIndex = 31;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 20);
            this.txtID.TabIndex = 29;
            // 
            // lblIDanimal
            // 
            this.lblIDanimal.AutoSize = true;
            this.lblIDanimal.Location = new System.Drawing.Point(12, 9);
            this.lblIDanimal.Name = "lblIDanimal";
            this.lblIDanimal.Size = new System.Drawing.Size(18, 13);
            this.lblIDanimal.TabIndex = 28;
            this.lblIDanimal.Text = "ID";
            // 
            // txtDatanascimento
            // 
            this.txtDatanascimento.Location = new System.Drawing.Point(13, 103);
            this.txtDatanascimento.Name = "txtDatanascimento";
            this.txtDatanascimento.Size = new System.Drawing.Size(108, 20);
            this.txtDatanascimento.TabIndex = 52;
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Items.AddRange(new object[] {
            "Cão",
            "Gato"});
            this.cbxEspecie.Location = new System.Drawing.Point(128, 103);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(109, 21);
            this.cbxEspecie.TabIndex = 53;
            // 
            // cbxPelagem
            // 
            this.cbxPelagem.FormattingEnabled = true;
            this.cbxPelagem.Items.AddRange(new object[] {
            "Curto",
            "Medio",
            "Longo"});
            this.cbxPelagem.Location = new System.Drawing.Point(241, 103);
            this.cbxPelagem.Name = "cbxPelagem";
            this.cbxPelagem.Size = new System.Drawing.Size(109, 21);
            this.cbxPelagem.TabIndex = 54;
            // 
            // FormAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 358);
            this.Controls.Add(this.cbxPelagem);
            this.Controls.Add(this.cbxEspecie);
            this.Controls.Add(this.txtDatanascimento);
            this.Controls.Add(this.dgvAnimais);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.cbxPorte);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblPelagem);
            this.Controls.Add(this.lblDatanascimento);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDanimal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnimais";
            this.Load += new System.EventHandler(this.FormAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimais;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ComboBox cbxPorte;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.Label lblDatanascimento;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDanimal;
        private System.Windows.Forms.TextBox txtDatanascimento;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.ComboBox cbxPelagem;
    }
}