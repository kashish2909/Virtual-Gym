using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player: "+GetComponent<Transform>().position);
        Debug.Log("bar: " + GameObject.Find("StraightBar (1)").GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
