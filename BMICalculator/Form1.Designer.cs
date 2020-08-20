namespace BMICalculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.systemBox = new System.Windows.Forms.GroupBox();
            this.radioBtnMet = new System.Windows.Forms.RadioButton();
            this.radioBtnImp = new System.Windows.Forms.RadioButton();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.textName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridBmiData = new System.Windows.Forms.DataGridView();
            this.pictureImgBmi = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblInMet = new System.Windows.Forms.Label();
            this.lblKgLb = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.systemBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBmiData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImgBmi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.lblKgLb);
            this.tabPage1.Controls.Add(this.lblInMet);
            this.tabPage1.Controls.Add(this.btnClr);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.textWeight);
            this.tabPage1.Controls.Add(this.textResult);
            this.tabPage1.Controls.Add(this.textHeight);
            this.tabPage1.Controls.Add(this.lblHeight);
            this.tabPage1.Controls.Add(this.lblWeight);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.systemBox);
            this.tabPage1.Controls.Add(this.numAge);
            this.tabPage1.Controls.Add(this.textName);
            this.tabPage1.Controls.Add(this.lblAge);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.pnlHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BMI CALC";
            // 
            // btnClr
            // 
            this.btnClr.BackColor = System.Drawing.Color.Chocolate;
            this.btnClr.FlatAppearance.BorderSize = 0;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.Color.White;
            this.btnClr.Location = new System.Drawing.Point(474, 294);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(107, 38);
            this.btnClr.TabIndex = 18;
            this.btnClr.Text = "Clear All";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Chocolate;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(474, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 36);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save New";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Chocolate;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(474, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 40);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(202, 291);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 26);
            this.textWeight.TabIndex = 13;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(202, 362);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(100, 26);
            this.textResult.TabIndex = 12;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(202, 209);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(100, 26);
            this.textHeight.TabIndex = 11;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblHeight.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(70, 213);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(66, 22);
            this.lblHeight.TabIndex = 10;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblWeight.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(70, 292);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(70, 22);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Result";
            // 
            // systemBox
            // 
            this.systemBox.BackColor = System.Drawing.Color.Bisque;
            this.systemBox.Controls.Add(this.radioBtnMet);
            this.systemBox.Controls.Add(this.radioBtnImp);
            this.systemBox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemBox.ForeColor = System.Drawing.Color.Black;
            this.systemBox.Location = new System.Drawing.Point(416, 84);
            this.systemBox.Name = "systemBox";
            this.systemBox.Size = new System.Drawing.Size(200, 88);
            this.systemBox.TabIndex = 7;
            this.systemBox.TabStop = false;
            this.systemBox.Text = "System";
            // 
            // radioBtnMet
            // 
            this.radioBtnMet.AutoSize = true;
            this.radioBtnMet.BackColor = System.Drawing.Color.SaddleBrown;
            this.radioBtnMet.ForeColor = System.Drawing.Color.White;
            this.radioBtnMet.Location = new System.Drawing.Point(16, 55);
            this.radioBtnMet.Name = "radioBtnMet";
            this.radioBtnMet.Size = new System.Drawing.Size(175, 23);
            this.radioBtnMet.TabIndex = 1;
            this.radioBtnMet.TabStop = true;
            this.radioBtnMet.Text = "Metric (meter/kgs)";
            this.radioBtnMet.UseVisualStyleBackColor = false;
            // 
            // radioBtnImp
            // 
            this.radioBtnImp.AutoSize = true;
            this.radioBtnImp.BackColor = System.Drawing.Color.SaddleBrown;
            this.radioBtnImp.ForeColor = System.Drawing.Color.White;
            this.radioBtnImp.Location = new System.Drawing.Point(16, 26);
            this.radioBtnImp.Name = "radioBtnImp";
            this.radioBtnImp.Size = new System.Drawing.Size(177, 23);
            this.radioBtnImp.TabIndex = 0;
            this.radioBtnImp.TabStop = true;
            this.radioBtnImp.Text = "Imperial (inch/lbs)";
            this.radioBtnImp.UseVisualStyleBackColor = false;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(202, 146);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 26);
            this.numAge.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(202, 96);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(169, 26);
            this.textName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblAge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(70, 146);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 22);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(70, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(6, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(679, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(176, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(339, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Body Mass Index Calculator";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.gridBmiData);
            this.tabPage2.Controls.Add(this.pictureImgBmi);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BMI Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridBmiData
            // 
            this.gridBmiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBmiData.Location = new System.Drawing.Point(31, 32);
            this.gridBmiData.Name = "gridBmiData";
            this.gridBmiData.RowHeadersWidth = 62;
            this.gridBmiData.RowTemplate.Height = 28;
            this.gridBmiData.Size = new System.Drawing.Size(301, 301);
            this.gridBmiData.TabIndex = 7;
            // 
            // pictureImgBmi
            // 
            this.pictureImgBmi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureImgBmi.BackgroundImage")));
            this.pictureImgBmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureImgBmi.ErrorImage = null;
            this.pictureImgBmi.Location = new System.Drawing.Point(380, 23);
            this.pictureImgBmi.Name = "pictureImgBmi";
            this.pictureImgBmi.Size = new System.Drawing.Size(288, 251);
            this.pictureImgBmi.TabIndex = 6;
            this.pictureImgBmi.TabStop = false;
            // 
            // lblInMet
            // 
            this.lblInMet.AutoSize = true;
            this.lblInMet.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblInMet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInMet.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInMet.ForeColor = System.Drawing.Color.White;
            this.lblInMet.Location = new System.Drawing.Point(308, 215);
            this.lblInMet.Name = "lblInMet";
            this.lblInMet.Size = new System.Drawing.Size(117, 19);
            this.lblInMet.TabIndex = 19;
            this.lblInMet.Text = "inches/meters";
            // 
            // lblKgLb
            // 
            this.lblKgLb.AutoSize = true;
            this.lblKgLb.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblKgLb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgLb.ForeColor = System.Drawing.Color.White;
            this.lblKgLb.Location = new System.Drawing.Point(308, 294);
            this.lblKgLb.Name = "lblKgLb";
            this.lblKgLb.Size = new System.Drawing.Size(63, 19);
            this.lblKgLb.TabIndex = 20;
            this.lblKgLb.Text = "lbs/kgs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.systemBox.ResumeLayout(false);
            this.systemBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBmiData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImgBmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.PictureBox pictureImgBmi;
        private System.Windows.Forms.GroupBox systemBox;
        private System.Windows.Forms.RadioButton radioBtnMet;
        private System.Windows.Forms.RadioButton radioBtnImp;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView gridBmiData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblKgLb;
        private System.Windows.Forms.Label lblInMet;
    }
}