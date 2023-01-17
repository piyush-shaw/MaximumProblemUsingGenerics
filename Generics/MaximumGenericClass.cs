using System;

namespace Generics
{
    //Refactor to create generic class to take in 3 variables of generic type

    public class MaximumGenericClass<T> where T : IComparable
	{
        //these are generic variables
		public T firstValue, secondValue, thirdValue;

		public MaximumGenericClass(T firstValue,T secondValue,T thirdValue)
		{
			this.firstValue = firstValue;
			this.secondValue = secondValue;
			this.thirdValue = thirdValue;
		}
        //Refactor all 3 method in to one generic method and finding maximum value
        public static T MaxValue(T firstValue, T secondValue, T thirdValue) 
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;
        }
    }
}

