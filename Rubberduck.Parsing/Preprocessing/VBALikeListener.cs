//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from VBALike.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Rubberduck.Parsing.PreProcessing {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="VBALikeParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IVBALikeListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] VBALikeParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] VBALikeParser.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.likePatternString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikePatternString([NotNull] VBALikeParser.LikePatternStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.likePatternString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikePatternString([NotNull] VBALikeParser.LikePatternStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.likePatternElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikePatternElement([NotNull] VBALikeParser.LikePatternElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.likePatternElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikePatternElement([NotNull] VBALikeParser.LikePatternElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.likePatternChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikePatternChar([NotNull] VBALikeParser.LikePatternCharContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.likePatternChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikePatternChar([NotNull] VBALikeParser.LikePatternCharContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.likePatternCharlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikePatternCharlist([NotNull] VBALikeParser.LikePatternCharlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.likePatternCharlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikePatternCharlist([NotNull] VBALikeParser.LikePatternCharlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.likePatternCharlistElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikePatternCharlistElement([NotNull] VBALikeParser.LikePatternCharlistElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.likePatternCharlistElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikePatternCharlistElement([NotNull] VBALikeParser.LikePatternCharlistElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.likePatternCharlistRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikePatternCharlistRange([NotNull] VBALikeParser.LikePatternCharlistRangeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.likePatternCharlistRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikePatternCharlistRange([NotNull] VBALikeParser.LikePatternCharlistRangeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBALikeParser.likePatternCharlistChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikePatternCharlistChar([NotNull] VBALikeParser.LikePatternCharlistCharContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBALikeParser.likePatternCharlistChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikePatternCharlistChar([NotNull] VBALikeParser.LikePatternCharlistCharContext context);
}
} // namespace Rubberduck.Parsing.PreProcessing
