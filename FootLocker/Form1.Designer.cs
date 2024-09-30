namespace FootLocker
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
            this.title = new System.Windows.Forms.Label();
            this.shoesLabel = new System.Windows.Forms.Label();
            this.hatsLabel = new System.Windows.Forms.Label();
            this.shirtsLabel = new System.Windows.Forms.Label();
            this.shoesOutput = new System.Windows.Forms.TextBox();
            this.hatsOutput = new System.Windows.Forms.TextBox();
            this.shirtsOutput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Button();
            this.taxOutput = new System.Windows.Forms.Button();
            this.totalOutput = new System.Windows.Forms.Button();
            this.cashLabel = new System.Windows.Forms.Label();
            this.cashtenderedOutput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Button();
            this.printLabel = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.neworderLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(13, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(783, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Footlocker";
            // 
            // shoesLabel
            // 
            this.shoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.shoesLabel.Location = new System.Drawing.Point(12, 51);
            this.shoesLabel.Name = "shoesLabel";
            this.shoesLabel.Size = new System.Drawing.Size(129, 23);
            this.shoesLabel.TabIndex = 1;
            this.shoesLabel.Text = "Number Of Shoes:";
            // 
            // hatsLabel
            // 
            this.hatsLabel.AutoSize = true;
            this.hatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hatsLabel.Location = new System.Drawing.Point(12, 80);
            this.hatsLabel.Name = "hatsLabel";
            this.hatsLabel.Size = new System.Drawing.Size(105, 16);
            this.hatsLabel.TabIndex = 2;
            this.hatsLabel.Text = "Number Of Hats:";
            // 
            // shirtsLabel
            // 
            this.shirtsLabel.AutoSize = true;
            this.shirtsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shirtsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.shirtsLabel.Location = new System.Drawing.Point(12, 109);
            this.shirtsLabel.Name = "shirtsLabel";
            this.shirtsLabel.Size = new System.Drawing.Size(110, 16);
            this.shirtsLabel.TabIndex = 3;
            this.shirtsLabel.Text = "Number Of Shirts:";
            // 
            // shoesOutput
            // 
            this.shoesOutput.Location = new System.Drawing.Point(153, 50);
            this.shoesOutput.Name = "shoesOutput";
            this.shoesOutput.Size = new System.Drawing.Size(100, 20);
            this.shoesOutput.TabIndex = 4;
            // 
            // hatsOutput
            // 
            this.hatsOutput.Location = new System.Drawing.Point(153, 76);
            this.hatsOutput.Name = "hatsOutput";
            this.hatsOutput.Size = new System.Drawing.Size(100, 20);
            this.hatsOutput.TabIndex = 5;
            // 
            // shirtsOutput
            // 
            this.shirtsOutput.Location = new System.Drawing.Point(153, 102);
            this.shirtsOutput.Name = "shirtsOutput";
            this.shirtsOutput.Size = new System.Drawing.Size(100, 20);
            this.shirtsOutput.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(12, 128);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(241, 33);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 178);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.taxLabel.Location = new System.Drawing.Point(12, 207);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalLabel.Location = new System.Drawing.Point(12, 239);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 16);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.ForeColor = System.Drawing.Color.Black;
            this.subtotalOutput.Location = new System.Drawing.Point(153, 178);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 23);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.UseVisualStyleBackColor = true;
            // 
            // taxOutput
            // 
            this.taxOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxOutput.Location = new System.Drawing.Point(153, 207);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.UseVisualStyleBackColor = true;
            // 
            // totalOutput
            // 
            this.totalOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalOutput.Location = new System.Drawing.Point(154, 236);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.UseVisualStyleBackColor = true;
            // 
            // cashLabel
            // 
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cashLabel.Location = new System.Drawing.Point(12, 286);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(107, 23);
            this.cashLabel.TabIndex = 14;
            this.cashLabel.Text = "Cash Tendered:";
            // 
            // cashtenderedOutput
            // 
            this.cashtenderedOutput.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cashtenderedOutput.Location = new System.Drawing.Point(153, 285);
            this.cashtenderedOutput.Name = "cashtenderedOutput";
            this.cashtenderedOutput.Size = new System.Drawing.Size(100, 20);
            this.cashtenderedOutput.TabIndex = 15;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeButton.Location = new System.Drawing.Point(15, 324);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(238, 37);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeLabel.Location = new System.Drawing.Point(19, 364);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(100, 24);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeOutput.Location = new System.Drawing.Point(153, 364);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 23);
            this.changeOutput.TabIndex = 18;
            this.changeOutput.UseVisualStyleBackColor = true;
            // 
            // printLabel
            // 
            this.printLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printLabel.Location = new System.Drawing.Point(19, 401);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(235, 37);
            this.printLabel.TabIndex = 19;
            this.printLabel.Text = "Print Receipt";
            this.printLabel.UseVisualStyleBackColor = false;
            this.printLabel.Click += new System.EventHandler(this.printLabel_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptLabel.Location = new System.Drawing.Point(282, 50);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(506, 326);
            this.receiptLabel.TabIndex = 20;
            this.receiptLabel.Click += new System.EventHandler(this.receiptLabel_Click);
            // 
            // neworderLabel
            // 
            this.neworderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.neworderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neworderLabel.Location = new System.Drawing.Point(314, 391);
            this.neworderLabel.Name = "neworderLabel";
            this.neworderLabel.Size = new System.Drawing.Size(448, 33);
            this.neworderLabel.TabIndex = 21;
            this.neworderLabel.Text = "New Order";
            this.neworderLabel.UseVisualStyleBackColor = false;
            this.neworderLabel.Click += new System.EventHandler(this.neworderLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.neworderLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.cashtenderedOutput);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.shirtsOutput);
            this.Controls.Add(this.hatsOutput);
            this.Controls.Add(this.shoesOutput);
            this.Controls.Add(this.shirtsLabel);
            this.Controls.Add(this.hatsLabel);
            this.Controls.Add(this.shoesLabel);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Footlocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label shoesLabel;
        private System.Windows.Forms.Label hatsLabel;
        private System.Windows.Forms.Label shirtsLabel;
        private System.Windows.Forms.TextBox shoesOutput;
        private System.Windows.Forms.TextBox hatsOutput;
        private System.Windows.Forms.TextBox shirtsOutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button subtotalOutput;
        private System.Windows.Forms.Button taxOutput;
        private System.Windows.Forms.Button totalOutput;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.TextBox cashtenderedOutput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeOutput;
        private System.Windows.Forms.Button printLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button neworderLabel;
    }
}

