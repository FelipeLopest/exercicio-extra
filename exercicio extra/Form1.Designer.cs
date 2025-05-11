namespace exercicio_extra
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            texto_txt = new TextBox();
            cb = new ComboBox();
            position = new TextBox();
            sum = new TextBox();
            select = new TextBox();
            button1 = new Button();
            eliminar = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite um Texto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 182);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Posição na lista:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 2;
            label3.Text = "Estilo DropdownList";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Texto selecionado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Total de itens";
            // 
            // texto_txt
            // 
            texto_txt.Location = new Point(131, 25);
            texto_txt.Name = "texto_txt";
            texto_txt.Size = new Size(645, 27);
            texto_txt.TabIndex = 5;
            texto_txt.KeyPress += texto_txt_KeyPress;
            // 
            // cb
            // 
            cb.FormattingEnabled = true;
            cb.Location = new Point(12, 106);
            cb.Name = "cb";
            cb.Size = new Size(597, 28);
            cb.TabIndex = 6;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // position
            // 
            position.Enabled = false;
            position.Location = new Point(131, 179);
            position.Name = "position";
            position.Size = new Size(85, 27);
            position.TabIndex = 7;
            // 
            // sum
            // 
            sum.Enabled = false;
            sum.Location = new Point(116, 253);
            sum.Name = "sum";
            sum.Size = new Size(85, 27);
            sum.TabIndex = 8;
            // 
            // select
            // 
            select.Enabled = false;
            select.Location = new Point(147, 216);
            select.Name = "select";
            select.Size = new Size(294, 27);
            select.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(637, 179);
            button1.Name = "button1";
            button1.Size = new Size(108, 42);
            button1.TabIndex = 10;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(637, 227);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(108, 39);
            eliminar.TabIndex = 11;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = true;
            eliminar.Click += eliminar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(637, 272);
            button3.Name = "button3";
            button3.Size = new Size(108, 48);
            button3.TabIndex = 12;
            button3.Text = "Limpar toda a lista ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(637, 326);
            button4.Name = "button4";
            button4.Size = new Size(108, 43);
            button4.TabIndex = 13;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(637, 375);
            button5.Name = "button5";
            button5.Size = new Size(108, 44);
            button5.TabIndex = 14;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(eliminar);
            Controls.Add(button1);
            Controls.Add(select);
            Controls.Add(sum);
            Controls.Add(position);
            Controls.Add(cb);
            Controls.Add(texto_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox texto_txt;
        private ComboBox cb;
        private TextBox position;
        private TextBox sum;
        private TextBox select;
        private Button button1;
        private Button eliminar;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
