namespace QuickBootForWindows
{
    partial class frmQuickStart
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickStart));
            this.btnSystemProperties = new System.Windows.Forms.Button();
            this.btnControlPanel = new System.Windows.Forms.Button();
            this.gBSystem = new System.Windows.Forms.GroupBox();
            this.btnComputerManager = new System.Windows.Forms.Button();
            this.btnDeviceManager = new System.Windows.Forms.Button();
            this.btnSysServices = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.gBTool = new System.Windows.Forms.GroupBox();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnApplicationManager = new System.Windows.Forms.Button();
            this.gBSystem.SuspendLayout();
            this.gBTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSystemProperties
            // 
            this.btnSystemProperties.Location = new System.Drawing.Point(50, 64);
            this.btnSystemProperties.Name = "btnSystemProperties";
            this.btnSystemProperties.Size = new System.Drawing.Size(108, 23);
            this.btnSystemProperties.TabIndex = 0;
            this.btnSystemProperties.Text = "计算机属性";
            this.btnSystemProperties.UseVisualStyleBackColor = true;
            this.btnSystemProperties.Click += new System.EventHandler(this.btnSystemProperties_Click);
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.Location = new System.Drawing.Point(50, 26);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Size = new System.Drawing.Size(108, 23);
            this.btnControlPanel.TabIndex = 1;
            this.btnControlPanel.Text = "控制面板";
            this.btnControlPanel.UseVisualStyleBackColor = true;
            this.btnControlPanel.Click += new System.EventHandler(this.btnControlPanel_Click);
            // 
            // gBSystem
            // 
            this.gBSystem.Controls.Add(this.btnApplicationManager);
            this.gBSystem.Controls.Add(this.btnComputerManager);
            this.gBSystem.Controls.Add(this.btnDeviceManager);
            this.gBSystem.Controls.Add(this.btnSysServices);
            this.gBSystem.Controls.Add(this.btnComputer);
            this.gBSystem.Controls.Add(this.btnSystemProperties);
            this.gBSystem.Controls.Add(this.btnControlPanel);
            this.gBSystem.Location = new System.Drawing.Point(35, 19);
            this.gBSystem.Name = "gBSystem";
            this.gBSystem.Size = new System.Drawing.Size(522, 144);
            this.gBSystem.TabIndex = 2;
            this.gBSystem.TabStop = false;
            this.gBSystem.Text = "系统";
            // 
            // btnComputerManager
            // 
            this.btnComputerManager.Location = new System.Drawing.Point(210, 102);
            this.btnComputerManager.Name = "btnComputerManager";
            this.btnComputerManager.Size = new System.Drawing.Size(108, 23);
            this.btnComputerManager.TabIndex = 5;
            this.btnComputerManager.Text = "计算机管理";
            this.btnComputerManager.UseVisualStyleBackColor = true;
            this.btnComputerManager.Click += new System.EventHandler(this.btnComputerManager_Click);
            // 
            // btnDeviceManager
            // 
            this.btnDeviceManager.Location = new System.Drawing.Point(210, 64);
            this.btnDeviceManager.Name = "btnDeviceManager";
            this.btnDeviceManager.Size = new System.Drawing.Size(108, 23);
            this.btnDeviceManager.TabIndex = 5;
            this.btnDeviceManager.Text = "设备管理器";
            this.btnDeviceManager.UseVisualStyleBackColor = true;
            this.btnDeviceManager.Click += new System.EventHandler(this.btnDeviceManager_Click);
            // 
            // btnSysServices
            // 
            this.btnSysServices.Location = new System.Drawing.Point(210, 26);
            this.btnSysServices.Name = "btnSysServices";
            this.btnSysServices.Size = new System.Drawing.Size(108, 23);
            this.btnSysServices.TabIndex = 4;
            this.btnSysServices.Text = "服务";
            this.btnSysServices.UseVisualStyleBackColor = true;
            this.btnSysServices.Click += new System.EventHandler(this.btnSysServices_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(50, 102);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(108, 23);
            this.btnComputer.TabIndex = 3;
            this.btnComputer.Text = "计算机";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // gBTool
            // 
            this.gBTool.Controls.Add(this.btnPaint);
            this.gBTool.Controls.Add(this.btnCalc);
            this.gBTool.Location = new System.Drawing.Point(35, 184);
            this.gBTool.Name = "gBTool";
            this.gBTool.Size = new System.Drawing.Size(206, 141);
            this.gBTool.TabIndex = 3;
            this.gBTool.TabStop = false;
            this.gBTool.Text = "常用工具";
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(50, 82);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(108, 23);
            this.btnPaint.TabIndex = 2;
            this.btnPaint.Text = "画图";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(50, 42);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(108, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "计算器";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnApplicationManager
            // 
            this.btnApplicationManager.Location = new System.Drawing.Point(370, 26);
            this.btnApplicationManager.Name = "btnApplicationManager";
            this.btnApplicationManager.Size = new System.Drawing.Size(108, 23);
            this.btnApplicationManager.TabIndex = 6;
            this.btnApplicationManager.Text = "卸载/更改程序";
            this.btnApplicationManager.UseVisualStyleBackColor = true;
            this.btnApplicationManager.Click += new System.EventHandler(this.btnApplicationManager_Click);
            // 
            // frmQuickStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(592, 349);
            this.Controls.Add(this.gBTool);
            this.Controls.Add(this.gBSystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuickStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快速启动器 v0.3";
            this.gBSystem.ResumeLayout(false);
            this.gBTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSystemProperties;
        private System.Windows.Forms.Button btnControlPanel;
        private System.Windows.Forms.GroupBox gBSystem;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnSysServices;
        private System.Windows.Forms.Button btnDeviceManager;
        private System.Windows.Forms.Button btnComputerManager;
        private System.Windows.Forms.GroupBox gBTool;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnApplicationManager;
    }
}

