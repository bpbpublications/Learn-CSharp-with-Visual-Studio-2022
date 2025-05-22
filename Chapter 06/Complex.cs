public class Complex
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public Complex(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex x, Complex y)
    {
        return new Complex(x.Real + y.Real, x.Imaginary + y.Imaginary);
    }
}
