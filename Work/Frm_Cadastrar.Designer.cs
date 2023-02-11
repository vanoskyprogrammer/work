
namespace Work
{
    partial class Frm_Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastrar));
            this.bnt_Editar = new System.Windows.Forms.Button();
            this.Remover_bnt = new System.Windows.Forms.Button();
            this.bnt_Pesquisar = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnt_cadastrar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cbm_funcao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_Editar
            // 
            this.bnt_Editar.Location = new System.Drawing.Point(456, 193);
            this.bnt_Editar.Name = "bnt_Editar";
            this.bnt_Editar.Size = new System.Drawing.Size(65, 23);
            this.bnt_Editar.TabIndex = 40;
            this.bnt_Editar.Text = "Editar";
            this.bnt_Editar.UseVisualStyleBackColor = true;
            this.bnt_Editar.Click += new System.EventHandler(this.bnt_Editar_Click);
            // 
            // Remover_bnt
            // 
            this.Remover_bnt.Location = new System.Drawing.Point(350, 193);
            this.Remover_bnt.Name = "Remover_bnt";
            this.Remover_bnt.Size = new System.Drawing.Size(65, 23);
            this.Remover_bnt.TabIndex = 39;
            this.Remover_bnt.Text = "Remover ";
            this.Remover_bnt.UseVisualStyleBackColor = true;
            this.Remover_bnt.Click += new System.EventHandler(this.Remover_bnt_Click);
            // 
            // bnt_Pesquisar
            // 
            this.bnt_Pesquisar.Location = new System.Drawing.Point(219, 193);
            this.bnt_Pesquisar.Name = "bnt_Pesquisar";
            this.bnt_Pesquisar.Size = new System.Drawing.Size(82, 23);
            this.bnt_Pesquisar.TabIndex = 38;
            this.bnt_Pesquisar.Text = "Pesquisar";
            this.bnt_Pesquisar.UseVisualStyleBackColor = true;
            this.bnt_Pesquisar.Click += new System.EventHandler(this.bnt_Pesquisar_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(15, 236);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(642, 140);
            this.dgv_dados.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // bnt_cadastrar
            // 
            this.bnt_cadastrar.Location = new System.Drawing.Point(78, 193);
            this.bnt_cadastrar.Name = "bnt_cadastrar";
            this.bnt_cadastrar.Size = new System.Drawing.Size(82, 23);
            this.bnt_cadastrar.TabIndex = 35;
            this.bnt_cadastrar.Text = "Cadastrar";
            this.bnt_cadastrar.UseVisualStyleBackColor = true;
            this.bnt_cadastrar.Click += new System.EventHandler(this.bnt_cadastrar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(59, 115);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 34;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(78, 70);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 33;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(104, 24);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 32;
            // 
            // cbm_funcao
            // 
            this.cbm_funcao.FormattingEnabled = true;
            this.cbm_funcao.Items.AddRange(new object[] {
            "ADM",
            "Oc."});
            this.cbm_funcao.Location = new System.Drawing.Point(61, 156);
            this.cbm_funcao.Name = "cbm_funcao";
            this.cbm_funcao.Size = new System.Drawing.Size(121, 21);
            this.cbm_funcao.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Função";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome Completo";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(282, 21);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(119, 20);
            this.txt_id.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Id";
            // 
            // Frm_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 386);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.bnt_Editar);
            this.Controls.Add(this.Remover_bnt);
            this.Controls.Add(this.bnt_Pesquisar);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnt_cadastrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.cbm_funcao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Cadastrar";
            this.Text = "Frm_Cadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_Editar;
        private System.Windows.Forms.Button Remover_bnt;
        private System.Windows.Forms.Button bnt_Pesquisar;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bnt_cadastrar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cbm_funcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
    }
}