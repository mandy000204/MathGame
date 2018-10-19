using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

    public bool isCorrect; //建立布林變數 -> 標記該選項是否是正確的答案：
    private readonly bool again;
    public GameObject otherOption1;
    public GameObject otherOption2;

    void Start ()
    {
        GenerateQuestion();
    }

    private void GenerateQuestion()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        
    }

     void OnMouseDown() //用滑鼠點擊選項時
     {
        if (isCorrect) //在分流裡使用 GetComponent 取得 TextMesh 並且更換文字的顏色
        {
            GetComponent<TextMesh>().color = Color.green;
            //isCorrect 為 True 時，顯示為綠色

        }


        else //在分流裡使用 GetComponent 取得 TextMesh 並且更換文字的顏色
        {
            GetComponent<TextMesh>().color = Color.red;

            if (otherOption1.GetComponent<Option>().isCorrect)
            {
                otherOption1.GetComponent<TextMesh>().color = Color.yellow;
            }
            else
            {
                otherOption2.GetComponent<TextMesh>().color = Color.yellow;
            }

        }

    }
        
    }

