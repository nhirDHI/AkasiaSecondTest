// See https://aka.ms/new-console-template for more information

public class Program
{
    public static int AddNumbers(int a, int b)
    {
        int result = a + b;
        return result;
    }

    public static int DivideNumbers(int a, int b)
    {
        try
        {
            // Pembagian dengan nol
            if (b == 0)
                throw new Exception("Pembagian 0 dilarang.");

            return a / b;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error Pembagian: " + ex.Message);
            return 0; // return default jika terjadi kesalahan
        }
    }

    public static void Main(string[] args)
    {
        #region Answer 1
        //int sum = AddNumbers(5);
        //Console.WriteLine("Hasil penjumlahan: " + sum);

        // Kode di atas akan menghasilkan error saat run dikarenakan metode AddNumbers membutuhkan dua parameter(int a dan int b),
        // tetapi saat memanggilnya hanya satu parameter yang diberikan(AddNumbers(5))
        #endregion


        #region Answer 2
        try
        {
            // Memperbaiki pemanggilan fungsi AddNumbers
            int sum = AddNumbers(5, 10);
            Console.WriteLine("Hasil penjumlahan: " + sum);

            // Contoh pembagian
            int divisionResult = DivideNumbers(10, 0); // Pembagian dengan nol
            Console.WriteLine("Hasil pembagian: " + divisionResult);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        #endregion
    }
}

