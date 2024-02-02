using workeshope_bank.Entity;

namespace workeshope_bank.DataBase
{
    public static class CardData
    {
        public static int counter = 0;
        public static List<CarditCard> carditCards = new List<CarditCard>()
        
        {
            new CarditCard()
            {
                Id = counter+1,
                BankName= "maskan",
                OwnerShip=10000
                

            },
            new CarditCard()
            {
                Id = counter+1,
                BankName= "meli",
                OwnerShip=200


            },
              new CarditCard()
            {
              Id = counter+1,
              BankName= "saman",
              OwnerShip=50000


            }

        };
        public static List<User> user = new List<User>()
        {
            new User()
            {
                Name="kiana",
                UsercarditCard = new List<CarditCard>
                { new CarditCard()
                {
                     Id = counter+1,
                     BankName= "maskan",
                     OwnerShip=10000


            },
            new CarditCard()
            {
                   Id = counter+1,
                   BankName= "meli",
                   OwnerShip=200


            },

                } 
            }   
            
            
        };
    }
}
