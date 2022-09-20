using System;

/// <summary>Class for creating and using Queues.</summary>
public class Queue<T>{
	/// <summary>Returns the type for the queue.</summary>
	public Type CheckType(){
		return typeof(T);
	}
	/// <summary>Node class for members of the queue.</summary>
	public class Node{
		/// <summary>Value contained in the node.</summary>
		public T value;
		/// <summary>Next node in the queue.</summary>
		public Node next = null;
		/// <summary>Constructor for a node.</summary>
		public Node(T value){
			this.value = value;
		}
	}
	Node head = null;
	Node tail = null;
	int count = 0;
	/// <summary>Adds item to end of Queue</summary>
	public void Enqueue(T value){
		Node n = new Node(value);
		if (this.head == null)
			this.head = n;
		else
			this.tail.next = n;
		this.tail = n;
		count++;
	}
	/// <summary>Retruns the number of items in Queue</summary>
	public int Count() => this.count;
}
