﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class up_down : MonoBehaviour
{
    public bool down = true;
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
    private float speed = 0.2f;
    public bool diy = false;
    public Camera sim;
    public Camera tpc;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("yo");

        //body parts found
        person = GameObject.Find("ThirdPersonController");
        spine = GameObject.Find("EthanSpine1");
        left_up_leg= GameObject.Find("EthanLeftUpLeg");
        left_leg = GameObject.Find("EthanLeftLeg");
        right_up_leg = GameObject.Find("EthanRightUpLeg");
        right_leg = GameObject.Find("EthanRightLeg");
        left_arm = GameObject.Find("EthanLeftArm");
        left_fore_arm = GameObject.Find("EthanLeftForeArm");
        right_arm = GameObject.Find("EthanRightArm");
        right_fore_arm = GameObject.Find("EthanRightForeArm");
        left_hand = GameObject.Find("EthanLeftHand");
        right_hand = GameObject.Find("EthanRightHand");


        spine.transform.rotation = spine.transform.rotation*Quaternion.Euler(0, 0, 8f);
        left_arm.transform.rotation = left_arm.transform.rotation * Quaternion.Euler(-20f,20f,-20f);
        right_arm.transform.rotation = right_arm.transform.rotation * Quaternion.Euler(20f, -20f, -20f);
        left_fore_arm.transform.rotation = left_fore_arm.transform.rotation * Quaternion.Euler(-60f,-60f,-60f);
        right_fore_arm.transform.rotation = right_fore_arm.transform.rotation * Quaternion.Euler(60f, 60f, -60f);
        left_hand.transform.rotation = left_hand.transform.rotation * Quaternion.Euler(40f, 0,0);
        right_hand.transform.rotation = right_hand.transform.rotation * Quaternion.Euler(-40f,0,0);
        sim.enabled = true;
        tpc.enabled = false;
        //right_fore_arm.transform.rotation = right_fore_arm.transform.rotation * Quaternion.Euler(-60f, 60f, 60f);
        //left_arm.transform.rotation = Quaternion.Euler(-20f,-10f,0f);
    }

    // Update is called once per frame

    void Update()
    {
        //neck.transform.rotation = Quaternion.Euler(0, 0, 3.916f);
        if(Input.GetKey(KeyCode.P))
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
            if (transform.position.y > 1.029f && down)
            {
                transform.Translate(-Vector3.up * Time.deltaTime * speed, Space.World);
                person.transform.Translate(-Vector3.up * Time.deltaTime * speed, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //person.transform.Translate(-Vector3.up * Time.deltaTime * 0.5f, Space.World);
            }
            if (transform.position.y <= 1.029f)
            {
                down = false;
            }
            if (transform.position.y < 1.298f && !down)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                person.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                //person.transform.Translate(Vector3.up * Time.deltaTime * 0.5f, Space.World);
            }
            if (transform.position.y >= 1.298f)
            {
                down = true;
            }
        }
        else
        {
            if (transform.position.y > 1.029f && down && Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(-Vector3.up * Time.deltaTime * speed, Space.World);
                person.transform.Translate(-Vector3.up * Time.deltaTime * speed, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                //person.transform.Translate(-Vector3.up * Time.deltaTime * 0.5f, Space.World);
            }
            if (transform.position.y <= 1.029f)
            {
                down = false;
            }
            if (transform.position.y < 1.298f && !down && Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                person.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
                left_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                right_leg.transform.Rotate(Time.deltaTime * -50f, 0, 0, Space.World);
                left_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                right_up_leg.transform.Rotate(Time.deltaTime * 50f, 0, 0, Space.World);
                //person.transform.Translate(Vector3.up * Time.deltaTime * 0.5f, Space.World);
            }
            if (transform.position.y >= 1.298f)
            {
                down = true;
            }
        }
    }
}
