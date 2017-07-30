using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject particle;

    PlayerBehavior _playerBehavior;

    
    Ray ray;


    Vector3 pos = new Vector3();

    // Use this for initialization
    void Start()
    {
        _playerBehavior = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerBehavior>();

       
    }

    // Update is called once per frame
    void FixedUpdate() // Fixed update will lock the frames pr sec so it will make sure to run this code
    {
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.gameObject.tag == "Enemy")
                {
                    Destroy(hit.transform.gameObject);
                }
                Debug.Log(hit.transform.gameObject.name);
            }


            
        }
    }

}