using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTagJumpscare : MonoBehaviour
{
    private float speed = 250f;
    // Start is called before the first frame update
    void OnEnable()
    {
        transform.position = new Vector3(411, -526, -256);
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < 76.1)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            transform.Translate(Vector3.right *5 * Time.deltaTime * speed);
        }
    }
}
