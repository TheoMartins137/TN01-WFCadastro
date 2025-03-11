namespace TN01_WFCadastrar
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            mns_cadastrar = new ToolStripMenuItem();
            mns_sobre = new ToolStripMenuItem();
            mns_sair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mns_cadastrar, mns_sobre, mns_sair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(483, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mns_cadastrar
            // 
            mns_cadastrar.Name = "mns_cadastrar";
            mns_cadastrar.Size = new Size(69, 20);
            mns_cadastrar.Text = "Cadastrar";
            mns_cadastrar.Click += mns_cadastrar_Click;
            // 
            // mns_sobre
            // 
            mns_sobre.Name = "mns_sobre";
            mns_sobre.Size = new Size(49, 20);
            mns_sobre.Text = "Sobre";
            // 
            // mns_sair
            // 
            mns_sair.Name = "mns_sair";
            mns_sair.Size = new Size(38, 20);
            mns_sair.Text = "Sair";
            mns_sair.Click += mns_sair_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 360);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mns_cadastrar;
        private ToolStripMenuItem mns_sobre;
        private ToolStripMenuItem mns_sair;
    }
}