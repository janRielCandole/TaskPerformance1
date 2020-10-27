namespace BasicQueuingSystemApplication
{
    partial class CustomerView
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
            this.lblServingTime = new System.Windows.Forms.Label();
            this.lblCustomerView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServingTime
            // 
            this.lblServingTime.AutoSize = true;
            this.lblServingTime.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingTime.Location = new System.Drawing.Point(114, 79);
            this.lblServingTime.Name = "lblServingTime";
            this.lblServingTime.Size = new System.Drawing.Size(340, 40);
            this.lblServingTime.TabIndex = 0;
            this.lblServingTime.Text = "*Now Serving ....";
            // 
            // lblCustomerView
            // 
            this.lblCustomerView.Font = new System.Drawing.Font("Consolas", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerView.Location = new System.Drawing.Point(120, 155);
            this.lblCustomerView.Name = "lblCustomerView";
            this.lblCustomerView.Size = new System.Drawing.Size(542, 139);
            this.lblCustomerView.TabIndex = 1;
            this.lblCustomerView.Text = "P-";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustomerView);
            this.Controls.Add(this.lblServingTime);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServingTime;
        private System.Windows.Forms.Label lblCustomerView;
    }
}