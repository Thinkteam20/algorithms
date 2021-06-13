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
				add(aMember, root);
		}

		private void add(Member aMember, BTreeNode ptr)
		{
			if (aMember.CompareTo(ptr.Member) < 0)
			{
				if (ptr.LChild == null)
					ptr.LChild = new BTreeNode(aMember);
				else
					add(aMember, ptr.LChild);
			}
			else
			{
				if (ptr.RChild == null)
					ptr.RChild = new BTreeNode(aMember);
				else
					add(aMember, ptr.RChild);
			}
		}

		public void delete(Member aMember)
        {
			// search for item and its parent
			BTreeNode ptr = root; // search reference
			BTreeNode parent = null; // parent of ptr
			while ((ptr != null) && (aMember.CompareTo(ptr.Member) != 0))
			{
				parent = ptr;
				if (aMember.CompareTo(ptr.Member) < 0) // move to the left child of ptr
					ptr = ptr.LChild;
				else
					ptr = ptr.RChild;
			}

			if (ptr != null) // if the search was successful
			{
				// case 3: item has two children
				if ((ptr.LChild != null) && (ptr.RChild != null))
				{
					// find the right-most node in left subtree of ptr
					if (ptr.LChild.RChild == null) // a special case: the right subtree of ptr.LChild is empty
					{
						ptr.Member = ptr.LChild.Member;
						ptr.LChild = ptr.LChild.LChild;
					}
					else
					{
						BTreeNode p = ptr.LChild;
						BTreeNode pp = ptr; // parent of p
						while (p.RChild != null)
						{
							pp = p;
							p = p.RChild;
						}
						// copy the item at p to ptr
						ptr.Member = p.Member;
						pp.RChild = p.LChild;
					}
				}
				else // cases 1 & 2: item has no or only one child
				{
					BTreeNode c;
					if (ptr.LChild != null)
						c = ptr.LChild;
					else
						c = ptr.RChild;

					// remove node ptr
					if (ptr == root) //need to change root
						root = c;
					else
					{
						if (ptr == parent.LChild)
							parent.LChild = c;
						else
							parent.RChild = c;
					}
				}

			}
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
			//iMember[] members = new iMember[100];

			throw new NotImplementedException();
		}

		public void InOrderTraverse()
		{
			Console.Write("InOrder: ");
			InOrderTraverse(root);
			Console.WriteLine();
		}

		private void InOrderTraverse(BTreeNode root)
		{
			if (root != null)
			{
				InOrderTraverse(root.LChild);
				Console.Write(root.Member);
				InOrderTraverse(root.RChild);
			}
		}

		/*

		private Customer[] customers;
        private int noCustomers;

        public CustomerCollection()
        {
            customers = new Customer[10];
            noCustomers = 0;
        }

		 public void Insert(string lastname, string firstname, int mobile)
        {
            Customer aCustomer = new Customer(lastname, firstname, mobile);
            customers[noCustomers] = aCustomer;
            noCustomers++;
        }
		 */
	}

}
