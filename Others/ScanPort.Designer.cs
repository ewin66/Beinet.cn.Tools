﻿namespace Beinet.cn.Tools.Others
{
    partial class ScanPort
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.labTh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtErr = new System.Windows.Forms.TextBox();
            this.chkPortAll = new System.Windows.Forms.CheckBox();
            this.chkNormalPort = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtCustomPort = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCustomPort);
            this.tabPage1.Controls.Add(this.txtTimeout);
            this.tabPage1.Controls.Add(this.labTh);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.chkPortAll);
            this.tabPage1.Controls.Add(this.chkNormalPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIp1);
            this.tabPage1.Controls.Add(this.labStatus);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "端口扫描工具";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeout.Location = new System.Drawing.Point(542, 35);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(44, 21);
            this.txtTimeout.TabIndex = 2;
            this.txtTimeout.Text = "4";
            this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labTh
            // 
            this.labTh.AutoSize = true;
            this.labTh.Location = new System.Drawing.Point(540, 91);
            this.labTh.Name = "labTh";
            this.labTh.Size = new System.Drawing.Size(11, 12);
            this.labTh.TabIndex = 12;
            this.labTh.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "多个IP以半角逗号分隔，且支持 - 的IP段，如：10.2.0.1-10.2.0.100";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "超时等待秒数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "当前线程数:";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, 107);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(590, 332);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtResult);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(582, 306);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "成功记录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(576, 300);
            this.txtResult.TabIndex = 8;
            this.txtResult.WordWrap = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtErr);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(582, 306);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "失败记录";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtErr
            // 
            this.txtErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErr.Location = new System.Drawing.Point(3, 3);
            this.txtErr.Multiline = true;
            this.txtErr.Name = "txtErr";
            this.txtErr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtErr.Size = new System.Drawing.Size(576, 300);
            this.txtErr.TabIndex = 0;
            this.txtErr.TabStop = false;
            // 
            // chkPortAll
            // 
            this.chkPortAll.AutoSize = true;
            this.chkPortAll.Location = new System.Drawing.Point(86, 66);
            this.chkPortAll.Name = "chkPortAll";
            this.chkPortAll.Size = new System.Drawing.Size(120, 16);
            this.chkPortAll.TabIndex = 6;
            this.chkPortAll.Text = "全部端口:1~65535";
            this.chkPortAll.UseVisualStyleBackColor = true;
            this.chkPortAll.CheckedChanged += new System.EventHandler(this.chkPortAll_CheckedChanged);
            // 
            // chkNormalPort
            // 
            this.chkNormalPort.AutoSize = true;
            this.chkNormalPort.Checked = true;
            this.chkNormalPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNormalPort.Location = new System.Drawing.Point(214, 66);
            this.chkNormalPort.Name = "chkNormalPort";
            this.chkNormalPort.Size = new System.Drawing.Size(84, 16);
            this.chkNormalPort.TabIndex = 5;
            this.chkNormalPort.Text = "指定端口：";
            this.chkNormalPort.UseVisualStyleBackColor = true;
            this.chkNormalPort.CheckedChanged += new System.EventHandler(this.chkPortAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // txtIp1
            // 
            this.txtIp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIp1.Location = new System.Drawing.Point(41, 10);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(545, 21);
            this.txtIp1.TabIndex = 1;
            this.txtIp1.Text = "10.2.0.1,10.2.0.31,10.2.0.4";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.ForeColor = System.Drawing.Color.Red;
            this.labStatus.Location = new System.Drawing.Point(5, 91);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(65, 12);
            this.labStatus.TabIndex = 0;
            this.labStatus.Text = "未开始扫描";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "开始扫描";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 468);
            this.tabControl1.TabIndex = 1;
            // 
            // txtCustomPort
            // 
            this.txtCustomPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomPort.Location = new System.Drawing.Point(288, 64);
            this.txtCustomPort.Name = "txtCustomPort";
            this.txtCustomPort.Size = new System.Drawing.Size(305, 21);
            this.txtCustomPort.TabIndex = 13;
            this.txtCustomPort.Text = "80,8080,3128,8081,9080,1080,21,23,443,69,22,25,110,7001,9090,3389,1521,1158,2100," +
    "1433,3306";
            // 
            // ScanPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "ScanPort";
            this.Text = "端口扫描工具";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkPortAll;
        private System.Windows.Forms.CheckBox chkNormalPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtErr;
        private System.Windows.Forms.Label labTh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomPort;
    }
}