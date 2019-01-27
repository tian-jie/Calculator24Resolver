using System;
using System.Collections.Generic;

namespace JT.Algorithm
{
    public class Calculator24
    {
        public string Calculate(int[] x){
            var result = CalculateNode(x);
            return result ==null?"no answer":result.ToString();
        }

        public Node CalculateNode(int[] x){

            List<Node> nodes = new List<Node>();

            foreach(var x0 in x){
                nodes.Add(new Node()
                {
                    val = x0,
                    isOpr = false
                });
            }

            return Calculator(nodes.ToArray());
        }

        private Node Calculator(Node[] input){
            // try to calculate
            for (int i = 0; i < input.Length; i++){
                for (int j = i + 1; j < input.Length; j++){
                    // take 2 and calculator
                    var x = input[i];
                    var y = input[j];

                    var node = Add(x, y);
                    var r = CheckAndContinue(input, node);
                    if (r != null)
                    {
                        return r;
                    }

                    node = Sub(x, y);
                    r = CheckAndContinue(input, node);
                    if (r != null)
                    {
                        return r;
                    }

                    node = Sub(y, x);
                    r = CheckAndContinue(input, node);
                    if (r != null)
                    {
                        return r;
                    }

                    node = Mul(x, y);
                    r = CheckAndContinue(input, node);
                    if (r != null)
                    {
                        return r;
                    }

                    if (Math.Abs(y.val) < 0.0001)
                    {
                        node = Div(x, y);
                        r = CheckAndContinue(input, node);
                        if (r != null)
                        {
                            return r;
                        }
                    }
                    if (Math.Abs(y.val) < 0.0001){
                        node = Div(y, x);
                        r = CheckAndContinue(input, node);
                        if (r != null)
                        {
                            return r;
                        }
                    }
                }
            }

            return null;
        }


        public static Node Add(Node x, Node y)
        {
            var newNode = new Node()
            {
                val = x.val + y.val,
                l = x,
                r = y,
                isOpr = true,
                opr = '+'
            };

            return newNode;
        }

        public static Node Sub(Node x, Node y)
        {
            var newNode = new Node()
            {
                val = x.val - y.val,
                l = x,
                r = y,
                isOpr = true,
                opr = '-'
            };

            return newNode;
        }

        public static Node Mul(Node x, Node y)
        {
            var newNode = new Node()
            {
                val = x.val * y.val,
                l = x,
                r = y,
                isOpr = true,
                opr = '*'
            };

            return newNode;
        }

        public static Node Div(Node x, Node y)
        {
            var newNode = new Node()
            {
                val = x.val / y.val,
                l = x,
                r = y,
                isOpr = true,
                opr = '/'
            };

            return newNode;
        }

        public Node CheckAndContinue(Node[] input, Node currentNode)
        {
            if (input.Length == 2)
            {
                return Math.Abs(currentNode.val - 24.0f) < 0.0001 ? currentNode : null;
            }
            var newInput = new List<Node>();
            foreach (var n in input)
            {
                if (n != currentNode.l && n != currentNode.r)
                {
                    newInput.Add(n);
                }
            }
            newInput.Add(currentNode);
            return Calculator(newInput.ToArray());
        }

    }

    public class Node{
        public double val { get; set; }
        public bool isOpr { get; set; }
        public Node l { get; set; }
        public char opr { get; set; }
        public Node r { get; set; }

        public override string ToString(){
            if(isOpr){
                return '(' + l.ToString() + opr + r.ToString() + ')';
            }else{
                return val.ToString();
            }
        }
    }
}
