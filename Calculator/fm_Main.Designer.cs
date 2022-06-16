using System.Windows.Forms;

namespace Calculator
{
    partial class fm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.lableAction = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbNum1);
            this.flowLayoutPanel1.Controls.Add(this.lableAction);
            this.flowLayoutPanel1.Controls.Add(this.tbNum2);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.tbResult);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tbNum1
            // 
            this.tbNum1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNum1.Location = new System.Drawing.Point(3, 3);
            this.tbNum1.MaxLength = 5;
            this.tbNum1.Multiline = true;
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(110, 48);
            this.tbNum1.TabIndex = 0;
            this.tbNum1.Text = "12";
            this.tbNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lableAction
            // 
            this.lableAction.AutoSize = true;
            this.lableAction.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lableAction.Location = new System.Drawing.Point(119, 0);
            this.lableAction.Name = "lableAction";
            this.lableAction.Size = new System.Drawing.Size(44, 47);
            this.lableAction.TabIndex = 3;
            this.lableAction.Text = "+";
            // 
            // tbNum2
            // 
            this.tbNum2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNum2.Location = new System.Drawing.Point(169, 3);
            this.tbNum2.MaxLength = 5;
            this.tbNum2.Multiline = true;
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(110, 48);
            this.tbNum2.TabIndex = 1;
            this.tbNum2.Text = "12";
            this.tbNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(285, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbResult.Location = new System.Drawing.Point(335, 3);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(140, 48);
            this.tbResult.TabIndex = 2;
            this.tbResult.Text = "12";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupActionButtons
            // 
            this.groupActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupActionButtons.Location = new System.Drawing.Point(0, 61);
            this.groupActionButtons.Name = "groupActionButtons";
            this.groupActionButtons.Size = new System.Drawing.Size(478, 44);
            this.groupActionButtons.TabIndex = 1;
            // 
            // fm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 107);
            this.Controls.Add(this.groupActionButtons);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator With Plugins";
            this.Load += new System.EventHandler(this.fm_Main_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel groupActionButtons;
        private TextBox tbNum1;
        private TextBox tbNum2;
        private TextBox tbResult;
        private Label lableAction;
        private Label label2;
    }
}