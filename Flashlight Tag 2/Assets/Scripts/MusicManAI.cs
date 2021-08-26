using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManAI : MonoBehaviour
{
    public GameObject MusicMan;

    public int MusicManLVL;

    public float countDownTime;
    public float maxCountDownTime;

    private bool jsInitialized;
    AudioSource audioSource;

    private float jsCountDown;

    public AudioClip jsMM;

    public GameObject MusicManJS;
    // Start is called before the first frame update
    void Start()
    {
        MusicManLVL = TitleButtons.MusicManAINumber;
        //If Music Man is active, set his countdown timer to 45 seconds minus 1.25 times his difficulty
        if (MusicManLVL > 0)
        {
            maxCountDownTime = 45f - (MusicManLVL * 1.25f);
        }
        //If Music Man is not Active, Set his countdown timer to a very big number
        else
        {
            maxCountDownTime = 9999;
        }
        //Start With The Count Down Time at Max
        countDownTime = maxCountDownTime;
        jsInitialized = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //If Music Man is active, countdown each second
        if (MusicManLVL > 0)
        {
            //Constantly Count the Var Down per Second
            countDownTime -= Time.deltaTime;
            //As long as the Character isn't Ready to jumpscare Allow this Function
            if(countDownTime > 0)
            {
                //If Space is Pressed and the countdown time is less than Max allow the box to be rewound
                if (Input.GetKey(KeyCode.Space) && countDownTime < maxCountDownTime)
                {
                    countDownTime += 4*Time.deltaTime;
                }
            }
            //If The Countdown Reaches 0 or below, the jumpscare will be initalized based on a bool to keep it from repeating
            else
            {
                if (!jsInitialized)
                {
                    InitializeJS();
                }
                if (jsCountDown > 0)
                {
                    jsCountDown -= Time.deltaTime;
                }
                else
                {
                    Debug.Log("Jumpscared!");
                    MMJumpscare();
                }
            }
        }
        //If MusicMan has difficulty of 0, he does not appear
        else
        {
            MusicMan.SetActive(false);
        }
    }
    public void InitializeJS()
    {
        jsInitialized = true;
        audioSource.pitch = -0.38f;
        audioSource.volume = 0.38f;
        jsCountDown = Random.Range(1, 12);
    }
    public void MMJumpscare()
    {
        MusicManJS.SetActive(true);
    }
}
