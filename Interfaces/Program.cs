namespace Interfaces
{
    internal class Program
    {
        public interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);
        }

        public interface IOutput2
        {
            void ShowEven();
            void ShowOdd();
        }

        public interface ICalc2
        {
            int CountDistinct();
            int EqualToValue(int valueToCompare);
        }

        public class Array : ICalc, IOutput2
        {
            private int[] arr;
            public Array(int[] arr)
            {
                this.arr = arr;
            }

            public int Less(int value)
            {
                int count = 0;
                foreach (var item in arr)
                {
                    if (item < value)
                    {
                        count++;
                    }
                }
                return count;
            }
            public int Greater(int value)
            {
                int count = 0;
                foreach (var item in arr)
                {
                    if (item > value)
                    {
                        count++;
                    }
                }
                return count;
            }

            public void ShowEven()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            public void ShowOdd()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                Console.WriteLine();
            }

            public int CountDistinct()
            {
                return arr.Distinct().Count();
            }
            public int EqualToValue(int valueToCompare)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        static void Main(string[] args)
        {
            ////task 1
            //int[] numbers = { 1, 5, 8, 12, 3, 7, 9 };
            //Array array = new Array(numbers);

            //int valueToCompare = 6;
            //Console.WriteLine($"Less: {array.Less(valueToCompare)}");
            //Console.WriteLine($"Greater: {array.Greater(valueToCompare)}");
            ////task 2
            //int[] numbers = { 1, 5, 8, 12, 3, 7, 9 };
            //Array array = new Array(numbers);

            //array.ShowEven();
            //array.ShowOdd();
            ////task 3
            //int[] numbers = { 1, 5, 8, 12, 3, 7, 9, 5, 3, 5 };
            //Array array = new Array(numbers);

            //Console.WriteLine($"Count distinct: {array.CountDistinct()}");
            //Console.WriteLine($"Equal to 5: {array.EqualToValue(5)}");
        }
    }
}
