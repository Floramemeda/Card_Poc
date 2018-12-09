using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Data {
    public class FactionData {
        public List<FactionModel> GetAllFactionList() {
            List<FactionModel> factionList = new List<FactionModel>();
            
            #region allFactions
            FactionModel wanFaMen = new FactionModel()
            {
                FactionId = 1,
                FactionName = "万法门",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "单身者的门派（确信）"
            };
            factionList.Add(wanFaMen);

            FactionModel yuanLiMen = new FactionModel()
            {
                FactionId = 2,
                FactionName = "元力门",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "万有引力"
            };
            factionList.Add(yuanLiMen);

            FactionModel tianLingLing = new FactionModel()
            {
                FactionId = 3,
                FactionName = "天灵岭",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "天演图录"
            };
            factionList.Add(tianLingLing);

            FactionModel fenTianFu = new FactionModel()
            {
                FactionId = 4,
                FactionName = "焚天府",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "热学"
            };
            factionList.Add(fenTianFu);

            FactionModel guangHuaDian = new FactionModel()
            {
                FactionId = 5,
                FactionName = "光华殿",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "光学"
            };
            factionList.Add(guangHuaDian);

            FactionModel piaoMiaogGong = new FactionModel()
            {
                FactionId = 6,
                FactionName = "飘渺宫",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "量子力学"
            };
            factionList.Add(piaoMiaogGong);

            FactionModel benLeiGe = new FactionModel()
            {
                FactionId = 7,
                FactionName = "奔雷阁",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "电学"
            };
            factionList.Add(benLeiGe);

            FactionModel fenJinGu = new FactionModel()
            {
                FactionId = 8,
                FactionName = "焚金谷",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "化学"
            };
            factionList.Add(fenJinGu);

            FactionModel xinYueXianYuan = new FactionModel() {
                FactionId = 9,
                FactionName = "辛岳仙院",
                FactionImgUrl = "FactionCardBackground",
                FactionDescription = "新手村"
            };
            factionList.Add(xinYueXianYuan);

            #endregion

            return factionList;

        }
    }
}
