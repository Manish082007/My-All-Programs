namespace All_Programs
{
  public class Node
  {
    public Node(int value)
    {
      Value = value;
    }

    public int Value { get; set; } = 0;

    public Node Parent { get; set; }
    
    public Node Left { get; set; }
   
    public Node Right { get; set; }
  }
}
