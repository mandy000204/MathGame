using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class again : MonoBehaviour
{

    public GameObject core;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        core.GetComponent<GameController>().GenerateQuestion();
    }
}
