using System;

namespace EduLib
{
	public class Stack<T>
	{
		public static int defaultLength = 15;

		private T[] array;
		private int stackIndex;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:EduLib.Stack`1"/> class.
		/// </summary>
		public Stack()
		{
			this.array = new T[defaultLength];
			this.stackIndex = -1;
		}

		/// <summary>
		/// Check wether the stack is empty.
		/// </summary>
		/// <returns><c>true</c>, if empty, <c>false</c> otherwise.</returns>
		public bool IsEmpty()
		{
			return this.stackIndex < 0;
		}

		/// <summary>
		/// Gets the object on the top of the stack.
		/// </summary>
		/// <returns>The top.</returns>
		public T Top()
		{
			if (this.IsEmpty())
			{
				throw new IndexOutOfRangeException();
			}
			return this.array[this.stackIndex];
		}

		/// <summary>
		/// Push the specified x to the stack.
		/// </summary>
		/// <param name="x">The object to push.</param>
		public void Push(T x)
		{
			// If there is a need to resize the array, resizing it.
			if (this.stackIndex + 1 >= this.array.Length)
			{
				Array.Resize(ref this.array, this.array.Length + 10);
			}
			this.stackIndex++;
			this.array[this.stackIndex] = x;
		}

		/// <summary>
		/// Pop (Remove) the top object on the stack.
		/// Throws an exception if the stack is empty!
		/// </summary>
		/// <returns>The removed item.</returns>
		public T Pop()
		{
			var toReturn = this.Top();
			this.stackIndex--;
			return toReturn;
		}
	}
}
