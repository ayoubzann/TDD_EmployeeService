using NUnit.Framework;
using ConsoleApp;

namespace NUnitTestProject
{
	public class Tests
	{
		[Test]
		public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizenAsTrue()
		{
			Employee emp = new Employee();
			emp.Age = 60;

			bool result = emp.IsSeniorCitizen();

			Assert.That(result == true);
		}

		[TestCase(60)]
		[TestCase(80)]
		[TestCase(90)]
		public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizenAsTrue(int age)
		{
			// To students: An alternative way to write the commented out setup below is
			//              "object initializer". This can be used when we want to set a 
			//              property asap, but we can't set it through a constructor.
			// Employee emp = new Employee();
			// emp.Age = age;
			Employee emp = new Employee { Age = age };

			bool result = emp.IsSeniorCitizen();

			Assert.That(result == true);
		}

		[TestCase(29, false)]
		[TestCase(0, false)]
		[TestCase(60, true)]
		[TestCase(80, true)]
		[TestCase(90, true)]
		public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizenAsTrue(int age, bool expected)
		{
			Employee emp = new Employee();
			emp.Age = age;

			bool actual = emp.IsSeniorCitizen();

			Assert.AreEqual(expected, actual);
		}
	}
}