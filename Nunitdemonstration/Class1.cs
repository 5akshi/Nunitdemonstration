namespace Nunitdemonstration
{
    public class Class1
    {
        public static class Triangle
        {
            // PROG8041-Sakshi Desai- 8995937 -LAB 2
            public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
            {
                string result;
                if ((firstAngle + secondAngle + thirdAngle) == 180)
                {
                    result = "The triangle is valid.";
                }
                else
                {
                    result = "The triangle is NOT valid.";
                }
                return result;
            }
        }
    }
}
