namespace Grades_if_Students
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
            this.btnCaclulate = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbxGrade = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaclulate
            // 
            this.btnCaclulate.Location = new System.Drawing.Point(16, 22);
            this.btnCaclulate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaclulate.Name = "btnCaclulate";
            this.btnCaclulate.Size = new System.Drawing.Size(153, 63);
            this.btnCaclulate.TabIndex = 0;
            this.btnCaclulate.Text = "Calculate This";
            this.btnCaclulate.UseVisualStyleBackColor = true;
            this.btnCaclulate.Click += new System.EventHandler(this.BtnCaclulate_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(221, 31);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(160, 20);
            this.txtGrade.TabIndex = 1;
            this.txtGrade.TextChanged += new System.EventHandler(this.TxtGrade_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 2;
            // 
            // lbxGrade
            // 
            this.lbxGrade.FormattingEnabled = true;
            this.lbxGrade.Location = new System.Drawing.Point(16, 109);
            this.lbxGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxGrade.Name = "lbxGrade";
            this.lbxGrade.Size = new System.Drawing.Size(365, 134);
            this.lbxGrade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(171, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grade";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(171, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // lblDataError
            // 
            this.lblDataError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDataError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataError.ForeColor = System.Drawing.Color.Crimson;
            this.lblDataError.Location = new System.Drawing.Point(399, 32);
            this.lblDataError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataError.Name = "lblDataError";
            this.lblDataError.Size = new System.Drawing.Size(123, 122);
            this.lblDataError.TabIndex = 6;
            this.lblDataError.Text = "test text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(567, 292);
            this.Controls.Add(this.lblDataError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxGrade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnCaclulate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaclulate;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lbxGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataError;
    }
}

