using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManJumpscare : MonoBehaviour
{
    private float speed = 1900f;
    private float speed2 = 250f;
    // Start is called before the first frame update
    void OnEnable()
    {
        transform.position = new Vector3(550, -1270, 439);
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.y) < -354)
        {
            transform.Translate(Vector3.up * Time.deltaTime *speed);
        }
        else
        {
            if (transform.position.z > 150)
            {
                transform.Translate(new Vector3(1, 0, 15) * Time.deltaTime * speed2);
            }
        }
    }
}
