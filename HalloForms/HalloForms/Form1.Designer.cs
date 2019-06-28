namespace HalloForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPersonSpeichern = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Klick mich !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonKlickMich_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 126);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Speichern !";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonTextSpeichern_Click);
            // 
            // buttonPersonSpeichern
            // 
            this.buttonPersonSpeichern.Location = new System.Drawing.Point(259, 12);
            this.buttonPersonSpeichern.Name = "buttonPersonSpeichern";
            this.buttonPersonSpeichern.Size = new System.Drawing.Size(139, 71);
            this.buttonPersonSpeichern.TabIndex = 3;
            this.buttonPersonSpeichern.Text = "Person speichern";
            this.buttonPersonSpeichern.UseVisualStyleBackColor = true;
            this.buttonPersonSpeichern.Click += new System.EventHandler(this.ButtonPersonSpeichern_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 71);
            this.button3.TabIndex = 4;
            this.button3.Text = "Person laden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonPersonLaden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 271);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonPersonSpeichern);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPersonSpeichern;
        private System.Windows.Forms.Button button3;
    }
}

