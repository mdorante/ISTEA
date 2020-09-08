namespace Functions.Lib
{
    public class Numbers
    {
        public static int Greatest(int num1, int num2)
        {
            int maximo = num1;
            if (num2 > num1)
            {
                maximo = num2;
            }
            return maximo;
        }
    }
}
