namespace VotersInfomationSystem
{
    partial class PrintSummary
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
            this.radioleader = new System.Windows.Forms.RadioButton();
            this.radiocoor = new System.Windows.Forms.RadioButton();
            this.crptviewsummary = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnprintvoters = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // radioleader
            // 
            this.radioleader.AutoSize = true;
            this.radioleader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioleader.Location = new System.Drawing.Point(539, 31);
            this.radioleader.Name = "radioleader";
            this.radioleader.Size = new System.Drawing.Size(93, 28);
            this.radioleader.TabIndex = 18;
            this.radioleader.TabStop = true;
            this.radioleader.Text = "Leader";
            this.radioleader.UseVisualStyleBackColor = true;
            // 
            // radiocoor
            // 
            this.radiocoor.AutoSize = true;
            this.radiocoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocoor.Location = new System.Drawing.Point(382, 31);
            this.radiocoor.Name = "radiocoor";
            this.radiocoor.Size = new System.Drawing.Size(137, 28);
            this.radiocoor.TabIndex = 17;
            this.radiocoor.TabStop = true;
            this.radiocoor.Text = "Coordinator";
            this.radiocoor.UseVisualStyleBackColor = true;
            // 
            // crptviewsummary
            // 
            this.crptviewsummary.ActiveViewIndex = -1;
            this.crptviewsummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptviewsummary.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptviewsummary.DisplayStatusBar = false;
            this.crptviewsummary.Location = new System.Drawing.Point(36, 120);
            this.crptviewsummary.Name = "crptviewsummary";
            this.crptviewsummary.Size = new System.Drawing.Size(1209, 598);
            this.crptviewsummary.TabIndex = 16;
            this.crptviewsummary.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.btnprintvoters.Location = new System.Drawing.Point(668, 25);
            this.btnprintvoters.Name = "btnprintvoters";
            this.btnprintvoters.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.btnprintvoters.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnprintvoters.OnHoverTextColor = System.Drawing.Color.White;
            this.btnprintvoters.Size = new System.Drawing.Size(152, 37);
            this.btnprintvoters.TabIndex = 15;
            this.btnprintvoters.Text = "PRINT";
            this.btnprintvoters.TextColor = System.Drawing.Color.White;
            this.btnprintvoters.UseVisualStyleBackColor = true;
            // 
            // PrintSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radioleader);
            this.Controls.Add(this.radiocoor);
            this.Controls.Add(this.crptviewsummary);
            this.Controls.Add(this.btnprintvoters);
            this.Name = "PrintSummary";
            this.Size = new System.Drawing.Size(1280, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioleader;
        private System.Windows.Forms.RadioButton radiocoor;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptviewsummary;
        private ePOSOne.btnProduct.Button_WOC btnprintvoters;
    }
}
