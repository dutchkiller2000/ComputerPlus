﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage.Forms;

namespace ComputerPlus.Extensions.Gwen
{
    static class GwenFormExtension
    {
        internal static void Close(this GwenForm form)
        {
            if (form.Window.IsClosable)
                form.Window.Close();
        }
        internal static bool IsOnTop(this GwenForm form)
        {
            try
            {
                return form.Window.IsOnTop;
            }
            catch
            {
                return false;
            }
        }

        internal static bool IsOpen(this GwenForm form)
        {
            try
            {
                return form.Window.IsVisible;
            }
            catch
            {
                return false;
            }
        }

        internal static bool Exists(this GwenForm form)
        {
            try
            {
                return form.Window != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
