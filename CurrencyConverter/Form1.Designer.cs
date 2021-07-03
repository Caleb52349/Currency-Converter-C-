namespace CurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aDisplay = new System.Windows.Forms.Label();
            this.aAmount = new System.Windows.Forms.TextBox();
            this.aFromCombo1 = new System.Windows.Forms.ComboBox();
            this.aToCombo2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1559, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convert From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Convert To";
            // 
            // aDisplay
            // 
            this.aDisplay.AutoSize = true;
            this.aDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDisplay.Location = new System.Drawing.Point(12, 304);
            this.aDisplay.Name = "aDisplay";
            this.aDisplay.Size = new System.Drawing.Size(183, 24);
            this.aDisplay.TabIndex = 4;
            this.aDisplay.Text = "Converted Amount : ";
            // 
            // aAmount
            // 
            this.aAmount.Location = new System.Drawing.Point(196, 59);
            this.aAmount.Name = "aAmount";
            this.aAmount.Size = new System.Drawing.Size(181, 20);
            this.aAmount.TabIndex = 5;
            // 
            // aFromCombo1
            // 
            this.aFromCombo1.FormattingEnabled = true;
            this.aFromCombo1.Items.AddRange(new object[] {
            "Zlote",
            "Qar",
            "Euro"});
            this.aFromCombo1.Location = new System.Drawing.Point(196, 116);
            this.aFromCombo1.Name = "aFromCombo1";
            this.aFromCombo1.Size = new System.Drawing.Size(181, 21);
            this.aFromCombo1.TabIndex = 6;
            this.aFromCombo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // aToCombo2
            // 
            this.aToCombo2.FormattingEnabled = true;
            this.aToCombo2.Items.AddRange(new object[] {
            "Zlote",
            "Qar",
            "Euro"});
            this.aToCombo2.Location = new System.Drawing.Point(196, 178);
            this.aToCombo2.Name = "aToCombo2";
            this.aToCombo2.Size = new System.Drawing.Size(181, 21);
            this.aToCombo2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(458, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aToCombo2);
            this.Controls.Add(this.aFromCombo1);
            this.Controls.Add(this.aAmount);
            this.Controls.Add(this.aDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label aDisplay;
        private System.Windows.Forms.TextBox aAmount;
        private System.Windows.Forms.ComboBox aFromCombo1;
        private System.Windows.Forms.ComboBox aToCombo2;
        private System.Windows.Forms.Button button1;
    }
}

