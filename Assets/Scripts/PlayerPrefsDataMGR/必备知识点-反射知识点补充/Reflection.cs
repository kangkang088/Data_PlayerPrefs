using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Father { }
public class Son : Father { }
public class Reflection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Type fatherType = typeof(Father); 
        Type sonType = typeof(Son);

        if (fatherType.IsAssignableFrom(sonType)) {
            Father father = Activator.CreateInstance(sonType) as Father;
            print(father);
        }

        List<int> vs = new List<int>();
        Type typeInt = vs.GetType();
        Type[] types = typeInt.GetGenericArguments();
        print(types[0]);

        Dictionary<string, float> keyValuePairs = new Dictionary<string, float>();
        Type typeDictionary = keyValuePairs.GetType();
        types = typeDictionary.GetGenericArguments();
        print(types[0]);
        print(types[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
