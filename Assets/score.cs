using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public int goal;
    public int score1=0;
    public int score2=0;
    public Text ScoreUI1;
    public Text ScoreUI2;
    public GameObject ball;
    gamemanager gm;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("manager").GetComponent<gamemanager>();
        Physics.gravity = new Vector3(0, -10, 0);

    }
    private void OnCollisionEnter(Collision ball)
    {
        Vector3 Pos1 = new Vector3(0, 0, -9);
        Vector3 Pos2 = new Vector3(0, 0, -1);
        Vector3 Pos3 = new Vector3(0, 4, -1);
        Vector3 Pos4 = new Vector3(0, 4, -9);
        
            if (ball.gameObject.tag == "plane1" && gm.isplay==true)
            {
           
                score1 += 1;
                Debug.Log(score1);
                Score1 = score1;
                gm.p1.transform.position = Pos1;
                gm.p2.transform.position = Pos2;
                gm.ball.transform.position = Pos3;
            
            }
            else if (ball.gameObject.tag == "plane2" && gm.isplay == true)
            {
            
            
                score2 += 1;
                Debug.Log(score2);
                Score2 = score2;
                gm.p1.transform.position = Pos1;
                gm.p2.transform.position = Pos2;
                gm.ball.transform.position = Pos4;
            
            }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (score1 == goal)
        {
            gm.gameoverp1();
        }else if (score2 == goal)
        {
            gm.gameoverp2();
        }
    }
    public int Score1
    {
        get
        {
            return score1;
        }
        set
        {
            score1 = value;
            ScoreUI1.text = score1.ToString();
            
        }
    }
    public int Score2
    {
        get
        {
            return score2;
        }
        set
        {
            score2 = value;
            ScoreUI2.text = score2.ToString();
        }
    }
}
