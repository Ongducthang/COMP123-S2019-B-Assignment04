namespace COMP123_S2019_B_Assignment04
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMyWeight = new System.Windows.Forms.Label();
            this.labelMyHeight = new System.Windows.Forms.Label();
            this.textBoxMyHeight = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxMyWeight = new System.Windows.Forms.TextBox();
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.textBoxBMIResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonImperial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMyWeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBMIResult, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonCalculateBMI, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMyWeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelMyHeight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMyHeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMetric, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 332);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // labelMyWeight
            // 
            this.labelMyWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyWeight.Location = new System.Drawing.Point(3, 143);
            this.labelMyWeight.Name = "labelMyWeight";
            this.labelMyWeight.Size = new System.Drawing.Size(141, 88);
            this.labelMyWeight.TabIndex = 3;
            this.labelMyWeight.Text = "My weight";
            this.labelMyWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMyHeight
            // 
            this.labelMyHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMyHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyHeight.Location = new System.Drawing.Point(3, 55);
            this.labelMyHeight.Name = "labelMyHeight";
            this.labelMyHeight.Size = new System.Drawing.Size(141, 88);
            this.labelMyHeight.TabIndex = 0;
            this.labelMyHeight.Text = "My height";
            this.labelMyHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMyHeight.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBoxMyHeight
            // 
            this.textBoxMyHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMyHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMyHeight.Location = new System.Drawing.Point(150, 72);
            this.textBoxMyHeight.Name = "textBoxMyHeight";
            this.textBoxMyHeight.Size = new System.Drawing.Size(141, 53);
            this.textBoxMyHeight.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxMyWeight
            // 
            this.textBoxMyWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMyWeight.Location = new System.Drawing.Point(150, 160);
            this.textBoxMyWeight.Name = "textBoxMyWeight";
            this.textBoxMyWeight.Size = new System.Drawing.Size(141, 53);
            this.textBoxMyWeight.TabIndex = 5;
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMetric.Location = new System.Drawing.Point(3, 3);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(117, 49);
            this.radioButtonMetric.TabIndex = 6;
            this.radioButtonMetric.TabStop = true;
            this.radioButtonMetric.Text = "Metric";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonImperial.Location = new System.Drawing.Point(150, 3);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(141, 49);
            this.radioButtonImperial.TabIndex = 7;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculateBMI.BackColor = System.Drawing.Color.Goldenrod;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonCalculateBMI, 2);
            this.buttonCalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateBMI.ForeColor = System.Drawing.Color.White;
            this.buttonCalculateBMI.Location = new System.Drawing.Point(3, 234);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(288, 38);
            this.buttonCalculateBMI.TabIndex = 8;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = false;
            // 
            // textBoxBMIResult
            // 
            this.textBoxBMIResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxBMIResult, 2);
            this.textBoxBMIResult.Location = new System.Drawing.Point(3, 278);
            this.textBoxBMIResult.Name = "textBoxBMIResult";
            this.textBoxBMIResult.Size = new System.Drawing.Size(288, 53);
            this.textBoxBMIResult.TabIndex = 9;
            this.textBoxBMIResult.TextChanged += new System.EventHandler(this.TextBoxBMIResult_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelMyHeight;
        private System.Windows.Forms.Label labelMyWeight;
        private System.Windows.Forms.TextBox textBoxMyHeight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton radioButtonImperial;
        private System.Windows.Forms.TextBox textBoxMyWeight;
        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.Button buttonCalculateBMI;
        private System.Windows.Forms.TextBox textBoxBMIResult;
    }
}

