namespace DesignResponsivo
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
            this.painel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuEsquerdo = new System.Windows.Forms.Panel();
            this.menuHorizontal = new System.Windows.Forms.Panel();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.painel.BackColor = System.Drawing.Color.SkyBlue;
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.textBox1);
            this.painel.Controls.Add(this.button1);
            this.painel.Location = new System.Drawing.Point(432, 116);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(225, 171);
            this.painel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuEsquerdo
            // 
            this.menuEsquerdo.BackColor = System.Drawing.Color.RosyBrown;
            this.menuEsquerdo.Location = new System.Drawing.Point(-3, -5);
            this.menuEsquerdo.Name = "menuEsquerdo";
            this.menuEsquerdo.Size = new System.Drawing.Size(204, 457);
            this.menuEsquerdo.TabIndex = 1;
            // 
            // menuHorizontal
            // 
            this.menuHorizontal.BackColor = System.Drawing.Color.IndianRed;
            this.menuHorizontal.Location = new System.Drawing.Point(207, 23);
            this.menuHorizontal.Name = "menuHorizontal";
            this.menuHorizontal.Size = new System.Drawing.Size(509, 73);
            this.menuHorizontal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuHorizontal);
            this.Controls.Add(this.menuEsquerdo);
            this.Controls.Add(this.painel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel painel;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel menuEsquerdo;
        private Panel menuHorizontal;
    }
}