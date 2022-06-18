namespace RomanNumerals;
//https://katalyst.codurance.com/roman-numerals
public class UnitTest1
{
    [Fact]
    public void ShouldBeIV()
    {      
      Assert.True(new Roman().Convert(4)=="IV");
    }

    [Fact]
    public void ShouldBeIX()
    {      
      Assert.True(new Roman().Convert(9)=="IX");
    }

        [Fact]
    public void ShouldBeXXIX()
    {      
      Assert.True(new Roman().Convert(29)=="XXIX");
    }

    [Fact]
    public void ShouldBeLXXX()
    {      
      Assert.True(new Roman().Convert(80)=="LXXX");
    }

    [Fact]
    public void ShouldBeCCXCIV()
    {      
      Assert.True(new Roman().Convert(294)=="CCXCIV");
    }

    [Fact]
    public void ShouldBeMMXIX()
    {      
      Assert.True(new Roman().Convert(2019)=="MMXIX");
    }
}

public class Roman{

   public string Convert(int amount)
   {
      var digits = amount.ToString().Length;
      string roman = "";

      if (amount>1000)
         roman+="M";      
      else if (amount>900)
         roman+="CM";


      if (amount==4)
         return "IV";
      return amount.ToString();

   }
}