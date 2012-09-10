﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenArt.Core.AST
{
    public interface AbstractDnaDrawing
    {
        void Render(System.Drawing.Bitmap image, PaintEventArgs e, int scale);
    }
}
