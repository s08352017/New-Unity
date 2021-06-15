using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float MoveSpeed=7;//,jumpforce;
    gamemanager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("manager").GetComponent<gamemanager>();


    }

    // Update is called once per frame
    void Update()
    {
        if (gm.isplay == true)
        {

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(0, 0, 1) * -Time.deltaTime * MoveSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * MoveSpeed);
            }
            /*if(Input.GetKey(KeyCode.W))
            {
                GetComponent<Rigidbody> ().AddForce(0,200,0);
            }*/

        }  
    }
}
