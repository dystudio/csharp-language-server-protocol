using OmniSharp.Extensions.LanguageServer.Protocol.Models;

namespace OmniSharp.Extensions.LanguageServer.Protocol.Server.Capabilities
{
    public class DocumentSymbolOptions : WorkDoneProgressOptions, IDocumentSymbolOptions
    {
        public static DocumentSymbolOptions Of(IDocumentSymbolOptions options)
        {
            return new DocumentSymbolOptions() {
                WorkDoneProgress = options.WorkDoneProgress,
                
            };
        }
    }
}
