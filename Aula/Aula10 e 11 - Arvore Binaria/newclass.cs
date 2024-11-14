using Aula_11___Arvore_Binaria;

namespace Aula10_e_11___Arvore_Binaria
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> ?Root { get; set; }
        public int Count { get; set; } 
        public enum TraversalEnum
        {
            PREORDER, INORDER, POSTODER
        }

        public void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null )
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        public void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null )
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        public void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null )
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        public List<BinaryTreeNode<T>> Traverse(
            TraversalEnum mode
        )
        {
            List<BinaryTreeNode<T>> nodes =
                new List<BinaryTreeNode<T>>();

                switch(mode)
                {
                    case TraversalEnum.PREORDER :
                        TraversePreOrder(Root!, nodes);
                    break;

                    case TraversalEnum.POSTODER :
                        TraversePostOrder(Root!, nodes);
                    break;

                    case TraversalEnum.INORDER :
                        TraversePostOrder(Root!, nodes);
                    break;
                        
                }
                return nodes;
        }

        public int GetHeoght()
        {
            int height = 0;
            foreach(BinaryTreeNode<T> node in Traverse(TraversalEnum.PREORDER)
            )
            {
                height = Math.Max(height, node.GetHeight());
            }
            return height;
        } 
    }
}