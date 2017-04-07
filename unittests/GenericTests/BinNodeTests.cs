using System;
using EduLib;
using NUnit.Framework;

namespace unittests
{
	[TestFixture]
	public class BinNodeTests
	{
		private BinNode<int> binaryTree;
		[SetUp]
		public void Setup()
		{
			this.binaryTree = new BinNode<int>(1);
		}

		[Test, Description("Should construct a BinNode with the value 1 and without children")]
		public void ConstructorTest1()
		{
			this.binaryTree = new BinNode<int>(1);
			Assert.AreEqual(this.binaryTree.GetValue(), 1);
			Assert.False(this.binaryTree.HasLeft() || this.binaryTree.HasRight());

			Assert.IsNull(this.binaryTree.GetRight());
			Assert.IsNull(this.binaryTree.GetLeft());
		}

		[Test, Description("Should construct a BinNode withh the value 1 and two children")]
		public void ConstructorTest2()
		{
			var left = new BinNode<int>(0);
			var right = new BinNode<int>(2);

			this.binaryTree = new BinNode<int>(left, 1, right);

			Assert.AreEqual(this.binaryTree.GetValue(), 1);
			Assert.True(this.binaryTree.HasLeft() && this.binaryTree.HasRight());

			Assert.AreEqual(this.binaryTree.GetLeft(), left);
			Assert.AreEqual(this.binaryTree.GetRight(), right);
		}

		[Test]
		public void GetSetValueTest()
		{
			Assert.AreEqual(this.binaryTree.GetValue(), 1);

			this.binaryTree.SetValue(2);
			Assert.AreEqual(this.binaryTree.GetValue(), 2);
		}

		[Test]
		public void GetSetChildrenTest()
		{
			Assert.Null(this.binaryTree.GetLeft());
			Assert.Null(this.binaryTree.GetRight());

			// Setting the right and testing it
			var right = new BinNode<int>(1);
			this.binaryTree.SetRight(right);

			Assert.AreEqual(this.binaryTree.GetRight(), right);

			// Testing the left and testing it
			var left = new BinNode<int>(3);
			this.binaryTree.SetLeft(left);

			Assert.AreEqual(this.binaryTree.GetLeft(), left);

			// Testing the values of the children
			Assert.AreEqual(this.binaryTree.GetLeft().GetValue(), 3);
			Assert.AreEqual(this.binaryTree.GetRight().GetValue(), 1);
		}

		[Test, Description("Should return False because there are no children")]
		public void HasChildrenTest1()
		{
			// Testing that the binary tree has no left child nor right
			Assert.False(this.binaryTree.HasLeft() || this.binaryTree.HasRight());
		}

		[Test, Description("Should return True for HasLeft and False for HasRight after setting the left child")]
		public void HasChildrenTest2()
		{
			this.binaryTree.SetLeft(new BinNode<int>(2));

			Assert.True(this.binaryTree.HasLeft());
			Assert.False(this.binaryTree.HasRight());
		}

		[Test, Description("Should return False for HasLeft and True for HasRight after setting the left child")]
		public void HasChildrenTest3()
		{
			this.binaryTree.SetRight(new BinNode<int>(2));

			Assert.True(this.binaryTree.HasRight());
			Assert.False(this.binaryTree.HasLeft());
		}

		[Test, Description("Should return True when there are children")]
		public void HasChildrenTest4()
		{
			this.binaryTree.SetLeft(new BinNode<int>(1));
			this.binaryTree.SetRight(new BinNode<int>(2));

			Assert.True(this.binaryTree.HasLeft() && this.binaryTree.HasRight());
		}
	}
}
