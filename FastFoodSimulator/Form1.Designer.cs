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
            this.customersNumberOTSTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderNumberOTSTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderTakerListBox = new System.Windows.Forms.ListBox();
            this.Configuration = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.orderPreparationTimeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerArrivelTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wOrdersKSListBox = new System.Windows.Forms.ListBox();
            this.wOrdersNumberKSTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pOrderNumberKSTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.serverListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.orderSSTextBox = new System.Windows.Forms.TextBox();
            this.customersNumberSSTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // customersNumberOTSTextBox
            // 
            this.customersNumberOTSTextBox.Location = new System.Drawing.Point(169, 68);
            this.customersNumberOTSTextBox.Name = "customersNumberOTSTextBox";
            this.customersNumberOTSTextBox.Size = new System.Drawing.Size(82, 27);
            this.customersNumberOTSTextBox.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taken order:";
            // 
            // orderNumberOTSTextBox
            // 
            this.orderNumberOTSTextBox.Location = new System.Drawing.Point(169, 123);
            this.orderNumberOTSTextBox.Name = "orderNumberOTSTextBox";
            this.orderNumberOTSTextBox.Size = new System.Drawing.Size(82, 27);
            this.orderNumberOTSTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderTakerListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customersNumberOTSTextBox);
            this.panel1.Controls.Add(this.orderNumberOTSTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 325);
            this.panel1.TabIndex = 6;
            // 
            // orderTakerListBox
            // 
            this.orderTakerListBox.FormattingEnabled = true;
            this.orderTakerListBox.ItemHeight = 20;
            this.orderTakerListBox.Location = new System.Drawing.Point(15, 162);
            this.orderTakerListBox.Name = "orderTakerListBox";
            this.orderTakerListBox.Size = new System.Drawing.Size(236, 144);
            this.orderTakerListBox.TabIndex = 6;
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.label13);
            this.Configuration.Controls.Add(this.label12);
            this.Configuration.Controls.Add(this.stopButton);
            this.Configuration.Controls.Add(this.orderPreparationTimeTextBox);
            this.Configuration.Controls.Add(this.label5);
            this.Configuration.Controls.Add(this.label4);
            this.Configuration.Controls.Add(this.customerArrivelTextBox);
            this.Configuration.Controls.Add(this.startButton);
            this.Configuration.Location = new System.Drawing.Point(11, 432);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(1005, 121);
            this.Configuration.TabIndex = 7;
            this.Configuration.TabStop = false;
            this.Configuration.Text = "Configuration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "s";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(811, 85);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(86, 31);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // orderPreparationTimeTextBox
            // 
            this.orderPreparationTimeTextBox.Location = new System.Drawing.Point(190, 72);
            this.orderPreparationTimeTextBox.Name = "orderPreparationTimeTextBox";
            this.orderPreparationTimeTextBox.Size = new System.Drawing.Size(125, 27);
            this.orderPreparationTimeTextBox.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer arrivel time:";
            // 
            // customerArrivelTextBox
            // 
            this.customerArrivelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.customerArrivelTextBox.Location = new System.Drawing.Point(190, 37);
            this.customerArrivelTextBox.Name = "customerArrivelTextBox";
            this.customerArrivelTextBox.Size = new System.Drawing.Size(125, 27);
            this.customerArrivelTextBox.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(904, 87);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wOrdersKSListBox);
            this.panel2.Controls.Add(this.wOrdersNumberKSTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pOrderNumberKSTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(368, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 325);
            this.panel2.TabIndex = 8;
            // 
            // wOrdersKSListBox
            // 
            this.wOrdersKSListBox.FormattingEnabled = true;
            this.wOrdersKSListBox.ItemHeight = 20;
            this.wOrdersKSListBox.Location = new System.Drawing.Point(16, 147);
            this.wOrdersKSListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wOrdersKSListBox.Name = "wOrdersKSListBox";
            this.wOrdersKSListBox.Size = new System.Drawing.Size(245, 164);
            this.wOrdersKSListBox.TabIndex = 9;
            // 
            // wOrdersNumberKSTextBox
            // 
            this.wOrdersNumberKSTextBox.Location = new System.Drawing.Point(179, 96);
            this.wOrdersNumberKSTextBox.Name = "wOrdersNumberKSTextBox";
            this.wOrdersNumberKSTextBox.Size = new System.Drawing.Size(82, 27);
            this.wOrdersNumberKSTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Waiting orders:";
            // 
            // pOrderNumberKSTextBox
            // 
            this.pOrderNumberKSTextBox.Location = new System.Drawing.Point(179, 53);
            this.pOrderNumberKSTextBox.Name = "pOrderNumberKSTextBox";
            this.pOrderNumberKSTextBox.Size = new System.Drawing.Size(82, 27);
            this.pOrderNumberKSTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Preparing order:";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.serverListBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.orderSSTextBox);
            this.panel3.Controls.Add(this.customersNumberSSTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(741, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 325);
            this.panel3.TabIndex = 7;
            // 
            // serverListBox
            // 
            this.serverListBox.FormattingEnabled = true;
            this.serverListBox.ItemHeight = 20;
            this.serverListBox.Location = new System.Drawing.Point(24, 167);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(214, 144);
            this.serverListBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Server service";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Waiting customers:";
            // 
            // orderSSTextBox
            // 
            this.orderSSTextBox.Location = new System.Drawing.Point(169, 68);
            this.orderSSTextBox.Name = "orderSSTextBox";
            this.orderSSTextBox.Size = new System.Drawing.Size(82, 27);
            this.orderSSTextBox.TabIndex = 2;
            // 
            // customersNumberSSTextBox
            // 
            this.customersNumberSSTextBox.Location = new System.Drawing.Point(169, 124);
            this.customersNumberSSTextBox.Name = "customersNumberSSTextBox";
            this.customersNumberSSTextBox.Size = new System.Drawing.Size(82, 27);
            this.customersNumberSSTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Available order:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 568);
            this.Controls.Add(this.panel3);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox customersNumberOTSTextBox;
        private Label label2;
        private Label label3;
        private TextBox orderNumberOTSTextBox;
        private Panel panel1;
        private GroupBox Configuration;
        private TextBox orderPreparationTimeTextBox;
        private Label label5;
        private Label label4;
        private TextBox customerArrivelTextBox;
        private Button startButton;
        private Panel panel2;
        private TextBox pOrderNumberKSTextBox;
        private Label label7;
        private Label label6;
        private ListBox wOrdersKSListBox;
        private TextBox wOrdersNumberKSTextBox;
        private Label label8;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private TextBox orderSSTextBox;
        private TextBox customersNumberSSTextBox;
        private Label label11;
        private Button stopButton;
        private Label label13;
        private Label label12;
        private ListBox orderTakerListBox;
        private ListBox serverListBox;
    }
}