using workeshope_bank.DataBase;

namespace workeshope_bank.Entity
{
    public class OwnerShiptotal
    {
        public List<CarditCard> CarditCards { get; set; }
        public decimal TotalOwnerShip() 
        {
            decimal value = 0;
            foreach (var item in CarditCards)
            {
                value += item.OwnerShip;
            }
            return value;

        }

        public List<CarditCard> GetAllCard()
        {
            return CardData.carditCards;
        }

        public CarditCard  GetcardById(int id)
        {
            return CardData.carditCards.FirstOrDefault(b => b.Id == id);
        }

    }
}
