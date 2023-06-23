namespace RevisaoForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.tx_salvar = new System.Windows.Forms.Button();
            this.tx_cancelar = new System.Windows.Forms.Button();
            this.lb_confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(171, 156);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(267, 20);
            this.tx_nome.TabIndex = 2;
            this.tx_nome.TextChanged += new System.EventHandler(this.tx_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(538, 156);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(178, 20);
            this.tx_cpf.TabIndex = 4;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_cpf_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "EMAIL";
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(171, 225);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(267, 20);
            this.tx_email.TabIndex = 6;
            this.tx_email.TextChanged += new System.EventHandler(this.tx_email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "SALÁRIO";
            // 
            // tx_salario
            // 
            this.tx_salario.Location = new System.Drawing.Point(182, 299);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(75, 20);
            this.tx_salario.TabIndex = 8;
            this.tx_salario.TextChanged += new System.EventHandler(this.tx_salario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "FUNÇÃO";
            // 
            // tx_funcao
            // 
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Médico",
            "TI",
            "Adm"});
            this.tx_funcao.Location = new System.Drawing.Point(546, 298);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(132, 21);
            this.tx_funcao.TabIndex = 10;
            this.tx_funcao.SelectedIndexChanged += new System.EventHandler(this.tx_tipo_SelectedIndexChanged);
            // 
            // tx_salvar
            // 
            this.tx_salvar.Location = new System.Drawing.Point(679, 396);
            this.tx_salvar.Name = "tx_salvar";
            this.tx_salvar.Size = new System.Drawing.Size(80, 33);
            this.tx_salvar.TabIndex = 11;
            this.tx_salvar.Text = "SALVAR";
            this.tx_salvar.UseVisualStyleBackColor = true;
            this.tx_salvar.Click += new System.EventHandler(this.tx_salvar_Click);
            // 
            // tx_cancelar
            // 
            this.tx_cancelar.Location = new System.Drawing.Point(23, 396);
            this.tx_cancelar.Name = "tx_cancelar";
            this.tx_cancelar.Size = new System.Drawing.Size(80, 33);
            this.tx_cancelar.TabIndex = 12;
            this.tx_cancelar.Text = "CANCELAR";
            this.tx_cancelar.UseVisualStyleBackColor = true;
            this.tx_cancelar.Click += new System.EventHandler(this.tx_cancelar_Click);
            // 
            // lb_confirm
            // 
            this.lb_confirm.AutoSize = true;
            this.lb_confirm.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirm.Location = new System.Drawing.Point(324, 354);
            this.lb_confirm.Name = "lb_confirm";
            this.lb_confirm.Size = new System.Drawing.Size(155, 20);
            this.lb_confirm.TabIndex = 13;
            this.lb_confirm.Text = "SALÁRIO FINAL";
            this.lb_confirm.Click += new System.EventHandler(this.lb_confirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_confirm);
            this.Controls.Add(this.tx_cancelar);
            this.Controls.Add(this.tx_salvar);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tx_funcao;
        private System.Windows.Forms.Button tx_salvar;
        private System.Windows.Forms.Button tx_cancelar;
        private System.Windows.Forms.Label lb_confirm;
    }
}

