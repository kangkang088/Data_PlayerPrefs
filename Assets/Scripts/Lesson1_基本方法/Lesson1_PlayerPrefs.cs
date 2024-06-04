using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1_PlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("myAge", 18);
        PlayerPrefs.SetFloat("myWeight", 65.5f);
        PlayerPrefs.SetString("myName", "kangkang");
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
