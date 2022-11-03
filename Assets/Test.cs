using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    
    {
        //要素数5の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入
        array[0] = 50;
        array[1] = 20;
        array[2] = 90;
        array[3] = 150;
        array[4] = 5;

        //配列の要素を順番に表示
        for (int i = 0; i < 5; i++)
        {
                Debug.Log(array [i]);
        }
        
        //配列の要素を逆順に表示
        for (int i = 4; 0 <= i; i--)
        {
                Debug.Log(array [i]);
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
