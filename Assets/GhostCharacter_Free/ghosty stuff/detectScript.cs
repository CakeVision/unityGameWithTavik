using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
        }
        throw new NotImplementedException();
    }
}
