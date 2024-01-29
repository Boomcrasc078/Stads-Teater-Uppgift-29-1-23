namespace Stads_Teater_Uppgift_29_1_23
{
    partial class Form
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
            this.AntalVuxna = new System.Windows.Forms.NumericUpDown();
            this.BeräknaKnapp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AntalBarn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AntalPensionär = new System.Windows.Forms.NumericUpDown();
            this.VuxnaKostnad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BarnKostnad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PensionärKostnad = new System.Windows.Forms.TextBox();
            this.TotaltKostnad = new System.Windows.Forms.TextBox();
            this.TotaltVuxna = new System.Windows.Forms.TextBox();
            this.TotaltPensionär = new System.Windows.Forms.TextBox();
            this.TotaltBarn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AntalVuxna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntalBarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntalPensionär)).BeginInit();
            this.SuspendLayout();
            // 
            // AntalVuxna
            // 
            this.AntalVuxna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntalVuxna.Location = new System.Drawing.Point(232, 89);
            this.AntalVuxna.Name = "AntalVuxna";
            this.AntalVuxna.Size = new System.Drawing.Size(43, 30);
            this.AntalVuxna.TabIndex = 0;
            // 
            // BeräknaKnapp
            // 
            this.BeräknaKnapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeräknaKnapp.Location = new System.Drawing.Point(300, 270);
            this.BeräknaKnapp.Name = "BeräknaKnapp";
            this.BeräknaKnapp.Size = new System.Drawing.Size(215, 43);
            this.BeräknaKnapp.TabIndex = 1;
            this.BeräknaKnapp.Text = "BERÄKNA";
            this.BeräknaKnapp.UseVisualStyleBackColor = true;
            this.BeräknaKnapp.Click += new System.EventHandler(this.BeräknaKnapp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ANTAL PERSONER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "VUXNA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "BARN";
            // 
            // AntalBarn
            // 
            this.AntalBarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntalBarn.Location = new System.Drawing.Point(232, 151);
            this.AntalBarn.Name = "AntalBarn";
            this.AntalBarn.Size = new System.Drawing.Size(43, 30);
            this.AntalBarn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "PENSIONÄR";
            // 
            // AntalPensionär
            // 
            this.AntalPensionär.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntalPensionär.Location = new System.Drawing.Point(232, 216);
            this.AntalPensionär.Name = "AntalPensionär";
            this.AntalPensionär.Size = new System.Drawing.Size(43, 30);
            this.AntalPensionär.TabIndex = 6;
            // 
            // VuxnaKostnad
            // 
            this.VuxnaKostnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VuxnaKostnad.Location = new System.Drawing.Point(537, 89);
            this.VuxnaKostnad.Name = "VuxnaKostnad";
            this.VuxnaKostnad.Size = new System.Drawing.Size(54, 30);
            this.VuxnaKostnad.TabIndex = 8;
            this.VuxnaKostnad.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "/Pers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "/Pers";
            // 
            // BarnKostnad
            // 
            this.BarnKostnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarnKostnad.Location = new System.Drawing.Point(537, 151);
            this.BarnKostnad.Name = "BarnKostnad";
            this.BarnKostnad.Size = new System.Drawing.Size(54, 30);
            this.BarnKostnad.TabIndex = 10;
            this.BarnKostnad.Text = "60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(597, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "/Pers";
            // 
            // PensionärKostnad
            // 
            this.PensionärKostnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PensionärKostnad.Location = new System.Drawing.Point(537, 216);
            this.PensionärKostnad.Name = "PensionärKostnad";
            this.PensionärKostnad.Size = new System.Drawing.Size(54, 30);
            this.PensionärKostnad.TabIndex = 12;
            this.PensionärKostnad.Text = "80";
            // 
            // TotaltKostnad
            // 
            this.TotaltKostnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltKostnad.Location = new System.Drawing.Point(58, 276);
            this.TotaltKostnad.Name = "TotaltKostnad";
            this.TotaltKostnad.Size = new System.Drawing.Size(217, 30);
            this.TotaltKostnad.TabIndex = 14;
            this.TotaltKostnad.Text = "TOTALT: ";
            // 
            // TotaltVuxna
            // 
            this.TotaltVuxna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltVuxna.Location = new System.Drawing.Point(300, 88);
            this.TotaltVuxna.Name = "TotaltVuxna";
            this.TotaltVuxna.Size = new System.Drawing.Size(215, 30);
            this.TotaltVuxna.TabIndex = 15;
            this.TotaltVuxna.Text = "TOTALT: ";
            // 
            // TotaltPensionär
            // 
            this.TotaltPensionär.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltPensionär.Location = new System.Drawing.Point(300, 215);
            this.TotaltPensionär.Name = "TotaltPensionär";
            this.TotaltPensionär.Size = new System.Drawing.Size(215, 30);
            this.TotaltPensionär.TabIndex = 16;
            this.TotaltPensionär.Text = "TOTALT: ";
            // 
            // TotaltBarn
            // 
            this.TotaltBarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltBarn.Location = new System.Drawing.Point(300, 153);
            this.TotaltBarn.Name = "TotaltBarn";
            this.TotaltBarn.Size = new System.Drawing.Size(215, 30);
            this.TotaltBarn.TabIndex = 17;
            this.TotaltBarn.Text = "TOTALT: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotaltBarn);
            this.Controls.Add(this.TotaltPensionär);
            this.Controls.Add(this.TotaltVuxna);
            this.Controls.Add(this.TotaltKostnad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PensionärKostnad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BarnKostnad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VuxnaKostnad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AntalPensionär);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AntalBarn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeräknaKnapp);
            this.Controls.Add(this.AntalVuxna);
            this.Name = "Form";
            this.Text = "Stadsteater Calc";
            ((System.ComponentModel.ISupportInitialize)(this.AntalVuxna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntalBarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntalPensionär)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AntalVuxna;
        private System.Windows.Forms.Button BeräknaKnapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AntalBarn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AntalPensionär;
        private System.Windows.Forms.TextBox VuxnaKostnad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BarnKostnad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PensionärKostnad;
        private System.Windows.Forms.TextBox TotaltKostnad;
        private System.Windows.Forms.TextBox TotaltVuxna;
        private System.Windows.Forms.TextBox TotaltPensionär;
        private System.Windows.Forms.TextBox TotaltBarn;
    }
}

