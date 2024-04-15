public class MyQueue {
    private Stack<int> stack1; //pilha de push
    private Stack<int> stack2; //pilha de pop e peek

    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    //Insere no fim da fila
    public void Push(int x) {
        stack1.Push(x);
        
    }
    //Remove o primeiro elemento do início da fila e retorna
    public int Pop() {
        TransferFromStacks();
        return stack2.Pop();
        
    }
    //Retorna sem remover o primeiro da fila
    public int Peek() {
        TransferFromStacks();
        return stack2.Peek();
        
    }
    //Verifica se a fila é vazia
    public bool Empty() {
        return stack1.Count == 0 && stack2.Count == 0;
        
    }
    //Passar da fila 1 para a 2
    private void TransferFromStacks(){
        if(stack2.Count==0){
            while(stack1.Count>0){
                stack2.Push(stack1.Pop());
            }
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */