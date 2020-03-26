using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class legpress_sc : MonoBehaviour
{
    public bool up = false;
    public GameObject person;
    public GameObject spine;
    public GameObject left_up_leg;
    public GameObject left_leg;
    public GameObject right_up_leg;
    public GameObject right_leg;
    public GameObject left_arm;
    public GameObject left_fore_arm;
    public GameObject right_arm;
    public GameObject right_fore_arm;
    public GameObject right_hand;
    public GameObject left_hand;
    public float speed;
    public bool diy = false;
    public Camera sim;
    public Camera tpc;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("yo");
        speed = 25f;
        //body parts found
        person = GameObject.Find("ThirdPersonController");
        spine = GameObject.Find("EthanSpine1");
        left_up_leg = GameObject.Find("EthanLeftUpLeg");
        left_leg = GameObject.Find("EthanLeftLeg");
        right_up_leg = GameObject.Find("EthanRightUpLeg");
        right_leg = GameObject.Find("EthanRightLeg");
        left_arm = GameObject.Find("EthanLeftArm");
        left_fore_arm = GameObject.Find("EthanLeftForeArm");
        right_arm = GameObject.Find("EthanRightArm");
        right_fore_arm = GameObject.Find("EthanRightForeArm");
        left_hand = GameObject.Find("EthanLeftHand");
        right_hand = GameObject.Find("EthanRightHand");
        sim.enabled = true;
        tpc.enabled = false;
        /*
        spine.transform.rotation = spine.transform.rotation * Quaternion.Euler(0, 0, 8f);
        left_arm.transform.rotation = left_arm.transform.rotation * Quaternion.Euler(-20f, 20f, -20f);
        right_arm.transform.rotation = right_arm.transform.rotation * Quaternion.Euler(20f, -20f, -20f);
        left_fore_arm.transform.rotation = left_fore_arm.transform.rotation * Quaternion.Euler(-60f, -60f, -60f);
        right_fore_arm.transform.rotation = right_fore_arm.transform.rotation * Quaternion.Euler(60f, 60f, -60f);
        left_hand.transform.rotation = left_hand.transform.rotation * Quaternion.Euler(40f, 0, 0);
        right_hand.transform.rotation = right_hand.transform.rotation * Quaternion.Euler(-40f, 0, 0);
        //right_fore_arm.transform.rotation = right_fore_arm.transform.rotation * Quaternion.Euler(-60f, 60f, 60f);
        //left_arm.transform.rotation = Quaternion.Euler(-20f,-10f,0f);
        */
    }
    //-0.14 - 0.078
    // Update is called once per frame

    void Update()
    {
        //neck.transform.rotation = Quaternion.Euler(0, 0, 3.916f);
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("Onboarding_VRTK_assets", LoadSceneMode.Single);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            diy = !diy;
            sim.enabled = !sim.enabled;
            tpc.enabled = !tpc.enabled;
        }
        if (!diy)
        {
            if (up)
            {
                transform.Translate(0, Time.deltaTime * 0.15f, Time.deltaTime * 0.04f, Space.World);
                left_leg.transform.Rotate(-Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                right_leg.transform.Rotate(-Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * speed, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * speed, 0, 0, Space.World);
                //left_fore_arm.transform.Rotate(Time.deltaTime * 20f, Time.deltaTime * 4f, 0, Space.World);
                //right_fore_arm.transform.Rotate(Time.deltaTime * 20f, -Time.deltaTime * 4f, 0, Space.World);
                /*
                person.transform.Translate(-Vector3.up * Time.deltaTime * speed, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //person.transform.Translate(-Vector3.up * Time.deltaTime * 0.5f, Space.World);
                */
            }
            if (transform.position.y <= -0.18f)
            {
                up = true;
            }
            if (!up)
            {

                transform.Translate(0, -Time.deltaTime * 0.15f, -Time.deltaTime * 0.04f, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.World);
                right_up_leg.transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.World);
                //left_fore_arm.transform.Rotate(-Time.deltaTime * 20f, -Time.deltaTime * 4f, 0, Space.World);
                //right_fore_arm.transform.Rotate(-Time.deltaTime * 20f, Time.deltaTime * 4f, 0, Space.World);
                //person.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                //left_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //right_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //left_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                //right_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                //person.transform.Translate(Vector3.up * Time.deltaTime * 0.5f, Space.World);
            }
            if (transform.position.y >= 0.078f)
            {
                up = false;
            }
        }
        else
        {
            if (up && Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, Time.deltaTime * 0.15f, Time.deltaTime * 0.04f, Space.World);
                left_leg.transform.Rotate(-Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                right_leg.transform.Rotate(-Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * speed, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * speed, 0, 0, Space.World);
                //left_fore_arm.transform.Rotate(Time.deltaTime * 20f, Time.deltaTime * 4f, 0, Space.World);
                //right_fore_arm.transform.Rotate(Time.deltaTime * 20f, -Time.deltaTime * 4f, 0, Space.World);
                /*
                person.transform.Translate(-Vector3.up * Time.deltaTime * speed, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //person.transform.Translate(-Vector3.up * Time.deltaTime * 0.5f, Space.World);
                */
            }
            if (transform.position.y <= -0.18f)
            {
                up = true;
            }
            if (!up && Input.GetKey(KeyCode.DownArrow))
            {

                transform.Translate(0, -Time.deltaTime * 0.15f, -Time.deltaTime * 0.04f, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * speed * 1.8f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.World);
                right_up_leg.transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.World);
                //left_fore_arm.transform.Rotate(-Time.deltaTime * 20f, -Time.deltaTime * 4f, 0, Space.World);
                //right_fore_arm.transform.Rotate(-Time.deltaTime * 20f, Time.deltaTime * 4f, 0, Space.World);
                //person.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                //left_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //right_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //left_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                //right_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                //person.transform.Translate(Vector3.up * Time.deltaTime * 0.5f, Space.World);
            }
            if (transform.position.y >= 0.078f)
            {
                up = false;
            }
        }
    }
}
