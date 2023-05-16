using Main;
while (true) {
    Console.WriteLine("Enter a range of arguments for expression in the form of 'start end' or 'exit' to exit the program");
    string input = Console.ReadLine();
    string[] range = input.Split(' ');
    
    if (input == "exit") break;
    if (!(input.Replace(" ", "").Replace("-", "").All(char.IsDigit)) || range.Length != 2) {
        Console.WriteLine("Invalid input");
        continue;
    }
    
    int start = Int32.Parse(range[0]);
    int end = Int32.Parse(range[1]);
    
    Expression[] expressions = new Expression[end - start];
    
    for (int i = start; i < end; i++) {
        Expression expression = new Expression(i, i*i + 2, i*2 - 5);
        expressions[i - start] = expression;
        
        Console.WriteLine($"Argument: a = {i}, d = {i*i + 2}, c = {i*2 - 5}");
        try {
            Console.WriteLine(expression + "\n");
        } catch (Exception e) {
            
            Console.WriteLine($"Expression: {expression.GetExpression()}");
            Console.WriteLine(e.Message + "\n");
        }
    }

}