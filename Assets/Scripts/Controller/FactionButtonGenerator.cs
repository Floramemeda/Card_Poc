using Assets.Scripts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controller {
    public class FactionButtonGenerator : MonoBehaviour {
        private FactionData factionData = new FactionData();
        [SerializeField] Transform panel;
        [SerializeField] GameObject buttonPrefab;

        private void Start() {
            List<FactionModel> factions = factionData.GetAllFactionList();
            foreach (var faction in factions) {
                GameObject button = (GameObject)Instantiate(buttonPrefab);
                button.GetComponentInChildren<Text>().text = faction.FactionName;
                button.transform.SetParent(panel,false);
                //button.GetComponent<Image>().sprite = faction.GetSpriteByFaction(faction);
            }
        }
    }
}

