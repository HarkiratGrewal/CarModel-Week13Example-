namespace Week13_HandsOn
{
    partial class Cars
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
            this.car_number = new System.Windows.Forms.Label();
            this.carNo_txt = new System.Windows.Forms.TextBox();
            this.noOfSeats_txt = new System.Windows.Forms.TextBox();
            this.noOfSeats = new System.Windows.Forms.Label();
            this.model_txt = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.Label();
            this.brand_txt = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // car_number
            // 
            this.car_number.AutoSize = true;
            this.car_number.Location = new System.Drawing.Point(121, 87);
            this.car_number.Name = "car_number";
            this.car_number.Size = new System.Drawing.Size(58, 25);
            this.car_number.TabIndex = 0;
            this.car_number.Text = "Car#";
            // 
            // carNo_txt
            // 
            this.carNo_txt.Location = new System.Drawing.Point(391, 87);
            this.carNo_txt.Name = "carNo_txt";
            this.carNo_txt.Size = new System.Drawing.Size(100, 31);
            this.carNo_txt.TabIndex = 1;
            // 
            // noOfSeats_txt
            // 
            this.noOfSeats_txt.Location = new System.Drawing.Point(391, 286);
            this.noOfSeats_txt.Name = "noOfSeats_txt";
            this.noOfSeats_txt.Size = new System.Drawing.Size(100, 31);
            this.noOfSeats_txt.TabIndex = 7;
            // 
            // noOfSeats
            // 
            this.noOfSeats.AutoSize = true;
            this.noOfSeats.Location = new System.Drawing.Point(121, 286);
            this.noOfSeats.Name = "noOfSeats";
            this.noOfSeats.Size = new System.Drawing.Size(130, 25);
            this.noOfSeats.TabIndex = 2;
            this.noOfSeats.Text = "No. of Seats";
            // 
            // model_txt
            // 
            this.model_txt.Location = new System.Drawing.Point(391, 218);
            this.model_txt.Name = "model_txt";
            this.model_txt.Size = new System.Drawing.Size(100, 31);
            this.model_txt.TabIndex = 5;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(121, 218);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(71, 25);
            this.model.TabIndex = 4;
            this.model.Text = "Model";
            // 
            // brand_txt
            // 
            this.brand_txt.Location = new System.Drawing.Point(391, 149);
            this.brand_txt.Name = "brand_txt";
            this.brand_txt.Size = new System.Drawing.Size(100, 31);
            this.brand_txt.TabIndex = 3;
            // 
            // brand
            // 
            this.brand.AutoSize = true;
            this.brand.Location = new System.Drawing.Point(121, 149);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(69, 25);
            this.brand.TabIndex = 6;
            this.brand.Text = "Brand";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(126, 408);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 57);
            this.add.TabIndex = 8;
            this.add.Text = "&Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(366, 408);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(125, 57);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "&Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 579);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.brand_txt);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.model_txt);
            this.Controls.Add(this.model);
            this.Controls.Add(this.noOfSeats_txt);
            this.Controls.Add(this.noOfSeats);
            this.Controls.Add(this.carNo_txt);
            this.Controls.Add(this.car_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Cars";
            this.Text = "Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label car_number;
        private System.Windows.Forms.TextBox carNo_txt;
        private System.Windows.Forms.TextBox noOfSeats_txt;
        private System.Windows.Forms.Label noOfSeats;
        private System.Windows.Forms.TextBox model_txt;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox brand_txt;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}

