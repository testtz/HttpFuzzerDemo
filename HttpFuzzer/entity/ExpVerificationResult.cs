﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoveCoody.entity
{
    public class ExpVerificationResult
    {
        /// <summary>
        /// 0验证失败
        /// 1验证成功
        /// 2连接失败
        /// </summary>
        private Int32 code;

        public Int32 Code
        {
            get { return code; }
            set { code = value; }
        }

        private String result;

        public String Result
        {
            get { return result; }
            set { result = value; }
        }

        private String expName;

        public String ExpName
        {
            get { return expName; }
            set { expName = value; }
        }

        private string html;

        public string Html
        {
            get { return html; }
            set { html = value; }
        }
        private Int32 index;

        public Int32 Index
        {
            get { return index; }
            set { index = value; }
        }

    }
}
