using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    float Speed;


    private void Start()
    {
        Speed = 5;
    }

    // Update is called once per frame
    void Update()

    {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * Speed);

        //sliding movement:

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(0, 0, 10 * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(0, 0, -10 * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(10 * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-10 * Time.deltaTime, 0, 0);
        //}

        //block movement:

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
    }
}
