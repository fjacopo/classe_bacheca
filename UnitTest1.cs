using Classe_vacanza;
namespace TestManca
{
    public class UnitTest1
    {
        Vacanza v;
        [Fact]
        public void Test1()
        {
            v = new Vacanza("a123",10,"bergamo",2,true,5) ;
            v.ModifyData(12,"bergamo",2,true,7);
            Assert.True(v.Price == 12);

            
            
            
        }
        [Fact]
        public void Test2() {
            v = new Vacanza("b456",20,"milano",4,true,10);
            v.Purchase(1);
            Assert.True(v.NumberOfPeople == 1);

        }
        [Fact]
        public void Test3()
        {
            v = new Vacanza("c789",40,"roma",8,false,20);
            v.ChooseFlight(true, 10);     
            Assert.True(v.FlightCost == 10);

        }
        [Fact]
        public void Test4()
        {
            v = new Vacanza("d1234", 80, "napoli", 16, true, 40);
            v.ChooseNumberOfDays(15);
            Assert.True(v.NumberOfDays == 15);
        }
        [Fact]
        public void Test5()
        {
            v = new Vacanza("a123", 10, "bergamo", 2, true, 5);
            v.ModifyData(12, "bergamo", 2, true, 7);
            Assert.False(v.Price == 10);
        }
        [Fact]
        
        public void Test6()
        {
            v = new Vacanza("b456", 20, "milano", 4, true, 10);
            v.Purchase(1);
            Assert.False(v.NumberOfPeople == 2);
        }
        [Fact]
        public void Test7()
        {

            v = new Vacanza("a123", 10, "bergamo", 2, true, 5);
            Assert.Throws<Exception>(() => v.ModifyData(0, "bergamo", 2, true, 7));
            
        }
        [Fact]
        public void Test8()
        {
            v = new Vacanza("b456", 20, "milano", 4, true, 10);
            Assert.Throws<Exception>(() => v.Purchase(0));
           
        }
        [Fact]
        public void Test9()
        {
            v = new Vacanza("c789", 40, "roma", 8, false, 20);
            v.ChooseFlight(true, 10);
            Assert.False(v.FlightCost == 20);
        }
        [Fact]
        public void Test10()
        {
            v = new Vacanza("c789", 40, "roma", 8, false, 20);
            Assert.Throws<Exception>(() => v.ChooseFlight(true,0 ));
         
        }
        [Fact]
        public void Test11()
        {
            v = new Vacanza("d1234", 80, "napoli", 16, true, 40);
            v.ChooseNumberOfDays(15);
            Assert.False(v.NumberOfDays == 16);
        }
        [Fact]
        public void Test12()
        {
            v = new Vacanza("d1234", 80, "napoli", 16, true, 40);
            Assert.Throws<Exception>(() => v.ChooseNumberOfDays(0));
            
        }
        [Fact]
        public void Test13()
        {
            v = new Vacanza("e5678", 160, "catania", 32, true, 80);
            v.ApplyDiscount(10);
            Assert.True(v.Price==144);
        }
        [Fact]
        public void Test14()
        {
            v = new Vacanza("e5678", 160, "catania", 32, true, 80);
            v.ApplyDiscount(10);
            Assert.False(v.Price == 160);
        }
        [Fact]
        public void Test15()
        {
            v = new Vacanza("e5678", 160, "catania", 32, true, 80);
            Assert.Throws<Exception>(() => v.ApplyDiscount(0));
            
        }
        [Fact]
        public void Test16()
        {
            v = new Vacanza("f12", 200, "catania", 40, true, 100);
            Vacanza p = new Vacanza("ft12", 100, "catania", 40, true, 100); //errore,è vero che p è più conveniente, nella classe ha invertito maggiore e minore
            
            Assert.True(v.ComparePackages(p)==p);
        }
        [Fact]
        public void Test17()
        {
            v = new Vacanza("f12", 200, "catania", 40, true, 100);
            Vacanza p = new Vacanza("t12", 100, "catania", 40, true, 100); //errore, è vero che v è meno conveniente, nella classe ha invertito > e <
            
            Assert.False(v.ComparePackages(p)==v);
        }
        [Fact]
        public void Test18()
        {
            v = new Vacanza("g34", 300, "bari", 50, true, 150);
            string c = v.ToString();
            Assert.True(c != null);
        }
       
        
   
            

    }
}