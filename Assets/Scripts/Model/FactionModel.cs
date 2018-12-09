using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FactionModel {

    private int factionId;
    private string factionName;
    private string factionDescription;
    private string factionImgUrl;

    public int FactionId {
        get {
            return factionId;
        } set {
            factionId = value;
        }
    }

    public string FactionName {
        get {
            return factionName;
        } set {
            factionName = value;
        }
    }

    public string FactionDescription { 
        get {
            return factionDescription;
        } set {
            factionDescription = value;
        }
    }

    public string FactionImgUrl {
        get {
            return factionImgUrl;
        } set {
            factionImgUrl = value;
        }
    }



    public int GetFactionByName(string factionName, List<FactionModel> factionModel) {
        int factionId = factionModel.FirstOrDefault(w => w.factionName == factionName).factionId;
        return factionId;
    }

    public Sprite GetSpriteByFaction(FactionModel faction) {
        Sprite factionSprite = Resources.Load(faction.FactionImgUrl) as Sprite;
        return factionSprite;
    }


}


