namespace Example
{
    partial class Hello
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
            this.btnClickme = new System.Windows.Forms.Button();
            this.lbHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickme
            // 
            this.btnClickme.Location = new System.Drawing.Point(71, 70);
            this.btnClickme.Name = "btnClickme";
            this.btnClickme.Size = new System.Drawing.Size(146, 48);
            this.btnClickme.TabIndex = 0;
            this.btnClickme.Text = "Click me";
            this.btnClickme.UseVisualStyleBackColor = true;
            this.btnClickme.Click += new System.EventHandler(this.btnClickme_Click);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(85, 136);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(0, 32);
            this.lbHello.TabIndex = 1;
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 230);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.btnClickme);
            this.Name = "Hello";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickme;
        private System.Windows.Forms.Label lbHello;
    }
}

