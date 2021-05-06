using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagJumpscare : MonoBehaviour
{
    private float speed = 150f;
    // Start is called before the first frame update
    void OnEnable()
    {
        transform.position = new Vector3(529, -567, 372);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 100)
        {
            transform.Translate(new Vector3(1, 0, 15)*Time.deltaTime*speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(transform.position);
        }
    }
}
