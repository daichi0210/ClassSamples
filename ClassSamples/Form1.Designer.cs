namespace ClassSamples
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
            buttonAnimalInstanceCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName1 = new TextBox();
            textBoxColor1 = new TextBox();
            textBoxSing1 = new TextBox();
            textBoxName2 = new TextBox();
            textBoxColor2 = new TextBox();
            textBoxSing2 = new TextBox();
            SuspendLayout();
            // 
            // buttonAnimalInstanceCreate
            // 
            buttonAnimalInstanceCreate.Location = new Point(12, 12);
            buttonAnimalInstanceCreate.Name = "buttonAnimalInstanceCreate";
            buttonAnimalInstanceCreate.Size = new Size(502, 23);
            buttonAnimalInstanceCreate.TabIndex = 0;
            buttonAnimalInstanceCreate.Text = "動物クラスのインスタンス生成";
            buttonAnimalInstanceCreate.UseVisualStyleBackColor = true;
            buttonAnimalInstanceCreate.Click += buttonAnimalInstanceCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "名前";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "色";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 208);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "鳴き声";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 63);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "動物１";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 63);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 1;
            label5.Text = "動物２";
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(80, 93);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(100, 23);
            textBoxName1.TabIndex = 2;
            // 
            // textBoxColor1
            // 
            textBoxColor1.Location = new Point(80, 149);
            textBoxColor1.Name = "textBoxColor1";
            textBoxColor1.Size = new Size(100, 23);
            textBoxColor1.TabIndex = 2;
            // 
            // textBoxSing1
            // 
            textBoxSing1.Location = new Point(80, 205);
            textBoxSing1.Name = "textBoxSing1";
            textBoxSing1.Size = new Size(100, 23);
            textBoxSing1.TabIndex = 2;
            // 
            // textBoxName2
            // 
            textBoxName2.Location = new Point(211, 93);
            textBoxName2.Name = "textBoxName2";
            textBoxName2.Size = new Size(100, 23);
            textBoxName2.TabIndex = 2;
            // 
            // textBoxColor2
            // 
            textBoxColor2.Location = new Point(211, 149);
            textBoxColor2.Name = "textBoxColor2";
            textBoxColor2.Size = new Size(100, 23);
            textBoxColor2.TabIndex = 2;
            // 
            // textBoxSing2
            // 
            textBoxSing2.Location = new Point(211, 205);
            textBoxSing2.Name = "textBoxSing2";
            textBoxSing2.Size = new Size(100, 23);
            textBoxSing2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 252);
            Controls.Add(textBoxSing2);
            Controls.Add(textBoxColor2);
            Controls.Add(textBoxName2);
            Controls.Add(textBoxSing1);
            Controls.Add(textBoxColor1);
            Controls.Add(textBoxName1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAnimalInstanceCreate);
            Name = "Form1";
            Text = "Animal Class Sample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnimalInstanceCreate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName1;
        private TextBox textBoxColor1;
        private TextBox textBoxSing1;
        private TextBox textBoxName2;
        private TextBox textBoxColor2;
        private TextBox textBoxSing2;
    }
}
