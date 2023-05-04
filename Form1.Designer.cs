namespace TrabalhoPratico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_titulo = new Label();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            lbl_registro = new Label();
            txt_registro = new TextBox();
            rdb_fpublico = new RadioButton();
            rdb_fcontratado = new RadioButton();
            lbl_salariobase = new Label();
            txt_salariobase = new TextBox();
            lbl_inss = new Label();
            label2 = new Label();
            txt_planosaude = new TextBox();
            lbl_valorsalarioliq = new Label();
            lbl_resultado = new Label();
            btn_calcular = new Button();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // txt_titulo
            // 
            txt_titulo.AutoSize = true;
            txt_titulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_titulo.Location = new Point(129, 23);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(160, 20);
            txt_titulo.TabIndex = 0;
            txt_titulo.Text = "Simulador de salários";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nome.Location = new Point(16, 100);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(193, 16);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome completo do funcionário:";
            // 
            // txt_nome
            // 
            txt_nome.Cursor = Cursors.IBeam;
            txt_nome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.ForeColor = SystemColors.WindowText;
            txt_nome.Location = new Point(19, 127);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(203, 22);
            txt_nome.TabIndex = 2;
            // 
            // lbl_registro
            // 
            lbl_registro.AutoSize = true;
            lbl_registro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_registro.Location = new Point(16, 166);
            lbl_registro.Name = "lbl_registro";
            lbl_registro.Size = new Size(168, 16);
            lbl_registro.TabIndex = 3;
            lbl_registro.Text = "Insira o número de registro:";
            // 
            // txt_registro
            // 
            txt_registro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_registro.ForeColor = SystemColors.WindowText;
            txt_registro.Location = new Point(19, 194);
            txt_registro.Name = "txt_registro";
            txt_registro.Size = new Size(203, 22);
            txt_registro.TabIndex = 4;
            // 
            // rdb_fpublico
            // 
            rdb_fpublico.AutoSize = true;
            rdb_fpublico.Cursor = Cursors.Hand;
            rdb_fpublico.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdb_fpublico.Location = new Point(249, 60);
            rdb_fpublico.Name = "rdb_fpublico";
            rdb_fpublico.Size = new Size(143, 20);
            rdb_fpublico.TabIndex = 5;
            rdb_fpublico.TabStop = true;
            rdb_fpublico.Text = "Funcionário Público";
            rdb_fpublico.UseVisualStyleBackColor = true;
            rdb_fpublico.CheckedChanged += rdb_fpublico_CheckedChanged;
            // 
            // rdb_fcontratado
            // 
            rdb_fcontratado.AutoSize = true;
            rdb_fcontratado.Cursor = Cursors.Hand;
            rdb_fcontratado.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdb_fcontratado.Location = new Point(19, 60);
            rdb_fcontratado.Name = "rdb_fcontratado";
            rdb_fcontratado.Size = new Size(164, 20);
            rdb_fcontratado.TabIndex = 6;
            rdb_fcontratado.TabStop = true;
            rdb_fcontratado.Text = "Funcionário Contratado";
            rdb_fcontratado.UseVisualStyleBackColor = true;
            rdb_fcontratado.CheckedChanged += rdb_fcontratado_CheckedChanged;
            // 
            // lbl_salariobase
            // 
            lbl_salariobase.AutoSize = true;
            lbl_salariobase.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_salariobase.Location = new Point(247, 166);
            lbl_salariobase.Name = "lbl_salariobase";
            lbl_salariobase.Size = new Size(87, 16);
            lbl_salariobase.TabIndex = 7;
            lbl_salariobase.Text = "Salário base:";
            // 
            // txt_salariobase
            // 
            txt_salariobase.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_salariobase.Location = new Point(249, 127);
            txt_salariobase.Name = "txt_salariobase";
            txt_salariobase.Size = new Size(142, 22);
            txt_salariobase.TabIndex = 8;
            // 
            // lbl_inss
            // 
            lbl_inss.AutoSize = true;
            lbl_inss.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_inss.Location = new Point(16, 284);
            lbl_inss.Name = "lbl_inss";
            lbl_inss.Size = new Size(206, 15);
            lbl_inss.TabIndex = 10;
            lbl_inss.Text = "*Alíquota do INSS em 18% aplicada.";
            lbl_inss.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(247, 100);
            label2.Name = "label2";
            label2.Size = new Size(105, 16);
            label2.TabIndex = 11;
            label2.Text = "Plano de saúde:";
            // 
            // txt_planosaude
            // 
            txt_planosaude.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_planosaude.Location = new Point(249, 194);
            txt_planosaude.Name = "txt_planosaude";
            txt_planosaude.Size = new Size(142, 22);
            txt_planosaude.TabIndex = 12;
            // 
            // lbl_valorsalarioliq
            // 
            lbl_valorsalarioliq.AutoSize = true;
            lbl_valorsalarioliq.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valorsalarioliq.Location = new Point(19, 242);
            lbl_valorsalarioliq.Name = "lbl_valorsalarioliq";
            lbl_valorsalarioliq.Size = new Size(283, 17);
            lbl_valorsalarioliq.TabIndex = 13;
            lbl_valorsalarioliq.Text = "O valor do salário líquido calculado é de R$";
            lbl_valorsalarioliq.Visible = false;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_resultado.Location = new Point(299, 241);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(57, 18);
            lbl_resultado.TabIndex = 15;
            lbl_resultado.Text = "Xxxx,xx";
            lbl_resultado.TextAlign = ContentAlignment.MiddleLeft;
            lbl_resultado.Visible = false;
            // 
            // btn_calcular
            // 
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calcular.Location = new Point(311, 277);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(80, 30);
            btn_calcular.TabIndex = 16;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_limpar.Location = new Point(228, 277);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(80, 30);
            btn_limpar.TabIndex = 17;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(414, 331);
            Controls.Add(btn_limpar);
            Controls.Add(btn_calcular);
            Controls.Add(lbl_valorsalarioliq);
            Controls.Add(txt_planosaude);
            Controls.Add(label2);
            Controls.Add(lbl_inss);
            Controls.Add(txt_salariobase);
            Controls.Add(lbl_salariobase);
            Controls.Add(rdb_fcontratado);
            Controls.Add(rdb_fpublico);
            Controls.Add(txt_registro);
            Controls.Add(lbl_registro);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(txt_titulo);
            Controls.Add(lbl_resultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "SimuSalario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_titulo;
        private Label lbl_nome;
        private TextBox txt_nome;
        private Label lbl_registro;
        private TextBox txt_registro;
        private RadioButton rdb_fpublico;
        private RadioButton rdb_fcontratado;
        private Label lbl_salariobase;
        private TextBox txt_salariobase;
        private Label lbl_inss;
        private Label label2;
        private TextBox txt_planosaude;
        private Label lbl_valorsalarioliq;
        private Label lbl_resultado;
        private Button btn_calcular;
        private Button btn_limpar;
    }
}