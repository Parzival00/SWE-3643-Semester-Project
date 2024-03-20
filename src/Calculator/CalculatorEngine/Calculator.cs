namespace CalculatorEngine;

public class Calculator
{
    private double numA;
    private double numB;

    Result answer = new Result();

    //Converts string input to a double. Input A is stored in numA, Input B is stored in numB
    public Result setInput(int fieldNumber, string value)
    {
        //reseting answer object to empty values
        ClearAnswer();
        
        if (fieldNumber > 2 || fieldNumber < 1)
        {
            answer.ErrorMessage = "Field number must be 1 or 2.";
            answer.IsSuccess = false;
            return answer;
        }
        
        try
        {
            if (fieldNumber == 1)
                numA = double.Parse(value);
            else
                numB = double.Parse(value);
            answer.IsSuccess = true;
            
            return answer;
        }
        catch (Exception e)
        {
            answer.ErrorMessage = "Invalid input, numbers only.";
            answer.IsSuccess = false;
            return answer;
        }
            
    }

    //Utility function to clear data between function calls
    private void ClearAnswer()
    {
        answer.ErrorMessage = "";
        answer.Operation = "";
        answer.OperationResult = "";
        answer.IsSuccess = false;
    }

    public Result Divide()
    {
        ClearAnswer();
        
        answer.Operation = numA + " / " + numB + " = ";

        if (numB == 0)
        {
            answer.ErrorMessage = "Not a Number";
            answer.IsSuccess = false;
        }

        else
        {
            answer.OperationResult = (numA / numB).ToString();
            answer.IsSuccess = true;
        }

        return answer;
    }

    public Result Multiply()
    {
        ClearAnswer();
        
        answer.Operation = numA + " * " + numB + " = ";
        answer.OperationResult = (numA * numB).ToString();
        answer.IsSuccess = true;

        return answer;
    }

    public Result Add()
    {
        ClearAnswer();
        
        answer.Operation = numA + " + " + numB + " = ";
        answer.OperationResult = (numA + numB).ToString();
        answer.IsSuccess = true;

        return answer;
    }

    public Result Subtract()
    {
        ClearAnswer();
        
        answer.Operation = numA + " - " + numB + " = ";
        answer.OperationResult = (numA - numB).ToString();
        answer.IsSuccess = true;

        return answer;
    }

    public Result Equals()
    {
        ClearAnswer();
        
        answer.Operation = numA + " == " + numB + " = ";
        
        var tolerance = Math.Pow(10, -8);
        var absoluteValueOfDiff = Math.Abs(numA - numB);
        var isWithinTolerance = absoluteValueOfDiff <= tolerance;

        answer.OperationResult = (isWithinTolerance) ? "1" : "0";
        
        answer.IsSuccess = true;
        return answer;
    }
    
    public Result Power()
    {
        ClearAnswer();
        
        answer.Operation = numA + " ^ " + numB + " = ";
        answer.OperationResult = (Math.Pow(numA,numB)).ToString();
        answer.IsSuccess = true;

        return answer;
    }
    
    public Result Log()
    {
        ClearAnswer();
        
        answer.Operation = numA + " log " + numB + " = ";

        if (numA <= 0)
        {
            answer.ErrorMessage = "Input A must be greater than 0";
            answer.IsSuccess = false;
        }
        else if (numB == 0)
        {
            answer.ErrorMessage = "Input B must be non-zero";
            answer.IsSuccess = false;
        }
        else
        {
            answer.OperationResult = (Math.Log(numA, numB)).ToString();
            answer.IsSuccess = true;
        }

        return answer;
    }
    
    public Result Root()
    {
        ClearAnswer();
        
        answer.Operation = numA + " root " + numB + " = ";

        if (numB == 0)
        {
            answer.ErrorMessage = "Input B must be non-zero";
            answer.IsSuccess = false;
        }
        else
        {
            answer.OperationResult = (Math.Pow(numA, (1.0/numB))).ToString();
            answer.IsSuccess = true;
        }

        return answer;
    }
    
    public Result Factorial()
    {
        ClearAnswer();
        
        answer.Operation = numA + "! " + " = ";

        if (numA == 0)
        {
            answer.OperationResult = "1";
            answer.IsSuccess = true;
        }
        else
        {
            //we need to see how to accommodate for decimal numbers
            int solution = 1;
            for(int i = Math.Abs((int)numA); i > 0; i--) 
                solution *= i;
            
            if (numA < 0)
                solution = -solution;
 
            answer.OperationResult = solution.ToString();
            answer.IsSuccess = true;
        }

        return answer;
    }

    public Result Sin()
    {
        ClearAnswer();
        
        answer.Operation = "Sin(" + numA +  ") = ";
            
        answer.OperationResult = (Math.Sin(numA)).ToString();
        answer.IsSuccess = true;

        return answer;
    }
    
    public Result Cos()
    {
        ClearAnswer();
        
        answer.Operation = "Cos(" + numA +  ") = ";
        
        answer.OperationResult = (Math.Cos(numA)).ToString();
        answer.IsSuccess = true;
 
        return answer;
    }
    
    public Result Tan()
    {
        ClearAnswer();
        
        answer.Operation = "Tan(" + numA +  ") = ";
            
        answer.OperationResult = (Math.Tan(numA)).ToString();
        answer.IsSuccess = true;

        return answer;
    }
    
    public Result Reciprocal()
    {
        ClearAnswer();
        
        answer.Operation = "1 / " + numA + " = ";

        if (numA == 0)
        {
            answer.ErrorMessage = "Num A must be non-zero";
            answer.IsSuccess = false;
        }
        else
        {
            answer.OperationResult = (1/numA).ToString();
            answer.IsSuccess = true;
        }

        return answer;
    }
}