using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model {
    public class CardModel {

        private int cardId;
        public int CardId {
            get {
                return cardId;
            } set {
                cardId = value;
            }
        }
        private string cardName;
        public string CardName {
            get {
                return cardName;
            } set {
                cardName = value;
            }
        }
        private int factionId;
        public int FactionId {
            get {
                return factionId;
            } set {
                factionId = value;
            }
        }
        private int typeId;
        public int TypeId {
            get {
                return typeId;
            } set {
                typeId = value;
            }
        }
        private string description;
        public string Description {
            get {
                return description;
            } set {
                description = value;
            }
        }
        private string imageUrl;
        public string ImageUrl {
            get {
                return imageUrl;
            } set {
                imageUrl = value;
            }
        }
        private int attackValue;
        public int AttackValue {
            get {
                return attackValue;
            } set {
                attackValue = value;
            }
        }
        private int defenseValue;
        public int DefenseValue {
            get {
                return defenseValue;
            } set {
                defenseValue = value;
            }
        }
        private int spiritualPower;
        public int SpiritualPower {
            get {
                return spiritualPower;
            } set {
                spiritualPower = value;
            }
        }
        private int cultivationLevel;
        public int CultivationLevel {
            get {
                return cultivationLevel;
            } set {
                cultivationLevel = value;
            }
        }
        private int weightedValue;
        public int WeightedValue {
            get {
                return weightedValue;
            } set {
                weightedValue = value;
            }
        }
        private string specialKeyword;
        public string SpecialKeyword {
            get {
                return specialKeyword;
            } set {
                specialKeyword = value;
            }
        }
    }
}
