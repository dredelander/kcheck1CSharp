namespace CalculatorTest;
using static KnowledgeCheck1_Calculator.InputValidation;

public class InputValidationTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void InputValidationPass()
    {
        //--Arrange
        string input1 = "2";
        string input2 = "3";
        string operation = " + ";
        bool response = true;

        var expected = (2, 3, $"{input1} {operation} {input2} = ", response);

        //--Act

        var actual = Validate(input1, input2, operation);
        

        //--Asert

        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void InputValidationFail()
    {
        //--Arrange
        string input1 = "2";
        string input2 = "r";
        string operation = " - ";
        bool response = false;

        var expected = (0, 0, "One or more of the numbers is not an int", response);

        //--Act

        var actual = Validate(input1, input2, operation);


        //--Asert

        Assert.That(expected, Is.EqualTo(actual));
    }
}
