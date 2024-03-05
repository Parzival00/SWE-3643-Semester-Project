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
        return answer;
    }

    public Result Add()
    {
        return answer;
    }

    public Result Subtract()
    {
        return answer;
    }
    
}