using System;
using System.Collections.Generic;

namespace GenericTeach
{

	/// <summary>
	/// a class demo for stack push and pop data
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class MyStack<T>
	{
		//prepare array type data
		private T[] stack;

		// initial start position of elements
		private int stackPoint;

		// initial the size of the stack
		private int size;

		// constructor
		public MyStack(int size)
		{
			this.size = size;
			this.stack = new T[size];
			this.stackPoint = -1; // stack starts at 0, so the first element index would be -1+1 = 0
		}

		// put data into stack
		public void Push(T data)
		{
			if (stackPoint >= size) Console.WriteLine("Stack is full!");
			else
			{
				stackPoint++;
				
				this.stack[stackPoint] = data;
			}
		}
		/// <summary>
		/// take element out from stack
		/// </summary>
		/// <returns></returns>

		public T Pop()
		{
			T data = this.stack[stackPoint];
			this.stack[stackPoint] = default(T); //default keyword is for directly give value for generic type.
			stackPoint--;
			return data;
        }
    }

	#region Generic type 'default' keyword
	public class MyGenericClass<T1, T2> 
	{
		private T1 data1;
		private T2 data2;
		private T2 data3;

		public MyGenericClass()
        {
			//data1 = new T1(); //error CS0304: Cannot create an instance of the variable type 'T1' because it does not have the new() constraint
			//data2 = null; // error CS0403: Cannot convert null to type parameter 'T2' because it could be a non-nullable value type. Consider using 'default(T2)' instead.
			data3 = default(T2);
        }
	}
    #endregion

    #region Generic type constraint and dynamic type
	public class MyGenericClassConstraint<T1, T2, T3>
		where T1: struct // T1 have to be a value type.
		where T2: class // T2 have to be a reference type.
		where T3:new() // T3 type must have a no argument constrctor, and this constraint must be put on the end of line

		//other constraint: base , interface ...
    {
        public List<T2> ProductList { get; set; }
        public T3 Publisher { get; set; }

		public MyGenericClassConstraint()
        {
			this.ProductList = new List<T2>();
			Publisher = new T3(); //Cannot create an instance of the variable type 'type' because it does not have the new() constraint
		}


		// for certain type it need to be dynamic to be valid
		public T2 BuyCourse(T1 position)
        {
			//return this.ProductList[position]; //error,position need to be int type not generic. use dynamic instead
			dynamic index = position;
			return this.ProductList[index];
        }


    }


		public class Course
        {
			public string CourseName { get; set; }
            public int PeriodLasts { get; set; }
        }

		public class Teacher
        {
			public Teacher() { }
			public string Name { get; set; }
			public	int CourseCount { get; set; }
        }


    #endregion

}
