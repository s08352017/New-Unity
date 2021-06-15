using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce=11;
    public float gravityModifier=2;
    Rigidbody rb;
    bool isG = true;
    gamemanager gm;
    // Start is called before the first frame update
    void Start()
    {
        
            rb = GetComponent<Rigidbody>();
            Physics.gravity  = new Vector3(0, -30, 0);
            rb.AddForce(Vector3.up * 500);      
            gm = GameObject.Find("manager").GetComponent<gamemanager>();
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.W) && gm.isplay==true) 
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isG = false;
            Debug.Log("jump1");
        }

        
    }
    void OnCollisionEnter(Collision collision)
    {
        isG = true;
        
    }
}
