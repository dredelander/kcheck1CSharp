using System;
namespace KnowledgeCheck1_Calculator
{
	public class InputValidation
	{

        public static (int input1, int input2, string message, bool response) Validate(params string[] values)
		{
			if (int.TryParse(values[0], out int outNum1) && int.TryParse(values[1], out int outNum2))
				return (outNum1, outNum2, $"{outNum1} {values[2]} {outNum2} = ", true);
			else
				return (0, 0, "One or more of the numbers is not an int", false);
        }
	}
}

