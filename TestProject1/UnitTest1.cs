using System.Collections.Generic;

namespace TestProject1
{
    
    public class UnitTest1
    {
        
        public string ToString(string[] arr)
        {
            string ausgabe = "";
            for(int i = 0; i <= arr.Length-1; i++) 
            {
                ausgabe += arr[i];
                if (i == arr.Length - 1) ausgabe += ""; else ausgabe += " ";
   
            }
            return ausgabe;
        }

        [Fact]
        public void Test1_ArrayToString()
        {
            //Arrange:
            string eingabe = "All THOSE moments wILL Be loSt in TimE, like tEArs in rain.";
            string erwartetesErgebnis = "All THOSE Moments WILL Be LoSt In TimE, Like TEArs In Rain.";


            ////Act:
            string[] arr = StringManipulation.StringGross(eingabe);
            //StringManipulation.Ausgabe(StringManipulation.StringGross(eingabe));

            //Assert:
            Assert.Equal(ToString(arr), erwartetesErgebnis);
        }
        [Fact]
        public void Test2_PrüfeEinträgeAufLeerzeichen()
        {
            //Arrange:
           string eingabe = "All THOSE moments wILL Be loSt in TimE, like tEArs in rain.";


            ////Act:
            string[] arr = StringManipulation.StringGross(eingabe);
            //StringManipulation.Ausgabe(StringManipulation.StringGross(eingabe));

            //Assert:    
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Assert.False(arr[i].Contains(" "));
            }
        }
        [Fact]
        public void Test3GrossbuchstabeAmAnfang()
        {
            //Arrange:
           string eingabe = "All THOSE moments wILL Be loSt in TimE, like tEArs in rain.";

            ////Act:
            string[] arr = StringManipulation.StringGross(eingabe);
            //StringManipulation.Ausgabe(StringManipulation.StringGross(eingabe));

            //Assert:
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Assert.Matches(@"^[A-Z].*", arr[i]);
            }
        }
        [Fact]
        public void Test4NotNullInArr()
        {
            string eingabe = "All THOSE moments wILL Be loSt in TimE, like tEArs in rain.";

            string[] arr = StringManipulation.StringGross(eingabe);

            Assert.False(arr.Contains(null));

        }
    }
}