namespace DeleteAnnotation
{
    partial class DeleteAnnotationForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWillChange = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxSourcePath = new System.Windows.Forms.TextBox();
            this.linkLabelFloader = new System.Windows.Forms.LinkLabel();
            this.labelTarget = new System.Windows.Forms.Label();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.linkLabelTarget = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开发语言";
            // 
            // ComboBoxLanguage
            // 
            this.ComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLanguage.FormattingEnabled = true;
            this.ComboBoxLanguage.Location = new System.Drawing.Point(99, 25);
            this.ComboBoxLanguage.Name = "ComboBoxLanguage";
            this.ComboBoxLanguage.Size = new System.Drawing.Size(121, 20);
            this.ComboBoxLanguage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "源文件夹";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "是否替换";
            // 
            // comboBoxWillChange
            // 
            this.comboBoxWillChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWillChange.FormattingEnabled = true;
            this.comboBoxWillChange.Location = new System.Drawing.Point(99, 108);
            this.comboBoxWillChange.Name = "comboBoxWillChange";
            this.comboBoxWillChange.Size = new System.Drawing.Size(121, 20);
            this.comboBoxWillChange.TabIndex = 4;
            this.comboBoxWillChange.SelectedIndexChanged += new System.EventHandler(this.comboBoxWillChange_SelectedIndexChanged);
            // 
            // textBoxSourcePath
            // 
            this.textBoxSourcePath.Location = new System.Drawing.Point(99, 66);
            this.textBoxSourcePath.Name = "textBoxSourcePath";
            this.textBoxSourcePath.ReadOnly = true;
            this.textBoxSourcePath.Size = new System.Drawing.Size(281, 21);
            this.textBoxSourcePath.TabIndex = 5;
            // 
            // linkLabelFloader
            // 
            this.linkLabelFloader.AutoSize = true;
            this.linkLabelFloader.Location = new System.Drawing.Point(380, 71);
            this.linkLabelFloader.Name = "linkLabelFloader";
            this.linkLabelFloader.Size = new System.Drawing.Size(41, 12);
            this.linkLabelFloader.TabIndex = 6;
            this.linkLabelFloader.TabStop = true;
            this.linkLabelFloader.Text = "请选择";
            this.linkLabelFloader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFloader_LinkClicked);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(29, 150);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(65, 12);
            this.labelTarget.TabIndex = 2;
            this.labelTarget.Text = "输出文件夹";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(99, 147);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.Size = new System.Drawing.Size(281, 21);
            this.textBoxTarget.TabIndex = 5;
            // 
            // linkLabelTarget
            // 
            this.linkLabelTarget.AutoSize = true;
            this.linkLabelTarget.Location = new System.Drawing.Point(380, 152);
            this.linkLabelTarget.Name = "linkLabelTarget";
            this.linkLabelTarget.Size = new System.Drawing.Size(41, 12);
            this.linkLabelTarget.TabIndex = 6;
            this.linkLabelTarget.TabStop = true;
            this.linkLabelTarget.Text = "请选择";
            this.linkLabelTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTarget_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "确 定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabelTarget);
            this.Controls.Add(this.linkLabelFloader);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.textBoxSourcePath);
            this.Controls.Add(this.comboBoxWillChange);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxLanguage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除代码中的注释";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWillChange;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxSourcePath;
        private System.Windows.Forms.LinkLabel linkLabelFloader;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.LinkLabel linkLabelTarget;
        private System.Windows.Forms.Button button1;
    }
}

