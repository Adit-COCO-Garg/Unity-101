using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBrainTime : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10);
    }
    void OnCollisionEnter(Collision thatObject)
    {
        if (thatObject.gameObject.tag.Equals("sphere"))
        {
            Debug.Log("here");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
