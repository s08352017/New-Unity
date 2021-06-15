using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move2 : MonoBehaviour
{
    public float MoveSpeed=7;
    gamemanager gm;//, jumpforce;
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
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * MoveSpeed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(0, 0, 1) * -Time.deltaTime * MoveSpeed);
            }
            /*   if (Input.GetKey(KeyCode.UpArrow))
               {
                   GetComponent<Rigidbody>().AddForce(0, 200, 0);
               }
            */
        }
    }
}
