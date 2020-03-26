using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do_squat : MonoBehaviour
{
    // Start is called before the first frame update
    private Do_squat person;
    void Start()
    {
        Debug.Log(GetComponent<Transform>().position);
        //person = GameObject.Find("FPSController").GetComponent<Do_squat>();
        //Debug.Log(person==null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
