public class Solution {
     public string AddBinary(string a, string b) {
    Stack<int> stackA = new Stack<int>();
    Stack<int> stackB = new Stack<int>();
    Stack<int> resultStack = new Stack<int>();
    int carry = 0;

    foreach (char c in a) {
        stackA.Push(c - '0');
    }

    foreach (char c in b) {
        stackB.Push(c - '0');
    }

    while (stackA.Count > 0 || stackB.Count > 0 || carry > 0) {
        int sum = carry;
        if (stackA.Count > 0) {
            sum += stackA.Pop();
        }
        if (stackB.Count > 0) {
            sum += stackB.Pop();
        }
        resultStack.Push(sum % 2);
        carry = sum / 2;
    }

    StringBuilder result = new StringBuilder();
    while (resultStack.Count > 0) {
        result.Append(resultStack.Pop());
    }

    return result.ToString();
    }
}

