
using System;

class Node
{
    public Node Left { get; set; }
    public Node Right { get; set; }
    public int Data { get; set; }
    public Node(int data) {
        this.Data = data;
    }
    public void insert(int value) {
        if (value <= Data) {
            if (Left == null)
                Left = new Node(value);
            else
                Left.insert(value);

        }
        else
            if (right == null)
            right = new Node(value);
        else
            right.insert(value);
    }
    public bool contains(int value)
    {
        if (value == data)
            return true;
        else if (value < data)
        {
            if (Left == null)
                return false;
            else {
                return Left.contains(value);
            }
                   
        }else //else value is bigger that the node
            

    }
