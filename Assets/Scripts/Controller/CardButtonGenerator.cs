using Assets.Scripts.Data;
using Assets.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controller {
    class CardButtonGenerator : MonoBehaviour {
        private CardData cardData = new CardData();
        [SerializeField] Transform contentArea;
        [SerializeField] GameObject cardPrefab;

        private void Start() {
            List<CardModel> allCardList = cardData.GetAllCardList();
            foreach (var card in allCardList) {
                GameObject button = (GameObject)Instantiate(cardPrefab);
                button.GetComponentInChildren<Text>().text = card.CardName;
                button.transform.SetParent(contentArea, false);
            }
        }
    }
}
