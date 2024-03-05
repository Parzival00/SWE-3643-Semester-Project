namespace CalculatorEngine;

public class Result
{
    public string Operation { get; set; }
    public string OperationResult{ get; set; }
    public bool IsSuccess{ get; set; }
    public string ErrorMessage{ get; set; }

    public override string ToString()
    {
        return Operation + OperationResult;
    }
}