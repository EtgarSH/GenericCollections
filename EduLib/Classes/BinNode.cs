using System;

namespace EduLib
{
	public class BinNode<T>
	{
		private T value;

		private BinNode<T> left;
		private BinNode<T> right;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:EduLib.BinNode`1"/> class.
		/// </summary>
		/// <param name="x">The value.</param>
		public BinNode(T x)
		{
			this.value = x;
			this.left = null;
			this.right = null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:EduLib.BinNode`1"/> class.
		/// </summary>
		/// <param name="left">Left BinNode.</param>
		/// <param name="x">The value.</param>
		/// <param name="right">Right BinNode.</param>
		public BinNode(BinNode<T> left, T x, BinNode<T> right)
		{
			this.value = x;
			this.left = left;
			this.right = right;
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <returns>The value.</returns>
		public T GetValue()
		{
			return this.value;
		}

		/// <summary>
		/// Gets the left.
		/// </summary>
		/// <returns>The left.</returns>
		public BinNode<T> GetLeft()
		{
			return this.left;
		}

		/// <summary>
		/// Gets the right.
		/// </summary>
		/// <returns>The right.</returns>
		public BinNode<T> GetRight()
		{
			return this.right;
		}

		/// <summary>
		/// Check if there is a left BinNode.
		/// </summary>
		/// <returns><c>true</c>, if there is a left BinNode, <c>false</c> otherwise.</returns>
		public bool HasLeft()
		{
			return this.left != null;
		}

		/// <summary>
		/// Check if there is a right BinNode.
		/// </summary>
		/// <returns><c>true</c>, if there is a right BinNode, <c>false</c> otherwise.</returns>
		public bool HasRight()
		{
			return this.right != null;
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
		/// Sets the left.
		/// </summary>
		/// <param name="left">Left.</param>
		public void SetLeft(BinNode<T> left)
		{
			this.left = left;
		}

		/// <summary>
		/// Sets the right.
		/// </summary>
		/// <param name="right">Right.</param>
		public void SetRight(BinNode<T> right)
		{
			this.right = right;
		}
	}
}
