namespace PizzaParlour
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notLabel = new System.Windows.Forms.TextBox();
            this.costButton = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 432);
            this.outputLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Toppings";
            // 
            // notLabel
            // 
            this.notLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notLabel.Location = new System.Drawing.Point(533, 70);
            this.notLabel.Name = "notLabel";
            this.notLabel.Size = new System.Drawing.Size(94, 45);
            this.notLabel.TabIndex = 2;
            // 
            // costButton
            // 
            this.costButton.AutoSize = true;
            this.costButton.BackColor = System.Drawing.Color.Black;
            this.costButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costButton.ForeColor = System.Drawing.Color.White;
            this.costButton.Location = new System.Drawing.Point(331, 203);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(140, 49);
            this.costButton.TabIndex = 3;
            this.costButton.Text = "Cost";
            this.costButton.UseVisualStyleBackColor = false;
            this.costButton.Click += new System.EventHandler(this.CostButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(160, 307);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(467, 84);
            this.costLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.notLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notLabel;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label costLabel;
    }
}

