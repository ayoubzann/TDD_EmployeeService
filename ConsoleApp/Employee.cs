namespace ConsoleApp
{
	public class Employee
	{
        public int Age { get; set; }

        public bool IsSeniorCitizen()
        {
            if (Age >= 60)
            { 
                return true;
            }
            else
            {
                return false;
            }

        }


	}
}
