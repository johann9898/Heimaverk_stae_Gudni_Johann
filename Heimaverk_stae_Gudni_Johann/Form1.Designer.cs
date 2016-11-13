namespace Heimaverk_stae_Gudni_Johann
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
            this.bt_submit = new System.Windows.Forms.Button();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.tb_dreif = new System.Windows.Forms.TextBox();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(160, 142);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(84, 81);
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(100, 22);
            this.tb_question.TabIndex = 1;
            // 
            // tb_dreif
            // 
            this.tb_dreif.Location = new System.Drawing.Point(293, 81);
            this.tb_dreif.Name = "tb_dreif";
            this.tb_dreif.Size = new System.Drawing.Size(100, 22);
            this.tb_dreif.TabIndex = 2;
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(54, 223);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(284, 170);
            this.rtb_output.TabIndex = 3;
            this.rtb_output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dreifing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spurning:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.tb_dreif);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.bt_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.TextBox tb_dreif;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

