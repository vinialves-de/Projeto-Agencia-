
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaCadastrarPacote
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpIda = new System.Windows.Forms.DateTimePicker();
            this.dtpVolta = new System.Windows.Forms.DateTimePicker();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbOrigem = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Ida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Volta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(179, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cadastro de Pacote";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descrição:";
            // 
            // dtpIda
            // 
            this.dtpIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIda.Location = new System.Drawing.Point(83, 209);
            this.dtpIda.Name = "dtpIda";
            this.dtpIda.Size = new System.Drawing.Size(200, 23);
            this.dtpIda.TabIndex = 7;
            // 
            // dtpVolta
            // 
            this.dtpVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVolta.Location = new System.Drawing.Point(83, 248);
            this.dtpVolta.Name = "dtpVolta";
            this.dtpVolta.Size = new System.Drawing.Size(200, 23);
            this.dtpVolta.TabIndex = 8;
            // 
            // pbxImagem
            // 
            this.pbxImagem.Location = new System.Drawing.Point(355, 254);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(239, 144);
            this.pbxImagem.TabIndex = 9;
            this.pbxImagem.TabStop = false;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(83, 74);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(100, 23);
            this.tbxValor.TabIndex = 10;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(355, 78);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(239, 154);
            this.rtbDescricao.TabIndex = 13;
            this.rtbDescricao.Text = "";
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(436, 404);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(105, 23);
            this.btnImagem.TabIndex = 14;
            this.btnImagem.Text = "Buscar Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(122, 330);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbOrigem
            // 
            this.cmbOrigem.FormattingEnabled = true;
            this.cmbOrigem.Location = new System.Drawing.Point(83, 119);
            this.cmbOrigem.Name = "cmbOrigem";
            this.cmbOrigem.Size = new System.Drawing.Size(200, 23);
            this.cmbOrigem.TabIndex = 16;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(84, 163);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(199, 23);
            this.cmbDestino.TabIndex = 17;
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialogImagem";
            // 
            // TelaCadastrarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(606, 444);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigem);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.dtpVolta);
            this.Controls.Add(this.dtpIda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "TelaCadastrarPacote";
            this.Text = "TelaCadastrarPacote";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCadastrarPacote_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpIda;
        private System.Windows.Forms.DateTimePicker dtpVolta;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbOrigem;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
    }
}