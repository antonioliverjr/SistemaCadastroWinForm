
namespace SistemaCadastroWinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.DateTimePicker();
            this.txt_estado_civil = new System.Windows.Forms.ComboBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.check_casa = new System.Windows.Forms.CheckBox();
            this.check_veiculo = new System.Windows.Forms.CheckBox();
            this.tp_sexo = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_sexo.SuspendLayout();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(185, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(459, 23);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(185, 69);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(459, 23);
            this.txt_data.TabIndex = 5;
            // 
            // txt_estado_civil
            // 
            this.txt_estado_civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado_civil.FormattingEnabled = true;
            this.txt_estado_civil.Location = new System.Drawing.Point(185, 102);
            this.txt_estado_civil.Name = "txt_estado_civil";
            this.txt_estado_civil.Size = new System.Drawing.Size(459, 24);
            this.txt_estado_civil.TabIndex = 6;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(185, 135);
            this.txt_telefone.Mask = "(99) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(459, 23);
            this.txt_telefone.TabIndex = 7;
            // 
            // check_casa
            // 
            this.check_casa.AutoSize = true;
            this.check_casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_casa.Location = new System.Drawing.Point(190, 188);
            this.check_casa.Name = "check_casa";
            this.check_casa.Size = new System.Drawing.Size(139, 17);
            this.check_casa.TabIndex = 8;
            this.check_casa.Text = "Possui Casa Própria";
            this.check_casa.UseVisualStyleBackColor = true;
            // 
            // check_veiculo
            // 
            this.check_veiculo.AutoSize = true;
            this.check_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_veiculo.Location = new System.Drawing.Point(353, 188);
            this.check_veiculo.Name = "check_veiculo";
            this.check_veiculo.Size = new System.Drawing.Size(111, 17);
            this.check_veiculo.TabIndex = 9;
            this.check_veiculo.Text = "Possui Veículo";
            this.check_veiculo.UseVisualStyleBackColor = true;
            // 
            // tp_sexo
            // 
            this.tp_sexo.Controls.Add(this.radioO);
            this.tp_sexo.Controls.Add(this.radioF);
            this.tp_sexo.Controls.Add(this.radioM);
            this.tp_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_sexo.Location = new System.Drawing.Point(190, 225);
            this.tp_sexo.Name = "tp_sexo";
            this.tp_sexo.Size = new System.Drawing.Size(454, 65);
            this.tp_sexo.TabIndex = 10;
            this.tp_sexo.TabStop = false;
            this.tp_sexo.Text = "Sexo";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioO.Location = new System.Drawing.Point(298, 31);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(139, 17);
            this.radioO.TabIndex = 2;
            this.radioO.TabStop = true;
            this.radioO.Text = "Prefiro Não Informar";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioF.Location = new System.Drawing.Point(162, 31);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(75, 17);
            this.radioF.TabIndex = 1;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioM.Location = new System.Drawing.Point(19, 31);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(82, 17);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(24, 310);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(620, 129);
            this.lista.TabIndex = 11;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(24, 170);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(133, 34);
            this.btn_salvar.TabIndex = 12;
            this.btn_salvar.Text = "Cadastrar/Alterar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(26, 258);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(133, 34);
            this.btn_excluir.TabIndex = 13;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(25, 213);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(133, 34);
            this.btn_limpar.TabIndex = 14;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreMenuForm});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.Size = new System.Drawing.Size(670, 25);
            this.menuForm.TabIndex = 15;
            this.menuForm.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoMenuForm,
            this.sairMenuForm});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoMenuForm
            // 
            this.novoMenuForm.Name = "novoMenuForm";
            this.novoMenuForm.Size = new System.Drawing.Size(109, 22);
            this.novoMenuForm.Text = "Novo";
            this.novoMenuForm.Click += new System.EventHandler(this.novoMenuForm_Click);
            // 
            // sairMenuForm
            // 
            this.sairMenuForm.Name = "sairMenuForm";
            this.sairMenuForm.Size = new System.Drawing.Size(109, 22);
            this.sairMenuForm.Text = "Sair";
            this.sairMenuForm.Click += new System.EventHandler(this.sairMenuForm_Click);
            // 
            // sobreMenuForm
            // 
            this.sobreMenuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenuForm});
            this.sobreMenuForm.Name = "sobreMenuForm";
            this.sobreMenuForm.Size = new System.Drawing.Size(55, 21);
            this.sobreMenuForm.Text = "Sobre";
            // 
            // infoMenuForm
            // 
            this.infoMenuForm.Name = "infoMenuForm";
            this.infoMenuForm.Size = new System.Drawing.Size(180, 22);
            this.infoMenuForm.Text = "Info";
            this.infoMenuForm.Click += new System.EventHandler(this.infoMenuForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.tp_sexo);
            this.Controls.Add(this.check_veiculo);
            this.Controls.Add(this.check_casa);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_estado_civil);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuForm;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tp_sexo.ResumeLayout(false);
            this.tp_sexo.PerformLayout();
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DateTimePicker txt_data;
        private System.Windows.Forms.ComboBox txt_estado_civil;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.CheckBox check_casa;
        private System.Windows.Forms.CheckBox check_veiculo;
        private System.Windows.Forms.GroupBox tp_sexo;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoMenuForm;
        private System.Windows.Forms.ToolStripMenuItem sairMenuForm;
        private System.Windows.Forms.ToolStripMenuItem sobreMenuForm;
        private System.Windows.Forms.ToolStripMenuItem infoMenuForm;
    }
}

