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
            this.tb_line = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_grof = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(372, 125);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // tb_line
            // 
            this.tb_line.Location = new System.Drawing.Point(357, 81);
            this.tb_line.Name = "tb_line";
            this.tb_line.Size = new System.Drawing.Size(100, 22);
            this.tb_line.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "f(x) =";
            // 
            // pn_grof
            // 
            this.pn_grof.Location = new System.Drawing.Point(124, 176);
            this.pn_grof.Name = "pn_grof";
            this.pn_grof.Size = new System.Drawing.Size(605, 426);
            this.pn_grof.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 627);
            this.Controls.Add(this.pn_grof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_line);
            this.Controls.Add(this.bt_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.TextBox tb_line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_grof;
    }
}

