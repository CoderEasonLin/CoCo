using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoCo
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey( IntPtr hWnd, int id, uint fsModifiers, Keys vk );

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool UnregisterHotKey( IntPtr hWnd, int id );

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lBox.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (lBox.SelectedItems.Count > 0)
                lBox.Items.Remove(lBox.SelectedItems[0]);
        }

        private void cbStayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = cbStayOnTop.Checked;
        }

        private void tbVisibility_Scroll(object sender, EventArgs e)
        {
            Opacity = 1 - ((double)tbVisibility.Value * 0.1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(Handle, 100, 2, Keys.Oemtilde);
            RegisterHotKey(Handle, 300, 2, Keys.Decimal);

            RegisterHotKey(Handle, 101, 2, Keys.NumPad1);
            RegisterHotKey(Handle, 102, 2, Keys.NumPad2);
            RegisterHotKey(Handle, 103, 2, Keys.NumPad3);
            RegisterHotKey(Handle, 104, 2, Keys.NumPad4);
            RegisterHotKey(Handle, 105, 2, Keys.NumPad5);
            RegisterHotKey(Handle, 106, 2, Keys.NumPad6);
            RegisterHotKey(Handle, 107, 2, Keys.NumPad7);
            RegisterHotKey(Handle, 108, 2, Keys.NumPad8);
            RegisterHotKey(Handle, 109, 2, Keys.NumPad9);

            RegisterHotKey(Handle, 201, 2, Keys.D1);
            RegisterHotKey(Handle, 202, 2, Keys.D2);
            RegisterHotKey(Handle, 203, 2, Keys.D3);
            RegisterHotKey(Handle, 204, 2, Keys.D4);
            RegisterHotKey(Handle, 205, 2, Keys.D5);
            RegisterHotKey(Handle, 206, 2, Keys.D6);
            RegisterHotKey(Handle, 207, 2, Keys.D7);
            RegisterHotKey(Handle, 208, 2, Keys.D8);
            RegisterHotKey(Handle, 209, 2, Keys.D9);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(Handle, 100);
            UnregisterHotKey(Handle, 300);

            UnregisterHotKey(Handle, 101);
            UnregisterHotKey(Handle, 102);
            UnregisterHotKey(Handle, 103);
            UnregisterHotKey(Handle, 104);
            UnregisterHotKey(Handle, 105);
            UnregisterHotKey(Handle, 106);
            UnregisterHotKey(Handle, 107);
            UnregisterHotKey(Handle, 108);
            UnregisterHotKey(Handle, 109);

            UnregisterHotKey(Handle, 201);
            UnregisterHotKey(Handle, 202);
            UnregisterHotKey(Handle, 203);
            UnregisterHotKey(Handle, 204);
            UnregisterHotKey(Handle, 205);
            UnregisterHotKey(Handle, 206);
            UnregisterHotKey(Handle, 207);
            UnregisterHotKey(Handle, 208);
            UnregisterHotKey(Handle, 209);
        }

        private void HK_CopyText()
        {
            KeyboardUtil.Event.Send(KeyboardUtil.VKey.VK_CONTROL, 0);
            KeyboardUtil.Event.Send(KeyboardUtil.VKey.VK_C, 0);
            KeyboardUtil.Event.Send(KeyboardUtil.VKey.VK_C, 2);
            KeyboardUtil.Event.Send(KeyboardUtil.VKey.VK_CONTROL, 2);

            // for clipboard data processing
            System.Threading.Thread.Sleep(100);

            string copyData = "";
            IDataObject iData = null;
            try
            {
                iData = Clipboard.GetDataObject();
            }
            catch (Exception ex)
            { }

            if (iData != null && iData.GetDataPresent(DataFormats.StringFormat))
            {
                copyData = (String)iData.GetData(DataFormats.StringFormat);
                lBox.Items.Add(copyData);
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                switch (m.WParam.ToInt32())
                {
                    case 100:
                        HK_CopyText();
                        break;

                    case 101:
                    case 102:
                    case 103:
                    case 104:
                    case 105:
                    case 106:
                    case 107:
                    case 108:
                    case 109:
                        tbItemCount.Text = (m.WParam.ToInt32() - 100).ToString();
                        break;

                    case 201:
                    case 202:
                    case 203:
                    case 204:
                    case 205:
                    case 206:
                    case 207:
                    case 208:
                    case 209:
                        tbItemCount.Text = (m.WParam.ToInt32() - 200).ToString();
                        break;

                    case 300:
                        lBox.Items.Clear();
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private void lBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                lBox.Items.RemoveAt(lBox.SelectedIndex);
        }

        private void lBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBox.SelectedIndex < 0)
                return;

            int count = Convert.ToInt32(tbItemCount.Text);
            if (count < 0 || count > 10)
                count = 1;

            String text = "";

            for (int i = lBox.SelectedIndex; i < lBox.Items.Count; i++)
            {
                String item = (String)lBox.Items[i];

                if (item != null)
                    text += item;

                if (i < lBox.Items.Count - 1 && text.Length > 0)
                {
                    if ((i - lBox.SelectedIndex + 1) % count == 0)
                        text += "\n";
                    else
                        text += "\t";
                }
            }

            if (text != null)
                Clipboard.SetText(text, TextDataFormat.Text);
        }

        private void tbItemCount_TextChanged(object sender, EventArgs e)
        {
            if (lBox.Items.Count > 0)
            {
                if (lBox.SelectedIndex >= 0)
                    lBox_SelectedIndexChanged(this.lBox, EventArgs.Empty);
                else
                    lBox.SelectedIndex = 0;
            }
        }
    }
}
