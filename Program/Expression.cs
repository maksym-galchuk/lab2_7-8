namespace Main; 

public class Expression {
    private double a;
    private double d;
    private double c;
    
    private double result;


    public Expression(double a, double d, double c) {
        this.a = a;
        this.d = d;
        this.c = c;
    }
    
    public double Calculate() {
        double ln = Math.Log(1 - a / 4);
        if (ln == 0) throw new Exception($"Division by zero exeption: Ln(1 - {a} / 4) = 0");
        if ((1 - a / 4) <= 0) throw new Exception($"Invalid argument exeption: Ln(1 - {a} / 4) <= 0");
        
        result = (2 * c - d / 23) / ln;
        // return result with 2 decimal places
        return Math.Round(result, 2);
    }
    
    public string GetExpression() => $"(2 * {c} - {d} / 23) / (Ln(1 - {a} / 4))";
    
    public override string ToString() {
        return $"Expression: {GetExpression()}\nResult: {Calculate()}";
    }
}