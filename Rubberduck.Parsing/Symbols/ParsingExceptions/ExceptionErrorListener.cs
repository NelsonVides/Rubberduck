﻿using Antlr4.Runtime;

namespace Rubberduck.Parsing.Symbols.ParsingExceptions
{
    public class ExceptionErrorListener : BaseErrorListener
    {
        public override void SyntaxError(System.IO.TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            // adding 1 to line, because line is 0-based, but it's 1-based in the VBE
            throw new SyntaxErrorException(msg, e, offendingSymbol, line, charPositionInLine + 1);
        }
    }
}
