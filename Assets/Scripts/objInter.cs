using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class objInter : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
    public Text scoreTxt;

    void Start()
    {
        scoreTxt.text = "殺敵數量=0";
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "XXXXXX")
        {
            collision.gameObject.SetActive(false);
            score += 1;
            scoreTxt.text = "殺敵數量="+ score.ToString();
            Debug.Log("score="+score.ToString());
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
