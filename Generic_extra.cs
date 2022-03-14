namespace Generic
{
    public class Generic
    {

        // T is type generic
        public static void Swap<T>(ref T x, ref T y)
        {
            // create var t save value of x
            T t;
            t = x;
            x = y;
            y = t;

        }
    }
}