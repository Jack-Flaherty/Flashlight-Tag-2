using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManJumpscare : MonoBehaviour
{
    private float speed = 1900f;
    private float speed2 = 250f;
    private bool gameStart;
    public AudioClip mmScream;
    public AudioSource mmSource;
    // Start is called before the first frame update
    void OnEnable()
    {
        mmSource.PlayOneShot(mmScream, 2f);
        if (gameStart)
        {
            transform.position = new Vector3(550, -1270, 439);
        }
    }
    private void Start()
    {
        gameStart = GameManager.gameStart;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
        //if in game
        if((gameStart))
        {
            if ((transform.position.y) < .15)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed2/70);
            }
            else
            {
                if (transform.position.z < -9)
                {
                    transform.Translate(new Vector3(1, 0, 3) * Time.deltaTime * speed2/65);
                }
            }
        }
        //If Extras Menu
        else
        {
            if ((transform.position.y) < -354)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
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
}
