using DinkToPdf;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinkToPdfAll
{
    public static class PdfToolsFactory
    {
        public static PdfTools Create() => new PdfTools();
    }
}
