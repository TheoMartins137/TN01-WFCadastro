namespace TN01_WFCadastrar
{
    partial class FormCadastro
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
            lbl_nome = new Label();
            txt_nome = new TextBox();
            lbl_telefone = new Label();
            mkd_telefone = new MaskedTextBox();
            lbl_datanasc = new Label();
            dtp_datanasc = new DateTimePicker();
            lbl_escolaridade = new Label();
            cbx_escolaridade = new ComboBox();
            gbx_sexo = new GroupBox();
            rdb_naoinformado = new RadioButton();
            rdb_feminino = new RadioButton();
            rdb_masculino = new RadioButton();
            lbl_renda = new Label();
            nup_renda = new NumericUpDown();
            chk_filhos = new CheckBox();
            btn_confirmar = new Button();
            gbx_sexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_renda).BeginInit();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(12, 9);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(96, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome Completo";
            lbl_nome.Click += label1_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(12, 27);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(330, 23);
            txt_nome.TabIndex = 1;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(12, 65);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(51, 15);
            lbl_telefone.TabIndex = 2;
            lbl_telefone.Text = "Telefone";
            // 
            // mkd_telefone
            // 
            mkd_telefone.Location = new Point(12, 83);
            mkd_telefone.Mask = "(00) 90000-000";
            mkd_telefone.Name = "mkd_telefone";
            mkd_telefone.Size = new Size(144, 23);
            mkd_telefone.TabIndex = 2;
            // 
            // lbl_datanasc
            // 
            lbl_datanasc.AutoSize = true;
            lbl_datanasc.Location = new Point(228, 65);
            lbl_datanasc.Name = "lbl_datanasc";
            lbl_datanasc.Size = new Size(114, 15);
            lbl_datanasc.TabIndex = 4;
            lbl_datanasc.Text = "Data de Nascimento";
            // 
            // dtp_datanasc
            // 
            dtp_datanasc.Format = DateTimePickerFormat.Short;
            dtp_datanasc.Location = new Point(228, 83);
            dtp_datanasc.Name = "dtp_datanasc";
            dtp_datanasc.Size = new Size(114, 23);
            dtp_datanasc.TabIndex = 3;
            // 
            // lbl_escolaridade
            // 
            lbl_escolaridade.AutoSize = true;
            lbl_escolaridade.Location = new Point(12, 131);
            lbl_escolaridade.Name = "lbl_escolaridade";
            lbl_escolaridade.Size = new Size(73, 15);
            lbl_escolaridade.TabIndex = 6;
            lbl_escolaridade.Text = "Escolaridade";
            // 
            // cbx_escolaridade
            // 
            cbx_escolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_escolaridade.FormattingEnabled = true;
            cbx_escolaridade.Items.AddRange(new object[] { "Analfabeto", "Ensino Fundamental Incompleto", "Ensino Fundamental Completo", "Ensino Médio Incompleto", "Ensino Médio Completo", "Ensino Técnico Incompleto", "Ensino Técnico Completo", "Ensino Superior Incompleto", "Ensino Superior Completo", "Pós-Graduação Incompleto", "Pós-Graduação Completo" });
            cbx_escolaridade.Location = new Point(12, 149);
            cbx_escolaridade.Name = "cbx_escolaridade";
            cbx_escolaridade.Size = new Size(330, 23);
            cbx_escolaridade.TabIndex = 4;
            // 
            // gbx_sexo
            // 
            gbx_sexo.Controls.Add(rdb_naoinformado);
            gbx_sexo.Controls.Add(rdb_feminino);
            gbx_sexo.Controls.Add(rdb_masculino);
            gbx_sexo.Location = new Point(12, 193);
            gbx_sexo.Name = "gbx_sexo";
            gbx_sexo.Size = new Size(144, 103);
            gbx_sexo.TabIndex = 5;
            gbx_sexo.TabStop = false;
            gbx_sexo.Text = "Sexo";
            // 
            // rdb_naoinformado
            // 
            rdb_naoinformado.AutoSize = true;
            rdb_naoinformado.Location = new Point(4, 72);
            rdb_naoinformado.Name = "rdb_naoinformado";
            rdb_naoinformado.Size = new Size(134, 19);
            rdb_naoinformado.TabIndex = 2;
            rdb_naoinformado.TabStop = true;
            rdb_naoinformado.Text = "Prefiro Não Informar";
            rdb_naoinformado.UseVisualStyleBackColor = true;
            // 
            // rdb_feminino
            // 
            rdb_feminino.AutoSize = true;
            rdb_feminino.Location = new Point(4, 47);
            rdb_feminino.Name = "rdb_feminino";
            rdb_feminino.Size = new Size(75, 19);
            rdb_feminino.TabIndex = 1;
            rdb_feminino.TabStop = true;
            rdb_feminino.Text = "Feminino";
            rdb_feminino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            rdb_masculino.AutoSize = true;
            rdb_masculino.Location = new Point(4, 22);
            rdb_masculino.Name = "rdb_masculino";
            rdb_masculino.Size = new Size(80, 19);
            rdb_masculino.TabIndex = 0;
            rdb_masculino.TabStop = true;
            rdb_masculino.Text = "Masculino";
            rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // lbl_renda
            // 
            lbl_renda.AutoSize = true;
            lbl_renda.Location = new Point(216, 215);
            lbl_renda.Name = "lbl_renda";
            lbl_renda.Size = new Size(81, 15);
            lbl_renda.TabIndex = 9;
            lbl_renda.Text = "Renda Mensal";
            // 
            // nup_renda
            // 
            nup_renda.DecimalPlaces = 2;
            nup_renda.Location = new Point(216, 236);
            nup_renda.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nup_renda.Name = "nup_renda";
            nup_renda.Size = new Size(120, 23);
            nup_renda.TabIndex = 6;
            // 
            // chk_filhos
            // 
            chk_filhos.AutoSize = true;
            chk_filhos.Checked = true;
            chk_filhos.CheckState = CheckState.Indeterminate;
            chk_filhos.Location = new Point(216, 277);
            chk_filhos.Name = "chk_filhos";
            chk_filhos.Size = new Size(99, 19);
            chk_filhos.TabIndex = 7;
            chk_filhos.Text = "Possui Filhos?";
            chk_filhos.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(12, 324);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(330, 23);
            btn_confirmar.TabIndex = 8;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 375);
            Controls.Add(btn_confirmar);
            Controls.Add(chk_filhos);
            Controls.Add(nup_renda);
            Controls.Add(lbl_renda);
            Controls.Add(gbx_sexo);
            Controls.Add(cbx_escolaridade);
            Controls.Add(lbl_escolaridade);
            Controls.Add(dtp_datanasc);
            Controls.Add(lbl_datanasc);
            Controls.Add(mkd_telefone);
            Controls.Add(lbl_telefone);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            gbx_sexo.ResumeLayout(false);
            gbx_sexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_renda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private TextBox txt_nome;
        private Label lbl_telefone;
        private MaskedTextBox mkd_telefone;
        private Label lbl_datanasc;
        private DateTimePicker dtp_datanasc;
        private Label lbl_escolaridade;
        private ComboBox cbx_escolaridade;
        private GroupBox gbx_sexo;
        private RadioButton rdb_naoinformado;
        private RadioButton rdb_feminino;
        private RadioButton rdb_masculino;
        private Label lbl_renda;
        private NumericUpDown nup_renda;
        private CheckBox chk_filhos;
        private Button btn_confirmar;
    }
}