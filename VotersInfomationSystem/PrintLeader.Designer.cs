namespace VotersInfomationSystem
{
    partial class PrintLeader
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
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radiobarangay = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprintvoters = new ePOSOne.btnProduct.Button_WOC();
            this.txtsearchvoters = new System.Windows.Forms.TextBox();
            this.crptviewleader = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search By:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(521, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 28);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Coordinator";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiobarangay
            // 
            this.radiobarangay.AutoSize = true;
            this.radiobarangay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobarangay.Location = new System.Drawing.Point(374, 77);
            this.radiobarangay.Name = "radiobarangay";
            this.radiobarangay.Size = new System.Drawing.Size(115, 28);
            this.radiobarangay.TabIndex = 20;
            this.radiobarangay.TabStop = true;
            this.radiobarangay.Text = "Barangay";
            this.radiobarangay.UseVisualStyleBackColor = true;
            this.radiobarangay.CheckedChanged += new System.EventHandler(this.radiobarangay_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(231, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 3);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(231, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 2);
            this.panel1.TabIndex = 18;
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
            this.btnprintvoters.Location = new System.Drawing.Point(666, 37);
            this.btnprintvoters.Name = "btnprintvoters";
            this.btnprintvoters.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.btnprintvoters.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnprintvoters.OnHoverTextColor = System.Drawing.Color.White;
            this.btnprintvoters.Size = new System.Drawing.Size(152, 37);
            this.btnprintvoters.TabIndex = 19;
            this.btnprintvoters.Text = "PRINT";
            this.btnprintvoters.TextColor = System.Drawing.Color.White;
            this.btnprintvoters.UseVisualStyleBackColor = true;
            this.btnprintvoters.Click += new System.EventHandler(this.btnprintvoters_Click);
            // 
            // txtsearchvoters
            // 
            this.txtsearchvoters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearchvoters.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchvoters.Location = new System.Drawing.Point(231, 39);
            this.txtsearchvoters.Name = "txtsearchvoters";
            this.txtsearchvoters.Size = new System.Drawing.Size(417, 25);
            this.txtsearchvoters.TabIndex = 16;
            // 
            // crptviewleader
            // 
            this.crptviewleader.ActiveViewIndex = -1;
            this.crptviewleader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptviewleader.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptviewleader.DisplayStatusBar = false;
            this.crptviewleader.Location = new System.Drawing.Point(20, 127);
            this.crptviewleader.Name = "crptviewleader";
            this.crptviewleader.Size = new System.Drawing.Size(1209, 598);
            this.crptviewleader.TabIndex = 23;
            this.crptviewleader.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrintLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.crptviewleader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radiobarangay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnprintvoters);
            this.Controls.Add(this.txtsearchvoters);
            this.Name = "PrintLeader";
            this.Size = new System.Drawing.Size(1280, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radiobarangay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC btnprintvoters;
        private System.Windows.Forms.TextBox txtsearchvoters;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptviewleader;
    }
}
