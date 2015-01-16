namespace CoCo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lBox = new System.Windows.Forms.ListBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbStayOnTop = new System.Windows.Forms.CheckBox();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.tbItemCount = new System.Windows.Forms.TextBox();
            this.tbVisibility = new System.Windows.Forms.TrackBar();
            this.gbSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisibility)).BeginInit();
            this.SuspendLayout();
            // 
            // lBox
            // 
            this.lBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(4, 2);
            this.lBox.Name = "lBox";
            this.lBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBox.Size = new System.Drawing.Size(109, 264);
            this.lBox.TabIndex = 0;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.lBox_SelectedIndexChanged);
            this.lBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lBox_KeyDown);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.Location = new System.Drawing.Point(60, 283);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(53, 26);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(4, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 26);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbStayOnTop
            // 
            this.cbStayOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStayOnTop.AutoSize = true;
            this.cbStayOnTop.Location = new System.Drawing.Point(6, 19);
            this.cbStayOnTop.Name = "cbStayOnTop";
            this.cbStayOnTop.Size = new System.Drawing.Size(86, 17);
            this.cbStayOnTop.TabIndex = 3;
            this.cbStayOnTop.Text = "Stay On Top";
            this.cbStayOnTop.UseVisualStyleBackColor = true;
            this.cbStayOnTop.CheckedChanged += new System.EventHandler(this.cbStayOnTop_CheckedChanged);
            // 
            // gbSetting
            // 
            this.gbSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSetting.Controls.Add(this.tbItemCount);
            this.gbSetting.Controls.Add(this.tbVisibility);
            this.gbSetting.Controls.Add(this.cbStayOnTop);
            this.gbSetting.Location = new System.Drawing.Point(4, 315);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(109, 110);
            this.gbSetting.TabIndex = 4;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Setting";
            // 
            // tbItemCount
            // 
            this.tbItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbItemCount.Location = new System.Drawing.Point(8, 40);
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(45, 20);
            this.tbItemCount.TabIndex = 5;
            this.tbItemCount.Text = "1";
            this.tbItemCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbItemCount.TextChanged += new System.EventHandler(this.tbItemCount_TextChanged);
            // 
            // tbVisibility
            // 
            this.tbVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVisibility.Location = new System.Drawing.Point(6, 64);
            this.tbVisibility.Maximum = 9;
            this.tbVisibility.Name = "tbVisibility";
            this.tbVisibility.Size = new System.Drawing.Size(97, 42);
            this.tbVisibility.TabIndex = 4;
            this.tbVisibility.Scroll += new System.EventHandler(this.tbVisibility_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(114, 427);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Copy Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisibility)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbStayOnTop;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.TrackBar tbVisibility;
        private System.Windows.Forms.TextBox tbItemCount;
    }
}

