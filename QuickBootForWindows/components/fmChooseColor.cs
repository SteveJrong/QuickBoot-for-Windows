using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuickBootForWindows.common;

namespace QuickBootForWindows.components
{
    public partial class fmChooseColor : Form
    {
        /// <summary>
        /// 显示设备上下文环境的句柄。
        /// </summary>
        private IntPtr _hdc = IntPtr.Zero;

        /// <summary>
        /// 指向窗口的句柄。
        /// </summary>
        private readonly IntPtr _hWnd = IntPtr.Zero;

        public fmChooseColor()
        {
            InitializeComponent();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point p = MousePosition;

            this.lPosition.Text = string.Format("X:{0},Y:{1}", p.X, p.Y);

            uint color = Win32Helper.GetPixel(_hdc, p.X, p.Y);
            byte r = Win32Helper.GetRValue(color);
            byte g = Win32Helper.GetGValue(color);
            byte b = Win32Helper.GetBValue(color);

            this.tBChooseColorRed.Text = Convert.ToString(r);
            this.tBChooseColorGreen.Text = Convert.ToString(g);
            this.tBChooseColorBlue.Text = Convert.ToString(b);

            this.lColorShow.BackColor = Color.FromArgb(r, g, b);
            this.tB16Color.Text = "#" + r.ToString("X").PadLeft(2, '0') + g.ToString("X").PadLeft(2, '0') +
                               b.ToString("X").PadLeft(2, '0');
        }

        private void btnChooseColor_MouseDown(object sender, MouseEventArgs e)
        {
            _hdc = Win32Helper.GetDC(_hWnd);
            Cursor = Cursors.Cross;
            this.t1.Enabled = true;
            this.lColorShow.Text = null;
        }

        private void btnChooseColor_MouseUp(object sender, MouseEventArgs e)
        {
            Win32Helper.ReleaseDC(_hWnd, _hdc);
            Cursor = Cursors.Default;
            this.t1.Enabled = false;
        }
    }
}
