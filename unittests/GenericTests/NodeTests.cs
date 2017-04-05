using System;
using EduLib;
using NUnit.Framework;

namespace unittests
{
	[TestFixture]
	public class NodeTests
	{
		private Node<int> node;

		[SetUp]
		public void Setup()
		{
			this.node = new Node<int>(10);
		}

		[Test]
		public void GetValueTest()
		{
			Assert.True(this.node.GetValue() == 10);
		}

		[Test]
		public void SetValueTest()
		{
			this.node.SetValue(15);
			Assert.True(this.node.GetValue() == 15);
		}

		[Test]
		public void GetSetNextTest()
		{
			Assert.True(this.node.GetNext() == null);

			Node<int> next = new Node<int>(5);
			this.node.SetNext(next);
			Assert.AreSame(next, this.node.GetNext());
		}

		[Test]
		public void HasNextTest()
		{
			Assert.False(this.node.HasNext());

			this.node.SetNext(new Node<int>(5));
			Assert.True(this.node.HasNext());
		}
	}
}
