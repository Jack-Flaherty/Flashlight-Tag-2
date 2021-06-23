using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManAI : MonoBehaviour
{
    public int MusicManLVL ;
    public float countDownTime;     
    // Start is called before the first frame update
    void Start()
    {
        //If Music Man is active, set his countdown timer to 45 seconds minus 1.25 times his difficulty
        if (MusicManLVL > 0)
        {
            countDownTime = 45f - (MusicManLVL * 1.25f);
        }
        //If Music Man is not Active, Set his countdown timer to 45
        else
        {
            countDownTime = 45f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //If Music Man is active, countdown each second
        if (MusicManLVL > 0)
        {
            countDownTime -= Time.deltaTime;
        }
        //No Countdown if Music Man is not Active
        else;
        //Switch To determine Music Man Phase
        switch (countDownTime)
        {
            //Timer >= 30
            case 1:
                
                break;
            //30 > Timer > 10  
            case 2:
            
                break;
            //10 >= Timer > 0    
            case 3:

                break;
            //0>= Timer
            case 4:
                InitializeJS();
                break;
        }
    }
    public void InitializeJS()
    {
        //Randomize Jumpscare Countdown 2
        //Play Song
        //Jumpscare
    }
}
