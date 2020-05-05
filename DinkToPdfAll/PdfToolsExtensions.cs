using DinkToPdf;

namespace DinkToPdfAll
{
    public static class PdfToolsExtensions
    {
        public static SynchronizedConverter SyncConverter(this PdfTools _) => new SynchronizedConverter(_);
        public static BasicConverter Converter(this PdfTools _) => new BasicConverter(_);
    }
}
