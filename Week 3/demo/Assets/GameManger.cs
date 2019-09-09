using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public GameObject gO;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 20; i++)
        {
            Instantiate(gO, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


 
}
