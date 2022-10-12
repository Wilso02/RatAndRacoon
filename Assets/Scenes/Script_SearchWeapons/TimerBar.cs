using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    public Slider timerSlider;
    //public Text timerText;
    public float gameTime;
    public GameObject GameOverScreen;

    private bool stopTimer; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

       // string textTime = string.Format("{0}:{10}");

        if(time <= 0)
        {
            stopTimer = true;
            /*GameOverScreen.transform.position = x,y,z
            x = 2;
            y = 3;
            z = -6;
            (2,3,-6);
            */

            GameObject.Find("GameOverScreen").transform.position = new Vector3(2,3,-6);
            GameObject.Find("Slider").SetActive(false);
            //Canvas.enabled = false;
        }

        if (stopTimer == false)
        {
         //   timerText.text = textTime;
            timerSlider.value = time;
        }


    }
}
