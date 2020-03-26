using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class exercise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("exercise script");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Squat")
        {
            SceneManager.LoadScene("Squat", LoadSceneMode.Single);
            Debug.Log("squat");
            transform.position = transform.position - new Vector3(0,0,10f);

        }
        if (other.tag == "BenchPress")
        {
            SceneManager.LoadScene("BenchPress", LoadSceneMode.Single);
            Debug.Log("bench");
            transform.position = transform.position - new Vector3(0, 0, 10f);

        }
    }
}
