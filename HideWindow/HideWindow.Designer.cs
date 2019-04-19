namespace HideWindow
{
    partial class HideWindow
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_hide = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.textBox_windowName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_hide
            // 
            this.button_hide.Location = new System.Drawing.Point(118, 14);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(75, 23);
            this.button_hide.TabIndex = 0;
            this.button_hide.Text = "Hide";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(199, 15);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 1;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // textBox_windowName
            // 
            this.textBox_windowName.Location = new System.Drawing.Point(12, 15);
            this.textBox_windowName.Name = "textBox_windowName";
            this.textBox_windowName.Size = new System.Drawing.Size(100, 22);
            this.textBox_windowName.TabIndex = 2;
            this.textBox_windowName.Text = "notepad";
            // 
            // HideWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 52);
            this.Controls.Add(this.textBox_windowName);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_hide);
            this.Name = "HideWindow";
            this.Text = "HideWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.TextBox textBox_windowName;
    }
}

