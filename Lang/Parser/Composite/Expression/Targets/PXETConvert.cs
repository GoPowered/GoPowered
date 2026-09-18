using GoPowered.Lang.Lexer.Token;
using GoPowered.Lang.Parser.Token.Expr.Target;

namespace GoPowered.Lang.Parser
{
    public partial class Parser
    {
        protected partial ETConvert? ParseConvert(bool allowInit, bool constant)
        {
            int index = this.index;

            if (ParseType_out(out var type, optional: true) && Now([(null, Operator.LParen.ToToken())], consume: false))
            {
                Require(Operator.LParen.ToToken(), "'('");
                var value = ParseExpression(allowInit: allowInit, constant: constant);
                Require(Operator.RParen.ToToken(), "')'");

                return new ETConvert(type!, value);
            }
            else
            {
                this.index = index;
            }

            return null;
        }
    }
}
