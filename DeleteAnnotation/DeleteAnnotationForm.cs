using DeleteAnnotation.Bll;
using DeleteAnnotation.common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteAnnotation
{
    public partial class DeleteAnnotationForm : Form
    {
        public DeleteAnnotationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 语言下拉框
            this.setValue(this.ComboBoxLanguage, Statics.languageJson);
            // 是否覆盖下拉框
            this.setValue(this.comboBoxWillChange, Statics.willCnange);
            this.comboBoxWillChange.SelectedIndex = 1;
        }

        /// <summary>
        /// 设置下拉框初始值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sourceValue"></param>
        private void setValue(ComboBox sender, string sourceValue)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");
            Dictionary<string, string> languageList = JsonConvert.DeserializeObject<Dictionary<string, string>>(sourceValue);
            foreach (var item in languageList)
            {
                DataRow dr = dt.NewRow();
                dr["Value"] = item.Key;
                dr["Text"] = item.Value;
                dt.Rows.Add(dr);
            }
            sender.DataSource = dt;
            sender.DisplayMember = "Text";
            sender.ValueMember = "Value";
        }

        /// <summary>
        /// 源文件夹选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelFloader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = this.folderBrowserDialog1.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                this.textBoxSourcePath.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// 目标文件夹选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = this.folderBrowserDialog1.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                this.textBoxTarget.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// 是否覆盖下拉框选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxWillChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxWillChange.SelectedValue.Equals("2"))
            {
                this.labelTarget.Visible = true;
                this.textBoxTarget.Visible = true;
                this.linkLabelTarget.Visible = true;
            }
            else
            {
                this.labelTarget.Visible = false;
                this.textBoxTarget.Visible = false;
                this.linkLabelTarget.Visible = false;
            }
        }

        /// <summary>
        /// 替换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string sourcePath = this.textBoxSourcePath.Text;
            if (string.IsNullOrWhiteSpace(sourcePath))
            {
                MessageBox.Show("源文件夹不能为空，请选择");
                return;
            }

            string targetPath = this.textBoxTarget.Text;
            string willChange = this.comboBoxWillChange.SelectedValue.ToString();
            if (willChange.Equals("2"))
            {
                if (string.IsNullOrWhiteSpace(targetPath))
                {
                    MessageBox.Show("不替换的时候，目标文件夹不能为空，请选择");
                    return;
                }
            }
            else
            {
                targetPath = sourcePath;
            }

            string language = this.ComboBoxLanguage.SelectedValue.ToString();
            string resultMsg = "成功";
            DeleteAnnotationCore deleteAnnotationCore = new DeleteAnnotationCore();
            switch (language)
            {
                case "1": // c#
                    resultMsg = deleteAnnotationCore.DoWork(sourcePath, targetPath, Statics.cSharpRegex, Statics.cSharpFileEndType);
                    break;
                case "2": // java
                    resultMsg = deleteAnnotationCore.DoWork(sourcePath, targetPath, Statics.javaRegex, Statics.javaFileEndType);
                    break;
                case "3": // javascript
                    resultMsg = deleteAnnotationCore.DoWork(sourcePath, targetPath, Statics.javascriptRegex, Statics.javascriptFileEndType);
                    break;
            }

            MessageBox.Show(resultMsg);
        }
    }
}
