----- RPN Calculator, By: Ankit Sadana -----

----- ReadMe -----

The RPN Calculator has been modified from as seen in class, this is the horizontal approach to the design.

1. lblFirstNum and lblSecondNum have been given an assignment variable x and y respectively so that user knows which is which.

2. All buttons have been moved into a 2x4 grid to save space and provide ease of access

3. The regular operations (+,-,*,/) are in the first 2x2 as they are more frequently used, while the other operations are in the second 2x2 grid.

3. Operations added: 
					Remainder operation : x % y 	: returns the remainder of x/y
					Inverse Sum			: 1/x + 1/y : returns 1/x + 1/y
					Sum whole square	: (x + y)^2	: returns the sum of x and y, whole squared
					Difference whole sq.: (x - y)^2	: returns the difference of x and y, whole squared

4. All buttons' labels have been changed to represent their function over x and y instead of just the operator symbols.
I feel this let's the user know more clearly what operation is about to performed.

5. With each operation, lblAnswer.Text is updated with "Answer <operation_performed>".
This ensures that user knows what operation was performed to get this result.

7. All text fields allow double values, zero values are not allowed in txtSecondNum for: (x / y), (x % y) and (1/x + 1/y)
Zero value is not allowed in txtFirstNum for: (1/x + 1/y).
Specific Error-MessageBoxes have been assigned to let user know if these are are zero values.

8. An appropriate icon and background color has been assigned to the form to go with the application's purpose.