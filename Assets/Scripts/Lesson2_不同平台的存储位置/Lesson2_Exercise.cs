using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankListInfo {
    public List<RankInfo> rankList;
    public RankListInfo() {
        Load();
        //Delete();
    }

    public void Add(string name, int score, int time) {
        rankList.Add(new RankInfo(name, score, time));
    }
    public void Save() {
        PlayerPrefs.SetInt("rankListNum", rankList.Count);
        for (int i = 0; i < rankList.Count; i++) {
            RankInfo rankInfo = rankList[i];
            PlayerPrefs.SetString("rankInfo" + i, rankInfo.playerName);
            PlayerPrefs.SetInt("rankScore" + i, rankInfo.playerScore);
            PlayerPrefs.SetInt("rankTime" + i, rankInfo.playerTime);
        }
    }
    private void Load() {
        int num = PlayerPrefs.GetInt("rankListNum", 0);
        rankList = new List<RankInfo>();
        for (int i = 0; i < num; i++) {
            RankInfo rankInfo = new RankInfo(PlayerPrefs.GetString("rankInfo" + i),
                PlayerPrefs.GetInt("rankScore" + i),
                PlayerPrefs.GetInt("rankTime" + i));
            rankList.Add(rankInfo);
        }
    }

    private void Delete() {
        PlayerPrefs.DeleteAll();
    }
}
public class RankInfo {
    public string playerName;
    public int playerScore;
    public int playerTime;

    public RankInfo(string name, int score, int time) {
        this.playerName = name;
        this.playerScore = score;
        this.playerTime = time;
    }
}
public class Lesson2_Exercise : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        RankListInfo rankListInfo = new RankListInfo();
        print(rankListInfo.rankList.Count);
        for (int i = 0; i < rankListInfo.rankList.Count; i++) {
            print("name:" + rankListInfo.rankList[i].playerName);
            print("score:" + rankListInfo.rankList[i].playerScore);
            print("time:" + rankListInfo.rankList[i].playerTime);
        }
        rankListInfo.Add("kangkang", 100, 5);
        rankListInfo.Save();
        
    }

    // Update is called once per frame
    void Update() {

    }
}
