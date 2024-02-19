#include <iostream>
using namespace std;

int main()
{
    // Inputs
    int num1, num2, result;
    char op;

    // Prompting the user to input two numbers and the operation
    cout << "Enter the first number: ";
    cin >> num1;
    cout << "Enter the second number: ";
    cin >> num2;
    cout << "Enter the operator (+, -, *, /): ";
    cin >> op;

    // Performing the operation based on the operator
    if (op == '+' || op == '-' || op == '*' || op == '/')
    {
        // Handling division by zero case
        if (op == '/' && num2 == 0)
        {
            cout << "Cannot divide by zero!" << endl;
        }
        else
        {
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            cout << num1 << " " << op << " " << num2 << " = " << result << endl;
        }
    }
    else
    {
        cout << "Unsupported operator!" << endl;
    }

    return 0;
}
