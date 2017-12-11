using System;
using Antlr4.Runtime;

namespace Rubberduck.Parsing.Symbols.ParsingExceptions
{
    public class SyntaxErrorNotificationListener : BaseErrorListener
    {
        public event EventHandler<SyntaxErrorEventArgs> OnSyntaxError; //NOTE: new parameter added, but this class is never referenced so nothing to break (?)
        public override void SyntaxError(System.IO.TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            var info = new SyntaxErrorInfo(msg, e, offendingSymbol, line, charPositionInLine);
            NotifySyntaxError(info);
        }

        private void NotifySyntaxError(SyntaxErrorInfo info)
        {
            var handler = OnSyntaxError;
            if (handler != null)
            {
                handler.Invoke(this, new SyntaxErrorEventArgs(info));
            }
        }
    }

    public class SyntaxErrorEventArgs : EventArgs
    {
        private readonly SyntaxErrorInfo _info;

        public SyntaxErrorEventArgs(SyntaxErrorInfo info)
        {
            _info = info;
        }

        public SyntaxErrorInfo Info { get { return _info; } }
    }
}