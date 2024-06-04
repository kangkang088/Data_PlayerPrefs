using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public int id;
    public int num;
}
public class Player {
    public string name;
    public int age;
    public int atk;
    public int def;

    public List<Item> itemList;

    public void Save() {
        PlayerPrefs.SetString("name", name);
        PlayerPrefs.SetInt("age", age);
        PlayerPrefs.SetInt("atk", atk);
        PlayerPrefs.SetInt("def", def);
        PlayerPrefs.Save();

        PlayerPrefs.SetInt("ItemNum", itemList.Count);
        for (int i = 0; i < itemList.Count; i++) {
            PlayerPrefs.SetInt("ItemId" + i , itemList[i].id);
            PlayerPrefs.SetInt("ItemNum" + i, itemList[i].num);
        }
    }
    public void Load() {
        name = PlayerPrefs.GetString("name", "未命名");
        age = PlayerPrefs.GetInt("age", 18);
        atk = PlayerPrefs.GetInt("atk", 100);
        def = PlayerPrefs.GetInt("def", 50);

        int num = PlayerPrefs.GetInt("ItemNum",0);
        itemList = new List<Item>();
        Item item;
        for (int i = 0; i < num; i++) {
            item = new Item();
            item.id = PlayerPrefs.GetInt("ItemId" + i);
            item.num = PlayerPrefs.GetInt("ItemNum" + i);
            itemList.Add(item);
        }
    }
    public void Delete() {
        PlayerPrefs.DeleteAll();
    }
}
public class Lesson1_Exercises : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        //Player p = new Player();

        //p.Load();
        //print(p.name);
        //print(p.age);
        //print(p.atk);
        //print(p.def);

        //p.name = "kangkang123";
        //p.age = 22;
        //p.atk = 520;
        //p.def = 1314;
        //p.Save();

        #region exercise2
        Player p = new Player();
        //p.Delete();
        p.Load();
        print(p.itemList.Count);
        for (int i = 0; i < p.itemList.Count; i++) {
            print("道具Id：" + p.itemList[i].id);
            print("道具Num：" + p.itemList[i].num);
        }

        Item item = new Item();
        item.id = 1;
        item.num = 1;
        p.itemList.Add(item);
        Item item2 = new Item();
        item2.id = 2;
        item2.num = 2;
        p.itemList.Add(item2);
        p.Save();
        #endregion
    }

    // Update is called once per frame
    void Update() {

    }
}
