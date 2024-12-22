namespace Composite.BinaryTree;

public class TreeNode<T>
{
    public T Value { get; set; }
    public TreeNode<T>? Left { get; set; } = null;
    public TreeNode<T>? Right { get; set; } = null;
    public TreeNode(T value)
    {
        Value = value;
    }
}