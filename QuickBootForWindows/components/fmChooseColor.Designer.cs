namespace QuickBootForWindows.components
{
    partial class fmChooseColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmChooseColor));
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.lPosition = new System.Windows.Forms.Label();
            this.tBChooseColorRed = new System.Windows.Forms.TextBox();
            this.tBChooseColorGreen = new System.Windows.Forms.TextBox();
            this.tBChooseColorBlue = new System.Windows.Forms.TextBox();
            this.tB16Color = new System.Windows.Forms.TextBox();
            this.lColorShow = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.gBChooseResult = new System.Windows.Forms.GroupBox();
            this.lColorRed = new System.Windows.Forms.Label();
            this.lColorGreen = new System.Windows.Forms.Label();
            this.lColorBlue = new System.Windows.Forms.Label();
            this.l16 = new System.Windows.Forms.Label();
            this.gBChooseResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Location = new System.Drawing.Point(28, 28);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(0, 12);
            this.lPosition.TabIndex = 0;
            // 
            // tBChooseColorRed
            // 
            this.tBChooseColorRed.Location = new System.Drawing.Point(48, 59);
            this.tBChooseColorRed.Name = "tBChooseColorRed";
            this.tBChooseColorRed.Size = new System.Drawing.Size(47, 21);
            this.tBChooseColorRed.TabIndex = 1;
            // 
            // tBChooseColorGreen
            // 
            this.tBChooseColorGreen.Location = new System.Drawing.Point(146, 59);
            this.tBChooseColorGreen.Name = "tBChooseColorGreen";
            this.tBChooseColorGreen.Size = new System.Drawing.Size(47, 21);
            this.tBChooseColorGreen.TabIndex = 2;
            // 
            // tBChooseColorBlue
            // 
            this.tBChooseColorBlue.Location = new System.Drawing.Point(256, 59);
            this.tBChooseColorBlue.Name = "tBChooseColorBlue";
            this.tBChooseColorBlue.Size = new System.Drawing.Size(47, 21);
            this.tBChooseColorBlue.TabIndex = 3;
            // 
            // tB16Color
            // 
            this.tB16Color.Location = new System.Drawing.Point(51, 102);
            this.tB16Color.Name = "tB16Color";
            this.tB16Color.Size = new System.Drawing.Size(92, 21);
            this.tB16Color.TabIndex = 4;
            // 
            // lColorShow
            // 
            this.lColorShow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lColorShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lColorShow.Location = new System.Drawing.Point(12, 14);
            this.lColorShow.Name = "lColorShow";
            this.lColorShow.Size = new System.Drawing.Size(227, 58);
            this.lColorShow.TabIndex = 5;
            this.lColorShow.Text = "长按取色按钮取色，释放查看结果";
            this.lColorShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(254, 19);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(99, 49);
            this.btnChooseColor.TabIndex = 6;
            this.btnChooseColor.Text = "取色";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnChooseColor_MouseDown);
            this.btnChooseColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnChooseColor_MouseUp);
            // 
            // gBChooseResult
            // 
            this.gBChooseResult.Controls.Add(this.l16);
            this.gBChooseResult.Controls.Add(this.lColorBlue);
            this.gBChooseResult.Controls.Add(this.lColorGreen);
            this.gBChooseResult.Controls.Add(this.lPosition);
            this.gBChooseResult.Controls.Add(this.lColorRed);
            this.gBChooseResult.Controls.Add(this.tBChooseColorRed);
            this.gBChooseResult.Controls.Add(this.tBChooseColorGreen);
            this.gBChooseResult.Controls.Add(this.tBChooseColorBlue);
            this.gBChooseResult.Controls.Add(this.tB16Color);
            this.gBChooseResult.Location = new System.Drawing.Point(14, 80);
            this.gBChooseResult.Name = "gBChooseResult";
            this.gBChooseResult.Size = new System.Drawing.Size(339, 146);
            this.gBChooseResult.TabIndex = 7;
            this.gBChooseResult.TabStop = false;
            this.gBChooseResult.Text = "取色结果";
            // 
            // lColorRed
            // 
            this.lColorRed.AutoSize = true;
            this.lColorRed.Location = new System.Drawing.Point(28, 63);
            this.lColorRed.Name = "lColorRed";
            this.lColorRed.Size = new System.Drawing.Size(17, 12);
            this.lColorRed.TabIndex = 5;
            this.lColorRed.Text = "R:";
            // 
            // lColorGreen
            // 
            this.lColorGreen.AutoSize = true;
            this.lColorGreen.Location = new System.Drawing.Point(126, 63);
            this.lColorGreen.Name = "lColorGreen";
            this.lColorGreen.Size = new System.Drawing.Size(17, 12);
            this.lColorGreen.TabIndex = 6;
            this.lColorGreen.Text = "G:";
            // 
            // lColorBlue
            // 
            this.lColorBlue.AutoSize = true;
            this.lColorBlue.Location = new System.Drawing.Point(236, 63);
            this.lColorBlue.Name = "lColorBlue";
            this.lColorBlue.Size = new System.Drawing.Size(17, 12);
            this.lColorBlue.TabIndex = 7;
            this.lColorBlue.Text = "B:";
            // 
            // l16
            // 
            this.l16.AutoSize = true;
            this.l16.Location = new System.Drawing.Point(28, 105);
            this.l16.Name = "l16";
            this.l16.Size = new System.Drawing.Size(17, 12);
            this.l16.TabIndex = 8;
            this.l16.Text = "R:";
            // 
            // fmChooseColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 241);
            this.Controls.Add(this.gBChooseResult);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.lColorShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmChooseColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "屏幕取色器 v0.1";
            this.gBChooseResult.ResumeLayout(false);
            this.gBChooseResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.TextBox tBChooseColorRed;
        private System.Windows.Forms.TextBox tBChooseColorGreen;
        private System.Windows.Forms.TextBox tBChooseColorBlue;
        private System.Windows.Forms.TextBox tB16Color;
        private System.Windows.Forms.Label lColorShow;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.GroupBox gBChooseResult;
        private System.Windows.Forms.Label lColorBlue;
        private System.Windows.Forms.Label lColorGreen;
        private System.Windows.Forms.Label lColorRed;
        private System.Windows.Forms.Label l16;
    }
}