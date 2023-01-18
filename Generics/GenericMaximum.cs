﻿using System;
namespace Generics
{
	public class GenericMaximum<T> where T : IComparable
	{
		//Generic array
		public T[] value;
		public GenericMaximum(T[] value)
		{
			this.value = value;
		}
		//sorting the value in ascending 
		public T[] Sort(T[] values)
		{
			Array.Sort(values);
			return values;
		}
		//UC4 generic method to find max value
		public T MaxValue(params T[] values)
		{
			var sorted_values = Sort(value);
			return sorted_values[^1];
		}
	}
}

