using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundImageChange : MonoBehaviour
{
    public Image BackroundImage;
    public Sprite MorningBackground;
    public Sprite AfternoonBackground;
    public Sprite EveningBackground;
    // CHOOSE NEW IMAGES WITH EVERYONE
    
    private DateTime currentDateAndTime;
    private int currentHourInt;
    

    public void Update()
    {
        currentDateAndTime = System.DateTime.Now;
        currentHourInt = currentDateAndTime.Hour;
        CheckBackgroundImage(currentHourInt);
    }

    private void CheckBackgroundImage(int currentHour)
    {
        if (currentHour >= 7 && currentHour < 12)
        {
            ChangeBackgroundImage(MorningBackground);
        }
        else if (currentHour >= 12 && currentHour < 17)
        {
            ChangeBackgroundImage(AfternoonBackground);
        }
        else
        {
            ChangeBackgroundImage(EveningBackground);
        }
    }
    
    private void ChangeBackgroundImage(Sprite newBackground)
    {
        BackroundImage.sprite = newBackground;
    }
}
