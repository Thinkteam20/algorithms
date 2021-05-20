//Binary Search tree 

using System;
namespace AssignmentTest
{

	public class BTreeNode
	{
		private Member aMember; // value
		private BTreeNode lchild; // reference to its left child 
		private BTreeNode rchild; // reference to its right child

		public BTreeNode(Member aMember)
		{
			this.aMember = aMember;
			lchild = null;
			rchild = null;
		}
		public Member Member
		{
			get;
			set;
		}

		public BTreeNode LChild
		{
			get { return lchild; }
			set { lchild = value; }
		}

		public BTreeNode RChild
		{
			get { return rchild; }
			set { rchild = value; }
		}
	}


    public class MemberCollection : iMemberCollection
    {
        public int Number => throw new NotImplementedException();
		private BTreeNode root;

		public void BSTree()
		{
			root = null;
		}

		public bool IsEmpty()
		{
			return root == null;
		}


		public void add(Member aMember)
        {
			if (root == null)
				root = new BTreeNode(aMember);
			else
				Insert(aMember, root);
		}

		private void Insert(Member aMember, BTreeNode ptr)
		{
			if (aMember.CompareTo(ptr.Member) < 0)
			{
				if (ptr.LChild == null)
					ptr.LChild = new BTreeNode(aMember);
				else
					Insert(aMember, ptr.LChild);
			}
			else
			{
				if (ptr.RChild == null)
					ptr.RChild = new BTreeNode(aMember);
				else
					Insert(aMember, ptr.RChild);
			}
		}

		public void delete(Member aMember)
        {
            throw new NotImplementedException();
        }

        public bool search(Member aMember)
        {
			return Search(aMember, root);
		}

		private bool Search(Member aMember, BTreeNode r)
		{
			if (r != null)
			{
				if (aMember.CompareTo(r.Member) == 0)
					return true;
				else
					if (aMember.CompareTo(r.Member) < 0)
					return Search(aMember, r.LChild);
				else
					return Search(aMember, r.RChild);
			}
			else
				return false;
		}


		public Member[] toArray()
        {
            throw new NotImplementedException();
        }
    }

}
