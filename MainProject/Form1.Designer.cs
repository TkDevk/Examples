namespace MainProject
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
            textoNumeroUno = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            resultado = new Label();
            result = new Label();
            inputText = new TextBox();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            outPut = new Label();
            numOne = new TextBox();
            numTwo = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // textoNumeroUno
            // 
            textoNumeroUno.AutoSize = true;
            textoNumeroUno.BackColor = SystemColors.HotTrack;
            textoNumeroUno.Location = new Point(806, 146);
            textoNumeroUno.Name = "textoNumeroUno";
            textoNumeroUno.Size = new Size(27, 15);
            textoNumeroUno.TabIndex = 0;
            textoNumeroUno.Text = "Test";
            textoNumeroUno.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(781, 191);
            button1.Name = "button1";
            button1.Size = new Size(72, 31);
            button1.TabIndex = 1;
            button1.Text = "cambiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Location = new Point(781, 97);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Es mayor?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(765, 305);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresa tu edad";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Location = new Point(765, 350);
            button2.Name = "button2";
            button2.Size = new Size(88, 52);
            button2.TabIndex = 5;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.BackColor = SystemColors.Window;
            resultado.ForeColor = SystemColors.ActiveCaptionText;
            resultado.Location = new Point(889, 368);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 6;
            // 
            // result
            // 
            result.AutoSize = true;
            result.ForeColor = SystemColors.ActiveCaptionText;
            result.Location = new Point(868, 387);
            result.Name = "result";
            result.Size = new Size(13, 15);
            result.TabIndex = 7;
            result.Text = "0";
            // 
            // inputText
            // 
            inputText.Location = new Point(886, 323);
            inputText.Name = "inputText";
            inputText.Size = new Size(100, 23);
            inputText.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(527, 183);
            button3.Name = "button3";
            button3.Size = new Size(86, 53);
            button3.TabIndex = 9;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(527, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(527, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(465, 141);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Altura";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(465, 106);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 13;
            label4.Text = "Peso";
            label4.Click += label4_Click;
            // 
            // outPut
            // 
            outPut.AutoSize = true;
            outPut.Location = new Point(654, 209);
            outPut.Name = "outPut";
            outPut.Size = new Size(61, 15);
            outPut.TabIndex = 14;
            outPut.Text = "resultados";
            // 
            // numOne
            // 
            numOne.Location = new Point(122, 98);
            numOne.Name = "numOne";
            numOne.Size = new Size(100, 23);
            numOne.TabIndex = 15;
            // 
            // numTwo
            // 
            numTwo.Location = new Point(122, 146);
            numTwo.Name = "numTwo";
            numTwo.Size = new Size(100, 23);
            numTwo.TabIndex = 16;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(122, 191);
            button4.Name = "button4";
            button4.Size = new Size(75, 46);
            button4.TabIndex = 17;
            button4.Text = "Sumar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 495);
            Controls.Add(button4);
            Controls.Add(numTwo);
            Controls.Add(numOne);
            Controls.Add(outPut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(inputText);
            Controls.Add(result);
            Controls.Add(resultado);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textoNumeroUno);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoNumeroUno;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Label resultado;
        private Label result;
        private TextBox inputText;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label outPut;
        private TextBox numOne;
        private TextBox numTwo;
        private Button button4;
    }
}
