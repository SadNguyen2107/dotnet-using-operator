namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float height, width;
            bool isSuccess = true;

        askWidth:
            Console.Write("Enter Width: ");
            // Try To Parse Float Value
            isSuccess = Single.TryParse(Console.ReadLine(), out width);
            if (!isSuccess || width < 0)
            {
                Console.WriteLine("Width Cannot Below 0 Or Character");
                goto askWidth;
            }

        askHeight:
            Console.Write("Enter height: ");
            // Try To Parse Float Value
            isSuccess = Single.TryParse(Console.ReadLine(), out height);
            if (!isSuccess || height < 0)
            {
                Console.WriteLine("Height Cannot Below 0 Or Character");
                goto askHeight;
            }

            // Calculate Area
            float area = width * height;
            Console.WriteLine($"Area is: {area}");
        }
    }
}