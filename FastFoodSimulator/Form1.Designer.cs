namespace FastFoodSimulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.customersNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ordersNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Configuration = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.customerArrivelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderPreparationTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.preparedOrdersTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order taker service";
            // 
            // customersNumber
            // 
            this.customersNumber.Location = new System.Drawing.Point(169, 68);
            this.customersNumber.Name = "customersNumber";
            this.customersNumber.Size = new System.Drawing.Size(82, 27);
            this.customersNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waiting customers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taken orders:";
            // 
            // ordersNumber
            // 
            this.ordersNumber.Location = new System.Drawing.Point(169, 124);
            this.ordersNumber.Name = "ordersNumber";
            this.ordersNumber.Size = new System.Drawing.Size(82, 27);
            this.ordersNumber.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customersNumber);
            this.panel1.Controls.Add(this.ordersNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 191);
            this.panel1.TabIndex = 6;
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.OrderPreparationTextBox);
            this.Configuration.Controls.Add(this.label5);
            this.Configuration.Controls.Add(this.label4);
            this.Configuration.Controls.Add(this.customerArrivelTextBox);
            this.Configuration.Controls.Add(this.startButton);
            this.Configuration.Location = new System.Drawing.Point(12, 383);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(867, 114);
            this.Configuration.TabIndex = 7;
            this.Configuration.TabStop = false;
            this.Configuration.Text = "Configuration";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(767, 79);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // customerArrivelTextBox
            // 
            this.customerArrivelTextBox.Location = new System.Drawing.Point(190, 37);
            this.customerArrivelTextBox.Name = "customerArrivelTextBox";
            this.customerArrivelTextBox.Size = new System.Drawing.Size(125, 27);
            this.customerArrivelTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer arrivel time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Order preparation time:";
            // 
            // OrderPreparationTextBox
            // 
            this.OrderPreparationTextBox.Location = new System.Drawing.Point(190, 72);
            this.OrderPreparationTextBox.Name = "OrderPreparationTextBox";
            this.OrderPreparationTextBox.Size = new System.Drawing.Size(125, 27);
            this.OrderPreparationTextBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.preparedOrdersTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(317, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 191);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kitchen service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prepared orders:";
            // 
            // preparedOrdersTextBox
            // 
            this.preparedOrdersTextBox.Location = new System.Drawing.Point(179, 53);
            this.preparedOrdersTextBox.Name = "preparedOrdersTextBox";
            this.preparedOrdersTextBox.Size = new System.Drawing.Size(82, 27);
            this.preparedOrdersTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Configuration);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Configuration.ResumeLayout(false);
            this.Configuration.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox customersNumber;
        private Label label2;
        private Label label3;
        private TextBox ordersNumber;
        private Panel panel1;
        private GroupBox Configuration;
        private TextBox OrderPreparationTextBox;
        private Label label5;
        private Label label4;
        private TextBox customerArrivelTextBox;
        private Button startButton;
        private Panel panel2;
        private TextBox preparedOrdersTextBox;
        private Label label7;
        private Label label6;
    }
}