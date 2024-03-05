namespace CalculatorEngine;

public class Calculator
{
    public string InputA { get; set; }
    public string InputB { get; set; }

    private double numA;
    private double numB;

    
    Result answer = new Result();
    
    private void ParseOneNumber()
    {
        try
        {
            numA = double.Parse(InputA);
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Invalid input, number only.";
        }
    }

    private void ParseTwoNumbers()
    {
        try
        {
            numA = double.Parse(InputA);
            numB = double.Parse((InputB));
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Invalid input, number only.";
        }
    }
    
    public Result Divide()
    {
        try
        {
            ParseTwoNumbers();
                
            answer.Operation = InputA + " / " + InputB + " = ";

            if (numB == 0)
            {
                answer.OperationResult = "Not a Number";
                answer.IsSuccess = false;
            }

            else
            {
                answer.OperationResult = (numA / numB).ToString();
                answer.IsSuccess = true;
            }
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }

        return answer;
    }

    public Result Multiply()
    {
        try
        {
            ParseTwoNumbers();
            answer.Operation = InputA + " * " + InputB + " = ";
            answer.OperationResult = (numA * numB).ToString();
            answer.IsSuccess = true;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }

    public Result Add()
    {
        try
        {
            ParseTwoNumbers();
            answer.Operation = InputA + " + " + InputB + " = ";
            answer.OperationResult = (numA + numB).ToString();
            answer.IsSuccess = true;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }

    public Result Subtract()
    {
        try
        {
            ParseTwoNumbers();
            answer.Operation = InputA + " - " + InputB + " = ";
            answer.OperationResult = (numA - numB).ToString();
            answer.IsSuccess = true;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }

    public Result Equals()
    {
        return answer;
    }
    
    public Result Power()
    {
        try
        {
            ParseTwoNumbers();
            answer.Operation = InputA + " ^ " + InputB + " = ";
            answer.OperationResult = (Math.Pow(numA,numB)).ToString();
            answer.IsSuccess = true;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }
    
    public Result Log()
    {
        try
        {
            ParseTwoNumbers();
            answer.Operation = InputA + " Log " + InputB + " = ";

            if (numA <= 0)
            {
                answer.OperationResult = "Num A must be greater than 0";
                answer.IsSuccess = false;
            }
            else if (numB == 0)
            {
                answer.OperationResult = "Num B must be non-zero";
                answer.IsSuccess = false;
            }
            else
            {
                answer.OperationResult = (numA * Math.Log(numB)).ToString();
                answer.IsSuccess = true;
            }
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }
    
    public Result Root()
    {
        try
        {
            ParseTwoNumbers();
            answer.Operation = InputA + " root " + InputB + " = ";

            if (numB == 0)
            {
                answer.OperationResult = "Num B must be non-zero";
                answer.IsSuccess = false;
            }
            else
            {
                answer.OperationResult = (Math.Pow(numA, 1/numB)).ToString();
                answer.IsSuccess = true;
            }
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }
    
    public Result Factorial()
    {
        try
        {
            ParseOneNumber();
            answer.Operation = InputA + "! " + " = ";

            if (numA == 0)
            {
                answer.OperationResult = "1";
                answer.IsSuccess = true;
            }
            else
            {
                //we need to see how to accommodate for decimal numbers
                
                if (numA < 0)
                {
                    int solution = GetFactorial((int)numA);
                    solution = -solution;
                    answer.OperationResult = solution.ToString();
                }
                else
                {
                    answer.OperationResult = GetFactorial((int) numA).ToString();
                }
                answer.IsSuccess = true;
            }
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }

    public int GetFactorial(int num)
    {
        int solution = 1;
        for(int i = Math.Abs(num); i > 0; i--) 
            solution *= i;
        return solution;
    }
    
    public Result Sin()
    {
        try
        {
            ParseOneNumber();
            answer.Operation = "Sin(" + InputA +  ") = ";
            
            answer.OperationResult = (Math.Sin(numA)).ToString();
            answer.IsSuccess = true;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }
    
    public Result Cos()
    {
        try
        {
            ParseOneNumber();
            answer.Operation = "Cos(" + InputA +  ") = ";
            
            answer.OperationResult = (Math.Cos(numA)).ToString();
            answer.IsSuccess = true;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }
    
    public Result Tan()
    {
        try
        {
            ParseOneNumber();
            answer.Operation = "Tan(" + InputA +  ") = ";
            
            answer.OperationResult = (Math.Tan(numA)).ToString();
            answer.IsSuccess = true;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }
    
    public Result Reciprocal()
    {
        try
        {
            ParseOneNumber();
            answer.Operation = "1 / " + InputA + " = ";

            if (numA == 0)
            {
                answer.OperationResult = "Num A must be non-zero";
                answer.IsSuccess = false;
            }
            else
            {
                answer.OperationResult = (1/numA).ToString();
                answer.IsSuccess = true;
            }
        }
        catch (Exception e)
        {
            answer.ErrorMessage = e.Message;
            answer.OperationResult = "Not a Number";
            answer.IsSuccess = false;
        }
        return answer;
    }
}