using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    public string randomOperator; 
    public int answer;

    public int a; //隨機產生題目數字1
    public int b; //隨機產生題目數字2

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject again;



    void Start()
    {
        
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GenerateQuestion()
    {
        option1.GetComponent<TextMesh>().color = new Color(1.0f, 1.0f, 1.0f);
        option2.GetComponent<TextMesh>().color = new Color(1.0f, 1.0f, 1.0f);
        option3.GetComponent<TextMesh>().color = new Color(1.0f, 1.0f, 1.0f);
        a = Random.Range(0, 100);
        b = Random.Range(0, 100);

        int operatorNumber = Random.Range(0, 3);

        if (operatorNumber == 0) //分流一：operatorNumber 為 0，進行加法
        {
            randomOperator = "+";
            answer = a + b;
        }

        else if (operatorNumber == 1) //分流二：operatorNumber 為 1，進行減法
        {
            randomOperator = "-";
            answer = a - b ;

        }

        else //分流三：operatorNumber 不為 0，進行減法
        {
            randomOperator = "*" ;
            answer = a * b ;
        }

        int option = Random.Range(0, 3); //創造選項

        string questionText = a + " " + randomOperator + " " + b + " =?";
        //取得 Question 的 TextMesh，將其文字修改為問題

        question.GetComponent<TextMesh>().text = questionText;
        //使用 option 進行分流後，把問題放入 Question 的 TexMesh 

        if (option == 0)
        {
            again = option1;
            option1.GetComponent<TextMesh>().text = answer.ToString(); //分流1: 產生正確答案
            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString(); //分流2: 產生錯誤答案
            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 9)).ToString(); //分流3: 產生錯誤答案
            option1.GetComponent<Option>().isCorrect = true; 
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = false;
            //在 option 分流中使用 GetComponent 取得 Option，並將正確答案設定在 isCorrect 公開變數
            //若為正確答案，則是 true，若否，則是 false
            
        }

        else if (option == 0)
            {
                again = option2;
                option2.GetComponent<TextMesh>().text = answer.ToString(); //分流1: 產生正確答案
                option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString(); //分流2: 產生錯誤答案
                option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 9)).ToString(); //分流3: 產生錯誤答案
                option2.GetComponent<Option>().isCorrect = true;
                option1.GetComponent<Option>().isCorrect = false;
                option3.GetComponent<Option>().isCorrect = false;
                

        }

        else
        {
                again = option3;
                option3.GetComponent<TextMesh>().text = answer.ToString(); //分流1: 產生正確答案
                option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString(); //分流2: 產生錯誤答案
                option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 9)).ToString(); //分流3: 產生錯誤答案
                option3.GetComponent<Option>().isCorrect = true;
                option2.GetComponent<Option>().isCorrect = false;
                option1.GetComponent<Option>().isCorrect = false;
                
        }


        

    }

}