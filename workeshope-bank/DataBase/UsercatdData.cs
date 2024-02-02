using System.Diagnostics.Metrics;
using workeshope_bank.Entity;

namespace workeshope_bank.DataBase
{
    public static class UsercatdData
    {
        public static List<User> user = new List<User>()
        {
            new User()
            {
                Name="kiana",
                UsercarditCard = new List<CarditCard>
                { new CarditCard()
                {
                     Id = 1,
                     BankName= "maskan",
                     OwnerShip=10000
                },
            new CarditCard()
            {
                   Id = 2,
                   BankName= "meli",
                   OwnerShip=200


            },

                }
            }


        };
    }
}
