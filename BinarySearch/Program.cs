
namespace BinarySearch
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            var evenNumbers = new List<int> { 2, 4, 6, 8, 10};
            Console.WriteLine("Position: "+BinarySearch(evenNumbers, 2)); 
        }

        private static int? BinarySearch(IList<int> myList, int item)
        {
            var low = 0;
            var high = myList.Count() - 1;

            Console.WriteLine("this is low: " + low + "\nthis is high: "+ high);

            int count = 0; // for counting the number of attempts
            while (low <= high)
            {
                ++count;
                Console.WriteLine("This is "+(count)+" attempt");
                var mid = (low + high) / 2;
                Console.WriteLine("this is mid: " + mid);

                var guess = myList[mid];
                Console.WriteLine("this is guess: " + guess);

                if (guess == item) return mid; 
               
                if (guess > item)
                {
                    high = mid - 1;
                }
                else 
                {
                    low = mid + 1;
                }

                //count++;
            }
            return null;
        }
    }
}