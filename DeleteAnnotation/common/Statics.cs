using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteAnnotation.common
{
    class Statics
    {
        /// <summary>
        /// 语言设置
        /// </summary>
        public static string languageJson = "{'1':'C#','2':'Java', '3':'JavaScript'}";

        /// <summary>
        /// 是否覆盖
        /// </summary>
        public static string willCnange = "{'1':'是','2':'否'}";

        /// <summary>
        /// C# 文件格式
        /// </summary>
        public static string[] cSharpFileEndType = { @".cs" };

        /// <summary>
        /// C# 正则匹配表达式
        /// </summary>
        public static string[] cSharpRegex = { @"[\t]*//[^\n]*\n" , @"/\*(.*\n)*?.*\*/" };

        /// <summary>
        /// Java 文件格式
        /// </summary>
        public static string[] javaFileEndType = { @".java" };

        /// <summary>
        /// Java 正则匹配表达式
        /// </summary>
        public static string[] javaRegex = { @"[\t]*//[^\n]*\n", @"/\*(.*\n)*?.*\*/" };

        /// <summary>
        /// JavaScript 文件格式
        /// </summary>
        public static string[] javascriptFileEndType = { @".js" };

        /// <summary>
        /// JavaScript 正则匹配表达式
        /// </summary>
        public static string[] javascriptRegex = { @"[\t]*//[^\n]*\n", @"/\*(.*\n)*?.*\*/" };
    }
}
