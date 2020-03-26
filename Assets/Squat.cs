using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        position_init();
    }

    void position_init()
    {
        transform.position = new Vector3(7.79f, 0.057f, -2.52f);
        GameObject.Find("StraightBar (1)").GetComponent<Transform>().position = new Vector3(7.847f, 1.298f, -2.656f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
