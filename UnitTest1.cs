namespace RomanNumerals;
//https://katalyst.codurance.com/roman-numerals
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
      var digits = amount.ToString().Length;
      string roman = ConvertThousands(amount) + ConvertHundreds(amount % 1000) + ConvertDozens(amount % 100) + ConvertNumber(amount % 10);

      return roman;
   }

   private string ConvertThousands(int amount)
   {
      int romanTimes = amount / 1000;
      return new string('M', romanTimes);
   }

   private string ConvertHundreds(int amount)
   {
      if (amount >= 900)
      {
         return "CM";
      }
      else if (amount >= 500)
      {
         return "D" + ConvertHundreds(amount - 500);
      }
      else if (amount >= 400)
      {
         return "CD";
      }
      else if (amount >= 100)
      {
         int romanTimes = amount / 100;
         return new string('C', romanTimes);
      }

      return "";
   }

   private string ConvertDozens(int amount)
   {
      if (amount >= 90)
      {
         return "XC";
      }
      else if (amount >= 50)
      {
         return "L" + ConvertDozens(amount - 50);
      }
      else if (amount >= 40)
      {
         return "XL";
      }
      else if (amount >= 10)
      {
         int romanTimes = amount / 10;
         return new string('X', romanTimes);
      }

      return "";

   }

   private string ConvertNumber(int amount)
   {
      if (amount >= 9)
      {
         return "IX";
      }
      else if (amount >= 5)
      {
         return "V" + ConvertNumber(amount - 5);
      }
      else if (amount >= 4)
      {
         return "IV";
      }
      else if (amount > 1)
      {
         return new string('I', amount);
      }

      return "";

   }

   private string ConvertTo(int amount, char next, char middle, char unit)
   {
      if (amount >= 9)
      {
         return unit.ToString() + next.ToString();
      }
      else if (amount >= 5)
      {
         return middle.ToString() + ConvertTo(amount - 5, next, middle, unit);
      }
      else if (amount >= 4)
      {
         return unit.ToString() + middle.ToString();
      }
      else if (amount > 1)
      {
         return new string(unit, amount);
      }

      return "";


   }




}