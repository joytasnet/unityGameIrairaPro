using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GUIController con;

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.down;
        dir.x = Input.GetAxis("Horizontal")*0.1f;
        if (Input.GetKey("z")) {
            dir.y = 1.0f;
        } else {
            dir.y = -1.0f;
        }
     
        Physics.gravity = dir.normalized * 9.81f;
    }
    private void OnCollisionEnter(Collision collision) {
        //GameObject go = collision.gameObject.transform.parent.gameObject;
        //Destroy(go);
        if (collision.gameObject.tag == "Wall") {
            GetComponent<Rigidbody>().isKinematic = true;
            con.Str = "Game Over";
        }else if (collision.gameObject.name == "GoalPoint") {
            GetComponent<Rigidbody>().isKinematic = true;
            con.Str = "Game Clear!!";
        }
       
       // Destroy(gameObject);
    }
    
}
