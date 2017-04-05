using System;
using EduLib;
using NUnit.Framework;

namespace unittests
{
	[TestFixture]
	public class QueueTests
	{
		private Queue<int> queue;

		[SetUp]
		public void Setup()
		{
			this.queue = new Queue<int>();
		}

		[Test]
		public void IsEmptyTest()
		{
			Assert.True(this.queue.IsEmpty());

			this.queue.Insert(5);
			Assert.False(this.queue.IsEmpty());
		}

		[Test]
		public void HeadTest()
		{
			Assert.Throws<IndexOutOfRangeException>(() => this.queue.Head());

			this.queue.Insert(5);
			this.queue.Insert(8);

			Assert.AreEqual(this.queue.Head(), 5);
		}

		[Test]
		public void InsertTest()
		{
			this.queue.Insert(5);
			Assert.AreEqual(this.queue.Head(), 5);
		}

		[Test]
		public void RemoveTest()
		{
			Assert.Throws<IndexOutOfRangeException>(() => this.queue.Remove());
			this.queue.Insert(1);
			this.queue.Insert(2);

			var first = this.queue.Remove();
			var second = this.queue.Remove();

			Assert.AreEqual(first, 1);
			Assert.AreEqual(second, 2);

			Assert.True(this.queue.IsEmpty());
		}

		[Test]
		public void ResizingTest()
		{
			for (int i = 0; i < Queue<int>.defaultLength + 10; i++)
			{
				this.queue.Insert(i);
			}
			// Check if the first is still the first after the resizing
			Assert.AreEqual(this.queue.Head(), 0);

			for (int i = 0; i < Queue<int>.defaultLength + 10; i++)
			{
				// Check if the resize works without harming the sort
				Assert.AreEqual(this.queue.Remove(), i);
			}
		}
	}
}
