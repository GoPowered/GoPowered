using GoPowered.Lang.Parser.Type;

namespace GoPowered.Lang.Parser.Token.Expr.Target
{
    public record ETConvert(IType Type, IAnyExpression Expr) : IExpressionTarget;
}
