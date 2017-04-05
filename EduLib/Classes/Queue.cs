using System;

namespace EduLib
{
	public class Queue<T>
	{
		public static int defaultLength = 15;
	
		private T[] array;
		private int firstIndex;
		private int lastIndex;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:EduLib.Queue`1"/> class.
		/// </summary>
		public Queue()
		{
			this.array = new T[defaultLength];
			this.firstIndex = 0;
			this.lastIndex = 0;
		}

		/// <summary>
		/// Checks wether the queue is empty.
		/// </summary>
		/// <returns><c>true</c>, if empty, <c>false</c> otherwise.</returns>
		public bool IsEmpty()
		{
			return this.firstIndex == this.lastIndex;
		}

		/// <summary>
		/// Return the first item in the queue.
		/// </summary>
		/// <returns>The head.</returns>
		public T Head()
		{
			if (this.IsEmpty())
			{
				throw new IndexOutOfRangeException();
			}
			return this.array[this.firstIndex];
		}

		/// <summary>
		/// Insert the specified x.
		/// </summary>
		/// <param name="x">The x item.</param>
		public void Insert(T x)
		{
			// If there is a need to resize the array, resizing it.
			if (this.lastIndex + 1 >= this.array.Length)
			{
				Array.Resize(ref this.array, this.array.Length + 10);
			}
			this.array[this.lastIndex] = x;
			this.lastIndex++;
		}

		/// <summary>
		/// Removes the first in the queue and get it.
		/// </summary>
		/// <returns>The first in the queue (head).</returns>
		public T Remove()
		{
			var toReturn = this.Head();
			firstIndex++;
			return toReturn;
		}
	}
}
