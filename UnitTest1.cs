//https://katalyst.codurance.com/roman-numerals
namespace RomanNumerals;

public class UnitTest1
{
   [Fact]
   public void ShouldBeIV()
   {
      Assert.True(new Roman().Convert(4) == "IV");
   }

   [Fact]
   public void ShouldBeIX()
   {
      Assert.True(new Roman().Convert(9) == "IX");
   }

   [Fact]
   public void ShouldBeXXIX()
   {
      Assert.True(new Roman().Convert(29) == "XXIX");
   }

   [Fact]
   public void ShouldBeLXXX()
   {
      Assert.True(new Roman().Convert(80) == "LXXX");
   }

   [Fact]
   public void ShouldBeCCXCIV()
   {
      Assert.True(new Roman().Convert(294) == "CCXCIV");
   }

   [Fact]
   public void ShouldBeDCV()
   {
      Assert.True(new Roman().Convert(605) == "DCV");
   }

   [Fact]
   public void ShouldBeMMXIX()
   {
      Assert.True(new Roman().Convert(2019) == "MMXIX");
   }

   [Fact]
   public void ShouldBeMMMDCCXXIV()
   {
      Assert.True(new Roman().Convert(3724) == "MMMDCCXXIV");
   }

   [Fact]
   public void ShouldBeMCCCLXXIV()
   {
      Assert.True(new Roman().Convert(1374) == "MCCCLXXIV");
   }

   [Fact]
   public void ShouldBeXVII()
   {
      Assert.True(new Roman().Convert(17) == "XVII");
   }

   [Fact]
   public void ShouldBeMMMMMDCCLXII()
   {
      Assert.True(new Roman().Convert(5762) == "MMMMMDCCLXII");
   }

   [Fact]
   public void ShouldBeMCM()
   {
      Assert.True(new Roman().Convert(1900) == "MCM");
   }

   [Fact]
   public void ShouldBeMMXX()
   {
      Assert.True(new Roman().Convert(2020) == "MMXX");
   }
}

public class Roman
{

   public string Convert(int amount)
   {
      string roman = new string('M', amount / 1000)  //Millions (Can only return char 'M')
         + ConvertTo((amount % 1000) / 100, 'M', 'D', 'C') //Hundreds
         + ConvertTo((amount % 100) / 10, 'C', 'L', 'X') //Dozens
         + ConvertTo(amount % 10, 'X', 'V', 'I'); //Less than 10

      return roman;
   }
   
   private string ConvertTo(int amount, char next, char middle, char unit)
   {
      if (amount >= 9)
      {
         return unit.ToString() + next.ToString();
      }
      else if (amount >= 5)
      {
         return middle.ToString() + ConvertTo(amount - 5, next, middle, unit); //Recursive call to get the rest
      }
      else if (amount >= 4)
      {
         return unit.ToString() + middle.ToString();
      }
      else if (amount >= 1)
      {
         return new string(unit, amount);
      }

      return "";
   }


   /*History
   1) I Wrote a simple test, and a Method throwing an excpetion so the test fails
   2) I changed the method so the return passes the test, but with a static result (fake)
   3) I wrote more 2 tests and started refactoring the method
   4) The method passes simple numbers like 10 or 25
   5) I wrote more complexes tests and started refactoring as the tests failed (I started to understand the logic of Roman Numbers)
   6) I Wrote a method with lots of If and Else, some tests passed
   7) I Wrote a method to convert each possibility of digits, I mean, Thousands, Hundreds, Dozens and only numbers
   8) Tests passed, so I wrote more tests
   9) Tests passed so my algorithm was right
   10) I started refactoring to simplify the algorithm
   11) I wrote a generic method to replace others 3 specific methods
   12) Tested again, every things works
   13) Analysed, I think it's possible to improve the speed, because small numbers are tested as thousand and hundreds


   */




}