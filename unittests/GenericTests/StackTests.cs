using System;
using EduLib;
using NUnit.Framework;

namespace unittests
{
	[TestFixture]
	public class StackTests
	{
		private Stack<int> stack;

		[SetUp]
		public void setup()
		{
			this.stack = new Stack<int>();
		}

		[Test]
		public void IsEmptyTest()
		{
			Assert.True(this.stack.IsEmpty());

			this.stack.Push(5);
			Assert.False(this.stack.IsEmpty());

		}

		[Test]
		public void PushTest()
		{
			Assert.Throws<IndexOutOfRangeException>(() => this.stack.Top());

			this.stack.Push(5);
			this.stack.Push(8);

			Assert.AreEqual(this.stack.Top(), 8);
		}

		[Test]
		public void PopTest()
		{
			Assert.Throws<IndexOutOfRangeException>(() => this.stack.Pop());

			this.stack.Push(5);
			int removedItem = this.stack.Pop();

			Assert.AreEqual(removedItem, 5);
			Assert.True(this.stack.IsEmpty());
		}

		[Test]
		public void ResizingTest()
		{
			for (int i = 0; i <= Stack<int>.defaultLength + 10; i++)
			{
				this.stack.Push(i);
			}
			Assert.AreEqual(this.stack.Top(), Stack<int>.defaultLength + 10);

			for (int i = 0; i <= Stack<int>.defaultLength + 10; i++)
			{
				this.stack.Pop();
			}
			Assert.True(this.stack.IsEmpty());

			this.stack.Push(5);
			Assert.AreEqual(this.stack.Top(), 5);
		}
	}
}
