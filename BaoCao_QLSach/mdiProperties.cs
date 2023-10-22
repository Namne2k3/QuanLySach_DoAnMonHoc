﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace BaoCao_QLSach
{
    public static class mdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwLong);
        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0X200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0X0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWO_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0X0020;
        private const uint SWO_NOOWNERZORDER = 0X0200;

        public static bool SetBevel( this Form form , bool show )
        {
            foreach ( Control c in form.Controls )
            {
                MdiClient client = c as MdiClient;
                if ( client != null )
                {
                    int windowlong = GetWindowLong(c.Handle, GWL_EXSTYLE);
                    if ( show )
                    {
                        windowlong |= WS_EX_CLIENTEDGE;
                    } else
                    {
                        windowlong &= WS_EX_CLIENTEDGE;
                    }
                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowlong);
                    SetWindowPos(client.Handle, IntPtr.Zero,0,0,0,0,
                        SWO_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWO_NOOWNERZORDER | SWP_FRAMECHANGED
                        );
                    return true;

                }
            }
            return false;
        }


    }
}
