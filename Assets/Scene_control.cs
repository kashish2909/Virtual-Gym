using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField]
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Squat")
        {
            SceneManager.LoadScene("Squat", LoadSceneMode.Single);
            Debug.Log("squat");
            transform.position = transform.position - new Vector3(0, 0, 10f);

        }
        if (other.tag == "BenchPress")
        {
            SceneManager.LoadScene("BenchPress", LoadSceneMode.Single);
            Debug.Log("squat");
            transform.position = transform.position - new Vector3(0, 0, 10f);

        }
    }

    public void Load_bench()
    {
        SceneManager.LoadScene("BenchPress", LoadSceneMode.Single);
    }

    public void Load_squat()
    {
        SceneManager.LoadScene("Squat", LoadSceneMode.Single);
    }
}
