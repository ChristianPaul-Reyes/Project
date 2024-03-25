using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
    //gameObject.transform.position = new Vector3(10, 0, 0);
    //Rigidbody2D myRigidbody2D = gameObject.AddComponent<Rigidbody2D>();
    //myRigidbody2D.mass = 10;
    //Rigidbody2D myRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    //myRigidbody2D.mass = 10;
    myRigidbody2D.mass = 10;
  }

    // Update is called once per frame
    void Update()
    {
        
    }
}
