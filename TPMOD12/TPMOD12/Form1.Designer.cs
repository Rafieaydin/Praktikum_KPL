namespace TPMOD12
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
            input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ouput = new TextBox();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(111, 70);
            input.Name = "input";
            input.Size = new Size(100, 23);
            input.TabIndex = 0;
            input.TextChanged += input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 73);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "input :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 114);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "output :";
            // 
            // ouput
            // 
            ouput.Location = new Point(111, 111);
            ouput.Name = "ouput";
            ouput.Size = new Size(100, 23);
            ouput.TabIndex = 3;
            ouput.TextChanged += ouput_TextChanged;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(217, 73);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 23);
            btn_submit.TabIndex = 4;
            btn_submit.Text = "submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_submit);
            Controls.Add(ouput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private Label label1;
        private Label label2;
        private TextBox ouput;
        private Button btn_submit;

     



    }
}