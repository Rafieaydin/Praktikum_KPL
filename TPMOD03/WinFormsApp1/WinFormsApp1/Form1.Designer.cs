namespace WinFormsApp1
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
            btnClickThis = new Button();
            input = new TextBox();
            output = new TextBox();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.BackColor = Color.Cornsilk;
            btnClickThis.Location = new Point(425, 147);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(109, 50);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "button";
            btnClickThis.UseVisualStyleBackColor = false;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // input
            // 
            input.BackColor = Color.BlanchedAlmond;
            input.Location = new Point(234, 145);
            input.Name = "input";
            input.Size = new Size(185, 23);
            input.TabIndex = 1;
            input.TextChanged += input_TextChanged;
            // 
            // output
            // 
            output.BackColor = Color.AntiqueWhite;
            output.Location = new Point(234, 174);
            output.Name = "output";
            output.Size = new Size(185, 23);
            output.TabIndex = 2;
            output.TextChanged += output_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(btnClickThis);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private TextBox input;
        private TextBox output;
    }
}
