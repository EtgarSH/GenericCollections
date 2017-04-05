using System;

namespace EduLib
{
	public class Node<T>
	{
		private T value;
		private Node<T> next;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:EduLib.Node`1"/> class.
		/// </summary>
		/// <param name="x">The value.</param>
		public Node(T x)
		{
			this.value = x;
			this.next = null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:EduLib.Node`1"/> class.
		/// </summary>
		/// <param name="x">The value.</param>
		/// <param name="next">The next Node.</param>
		public Node(T x, Node<T> next)
		{
			this.value = x;
			this.next = next;
		}

		/// <summary>
		/// Gets the value of the node.
		/// </summary>
		/// <returns>The value.</returns>
		public T GetValue()
		{
			return this.value;
		}

		/// <summary>
		/// Gets the next node.
		/// </summary>
		/// <returns>The next node.</returns>
		public Node<T> GetNext()
		{
			return this.next;
		}

		/// <summary>
		/// Check wether a next node is connected to the node.
		/// </summary>
		/// <returns><c>true</c>, if next node is available, <c>false</c> otherwise.</returns>
		public bool HasNext()
		{
			return this.next != null;
		}

		/// <summary>
		/// Sets the value.
		/// </summary>
		/// <param name="x">The value.</param>
		public void SetValue(T x)
		{
			this.value = x;
		}

		/// <summary>
		/// Sets the next node.
		/// </summary>
		/// <param name="next">Next node.</param>
		public void SetNext(Node<T> next)
		{
			this.next = next;
		}

		public override string ToString()
		{
			return string.Format("Value: {0}", this.value);
		}
	}
}
