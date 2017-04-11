using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int mp = 53;
    public void Magic(int magic)
    {

        if (mp >= magic)
        {
            mp -= magic;

            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }


    }
    //Magic関数内でmpを5減らし、コンソールに
    //「魔法攻撃をした。残りMPは〇〇。」と表示してください。
    //mpが足りない場合、「MPが足りないため魔法が使えない。」と表示

}

public class Test : MonoBehaviour
{

    void Start()
    {
        Boss magic = new Boss();

        for (int i = 0; i < 11; i++)
        {
            magic.Magic(5);

        }




        int[] array = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length; i > 0; i--)
        {
            Debug.Log(array[i - 1]);
        }




    }



    // Update is called once per frame
    void Update()
    {

    }
}