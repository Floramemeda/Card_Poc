using Assets.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Data {
    public class CardData {
        private Random random = new Random();
        private List<string> specialKeywordList = new List<string>() {
            "天妒",
            ""
        };
        public List<CardModel> GetAllCardList() {
            List<CardModel> allCardList = new List<CardModel>();

            //Generate random card info
            for (int i = 1; i < 30; i++) {
                CardModel newCard = new CardModel() {
                    CardId = i,
                    CardName = "Card" + i,
                    FactionId = random.Next(1, 9),
                    TypeId = random.Next(1, 5),
                    Description = string.Format("This is No.{0} random generated card.", i),
                    ImageUrl = "blah",
                    AttackValue = random.Next(1, 10),
                    DefenseValue = random.Next(1, 10),
                    SpiritualPower = random.Next(1, 5),
                    CultivationLevel = random.Next(1, 3),
                    WeightedValue = random.Next(1, 10),
                    SpecialKeyword = specialKeywordList[random.Next(1, 2)]
                };
                allCardList.Add(newCard);
            }
            return allCardList;

        }
    }
}
