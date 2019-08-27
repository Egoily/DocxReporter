using System;
using System.Windows.Forms;

namespace DocxSearcher
{
    public class TipButton : Button
    {

        public string TipText { get; set; }
        public TipButton()
        {

        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);

            if (!string.IsNullOrEmpty(TipText))
            {
                ToolTip toolTip = new ToolTip();
                // 设置显示样式
                toolTip.AutoPopDelay = 5000;//提示信息的可见时间
                toolTip.InitialDelay = 500;//事件触发多久后出现提示
                toolTip.ReshowDelay = 500;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
                toolTip.ShowAlways = true;//是否显示提示框
                toolTip.SetToolTip(this, TipText);//设置提示按钮和提示内容
            }

        }
    }
}
