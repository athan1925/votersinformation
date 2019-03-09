namespace VotersInfomationSystem
{
    partial class PrintVoters
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsearchvoters = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crptviewvoters = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.radiobarangay = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnprintvoters = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsearchvoters
            // 
            this.txtsearchvoters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearchvoters.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchvoters.Location = new System.Drawing.Point(226, 32);
            this.txtsearchvoters.Name = "txtsearchvoters";
            this.txtsearchvoters.Size = new System.Drawing.Size(417, 25);
            this.txtsearchvoters.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(226, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 3);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(226, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 2);
            this.panel1.TabIndex = 11;
            // 
            // crptviewvoters
            // 
            this.crptviewvoters.ActiveViewIndex = -1;
            this.crptviewvoters.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptviewvoters.DisplayStatusBar = false;
            this.crptviewvoters.Location = new System.Drawing.Point(29, 125);
            this.crptviewvoters.Name = "crptviewvoters";
            this.crptviewvoters.Size = new System.Drawing.Size(1209, 598);
            this.crptviewvoters.TabIndex = 12;
            this.crptviewvoters.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // radiobarangay
            // 
            this.radiobarangay.AutoSize = true;
            this.radiobarangay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobarangay.Location = new System.Drawing.Point(369, 70);
            this.radiobarangay.Name = "radiobarangay";
            this.radiobarangay.Size = new System.Drawing.Size(115, 28);
            this.radiobarangay.TabIndex = 13;
            this.radiobarangay.TabStop = true;
            this.radiobarangay.Text = "Barangay";
            this.radiobarangay.UseVisualStyleBackColor = true;
            this.radiobarangay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(516, 70);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 28);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Leader";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // btnprintvoters
            // 
            this.btnprintvoters.BorderColor = System.Drawing.Color.Silver;
            this.btnprintvoters.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnprintvoters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprintvoters.FlatAppearance.BorderSize = 0;
            this.btnprintvoters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnprintvoters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnprintvoters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintvoters.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintvoters.Location = new System.Drawing.Point(661, 30);
            this.btnprintvoters.Name = "btnprintvoters";
            this.btnprintvoters.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.btnprintvoters.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnprintvoters.OnHoverTextColor = System.Drawing.Color.White;
            this.btnprintvoters.Size = new System.Drawing.Size(152, 37);
            this.btnprintvoters.TabIndex = 11;
            this.btnprintvoters.Text = "PRINT";
            this.btnprintvoters.TextColor = System.Drawing.Color.White;
            this.btnprintvoters.UseVisualStyleBackColor = true;
            this.btnprintvoters.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search By:";
            // 
            // PrintVoters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radiobarangay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crptviewvoters);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnprintvoters);
            this.Controls.Add(this.txtsearchvoters);
            this.Name = "PrintVoters";
            this.Size = new System.Drawing.Size(1280, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearchvoters;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC btnprintvoters;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptviewvoters;
        private System.Windows.Forms.RadioButton radiobarangay;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}
