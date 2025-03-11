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
            splitContainer1 = new SplitContainer();
            splitter1 = new Splitter();
            rtbLista = new RichTextBox();
            label1 = new Label();
            btnFormater = new Button();
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
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(rtbVariaveis);
            splitContainer1.Panel2.Controls.Add(rtbCodigoValidacao);
            splitContainer1.Size = new Size(993, 580);
            splitContainer1.SplitterDistance = 492;
            splitContainer1.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 580);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // rtbLista
            // 
            rtbLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbLista.Location = new Point(12, 33);
            rtbLista.Name = "rtbLista";
            rtbLista.Size = new Size(477, 540);
            rtbLista.TabIndex = 7;
            rtbLista.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 11;
            label1.Text = "Cole sua lista aqui...";
            // 
            // btnFormater
            // 
            btnFormater.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFormater.Location = new Point(414, 7);
            btnFormater.Name = "btnFormater";
            btnFormater.Size = new Size(75, 23);
            btnFormater.TabIndex = 10;
            btnFormater.Text = "Formatar";
            btnFormater.UseVisualStyleBackColor = true;
            btnFormater.Click += btnFormater_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 294);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 13;
            label3.Text = "Codigo de Comparação:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 12;
            label2.Text = "Variaveis Formatada:";
            // 
            // rtbVariaveis
            // 
            rtbVariaveis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbVariaveis.Location = new Point(3, 33);
            rtbVariaveis.Name = "rtbVariaveis";
            rtbVariaveis.Size = new Size(482, 252);
            rtbVariaveis.TabIndex = 9;
            rtbVariaveis.Text = "";
            // 
            // rtbCodigoValidacao
            // 
            rtbCodigoValidacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbCodigoValidacao.Location = new Point(3, 312);
            rtbCodigoValidacao.Name = "rtbCodigoValidacao";
            rtbCodigoValidacao.Size = new Size(482, 252);
            rtbCodigoValidacao.TabIndex = 8;
            rtbCodigoValidacao.Text = "";
            // 
            // CodeFormatter13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(993, 580);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "CodeFormatter13";
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
        private RichTextBox rtbLista;
        private Label label1;
        private Button btnFormater;
        private Label label3;
        private Label label2;
        private RichTextBox rtbVariaveis;
        private RichTextBox rtbCodigoValidacao;
        private Splitter splitter1;
    }
}
