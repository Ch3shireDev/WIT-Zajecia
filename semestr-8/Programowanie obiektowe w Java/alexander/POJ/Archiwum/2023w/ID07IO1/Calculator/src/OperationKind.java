public enum OperationKind
{
    OpAdd("+"),
    OpSub("-"),
    OpMul("*"),
    OpDiv("/"),
    OpPow("^");
    private OperationKind(String code)
    {
        this.code=code;
    }
    private final String code;
    @Override public String toString() { return code; }
}
