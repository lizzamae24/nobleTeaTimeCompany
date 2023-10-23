public class Program
{
    public static void Main(string[] args)
    {
        const int shippingFee = 15;

        Console.Write("Enter no. of pound: ");
        int noOfPound = int.Parse(Console.ReadLine());

        Console.Write("Enter price per pound: ");
        double pricePerPound = double.Parse(Console.ReadLine());

        Console.Write("Add shipping fee (Y/N): ");
        char shippingInformation = Console.ReadLine()[0];

        double totalAmount = noOfPound * pricePerPound;

        if (shippingInformation == 'Y') ;
        {
            totalAmount = totalAmount + shippingFee;
        }

        Console.WriteLine("Total amount: {0:F2}", totalAmount);
    }
}