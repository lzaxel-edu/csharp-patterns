using System.Collections;
using Composite.Components;

namespace Composite.BinaryTree;

public class BinaryTree<T>: IEnumerable<T> where T: IComponent
{
    public TreeNode<T>? Root { get; private set; } = null;

    public void Insert(T value)
    {
        Root = InsertRecursive(Root, value);
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return WalkLRRRecursive(Root).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private TreeNode<T> InsertRecursive(TreeNode<T>? node, T value)
    {
        if (node == null)
        {
            return new TreeNode<T>(value);
        }

        if (value.GetValue().First().CompareTo(node.Value.GetValue().First()) < 0)
        {
            node.Left = InsertRecursive(node.Left, value);
        }
        else if (value.GetValue().First().CompareTo(node.Value.GetValue().First()) > 0)
        {
            node.Right = InsertRecursive(node.Right, value);
        }

        return node;
    }

    public IEnumerable<T> WalkLRR()
    {
        return WalkLRRRecursive(Root);
    }

    private IEnumerable<T> WalkLRRRecursive(TreeNode<T> node)
    {
        if (node != null)
        {
            foreach (var left in WalkLRRRecursive(node.Left))
            {
                yield return left;
            }

            yield return node.Value;
            foreach (var right in WalkLRRRecursive(node.Right))
            {
                yield return right;
            }
        }
    }
}