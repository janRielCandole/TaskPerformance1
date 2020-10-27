namespace BasicQueuingSystemApplication
{
    partial class QueuingForm
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
            this.btnCasher = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCasher
            // 
            this.btnCasher.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasher.Location = new System.Drawing.Point(31, 57);
            this.btnCasher.Name = "btnCasher";
            this.btnCasher.Size = new System.Drawing.Size(181, 150);
            this.btnCasher.TabIndex = 0;
            this.btnCasher.Text = "Cashier";
            this.btnCasher.UseVisualStyleBackColor = true;
            this.btnCasher.Click += new System.EventHandler(this.btnCasher_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(283, 97);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(321, 74);
            this.lblQueue.TabIndex = 1;
            this.lblQueue.Text = "P-10007";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.btnCasher);
            this.Name = "QueuingForm";
            this.Text = "QueuingForm";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCasher;
        private System.Windows.Forms.Label lblQueue;
    }
}

