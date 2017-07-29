using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject particle;

    PlayerBehavior _playerBehavior;

    RaycastHit hit;

    Vector3 pos = new Vector3();
    Vector3 c;

    // Use this for initialization
    void Start()
    {
        _playerBehavior = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerBehavior>();
        c = Camera.main.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetMouseButton(0))
        {

            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2));

            Vector3 fwd = pos.normalized;
            Debug.DrawLine(c, fwd.normalized * 50, Color.red);


            if (Physics.Raycast(c, fwd, 40))
            {

                Debug.DrawLine(c, fwd * 10, Color.red);

                print("There is something in front of the object!");
            }

            Debug.Log("Recieving Mouse input");
        }
    }

}