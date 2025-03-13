namespace CodeFormatter13.UI
{
    partial class CodeFormatter13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeFormatter13));
            splitContainer1 = new SplitContainer();
            splitter1 = new Splitter();
            rtbLista = new RichTextBox();
            label1 = new Label();
            btnFormater = new Button();
            label4 = new Label();
            rtbVariaveisRetorno = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            rtbVariaveis = new RichTextBox();
            rtbCodigoValidacao = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitter1);
            splitContainer1.Panel1.Controls.Add(rtbLista);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnFormater);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(rtbVariaveisRetorno);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(rtbVariaveis);
            splitContainer1.Panel2.Controls.Add(rtbCodigoValidacao);
            splitContainer1.Size = new Size(1213, 954);
            splitContainer1.SplitterDistance = 599;
            splitContainer1.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 954);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // rtbLista
            // 
            rtbLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbLista.Location = new Point(9, 28);
            rtbLista.Name = "rtbLista";
            rtbLista.Size = new Size(584, 911);
            rtbLista.TabIndex = 7;
            rtbLista.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 11;
            label1.Text = "Cole sua lista aqui...";
            // 
            // btnFormater
            // 
            btnFormater.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFormater.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFormater.Location = new Point(518, 5);
            btnFormater.Name = "btnFormater";
            btnFormater.Size = new Size(75, 23);
            btnFormater.TabIndex = 10;
            btnFormater.Text = "Formatar";
            btnFormater.UseVisualStyleBackColor = true;
            btnFormater.Click += btnFormater_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(5, 632);
            label4.Name = "label4";
            label4.Size = new Size(214, 18);
            label4.TabIndex = 19;
            label4.Text = "Variaveis Formatada para Retorno:";
            // 
            // rtbVariaveisRetorno
            // 
            rtbVariaveisRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbVariaveisRetorno.Location = new Point(5, 650);
            rtbVariaveisRetorno.Name = "rtbVariaveisRetorno";
            rtbVariaveisRetorno.Size = new Size(595, 290);
            rtbVariaveisRetorno.TabIndex = 18;
            rtbVariaveisRetorno.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(5, 321);
            label3.Name = "label3";
            label3.Size = new Size(139, 18);
            label3.TabIndex = 17;
            label3.Text = "Codigo de Comparação:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(5, 10);
            label2.Name = "label2";
            label2.Size = new Size(133, 18);
            label2.TabIndex = 16;
            label2.Text = "Variaveis Formatada:";
            // 
            // rtbVariaveis
            // 
            rtbVariaveis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbVariaveis.Location = new Point(5, 28);
            rtbVariaveis.Name = "rtbVariaveis";
            rtbVariaveis.Size = new Size(595, 290);
            rtbVariaveis.TabIndex = 15;
            rtbVariaveis.Text = "";
            // 
            // rtbCodigoValidacao
            // 
            rtbCodigoValidacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbCodigoValidacao.Location = new Point(5, 339);
            rtbCodigoValidacao.Name = "rtbCodigoValidacao";
            rtbCodigoValidacao.Size = new Size(595, 290);
            rtbCodigoValidacao.TabIndex = 14;
            rtbCodigoValidacao.Text = "";
            // 
            // CodeFormatter13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            CausesValidation = false;
            ClientSize = new Size(1213, 954);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CodeFormatter13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coder Formatter 13";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Splitter splitter1;
        private RichTextBox rtbLista;
        private Label label1;
        private Button btnFormater;
        private Label label4;
        private RichTextBox rtbVariaveisRetorno;
        private Label label3;
        private Label label2;
        private RichTextBox rtbVariaveis;
        private RichTextBox rtbCodigoValidacao;
    }
}
