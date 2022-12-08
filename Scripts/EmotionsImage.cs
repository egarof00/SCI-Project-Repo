using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionsImage : MonoBehaviour
{
    // MUST ADD SPRITES FOR ALL EMOTIONS HERE
    // decide how many emotions we want to have
    public Image EmotionImage;
    public Sprite HappySprite;
    public Sprite MehSprite;
    public Sprite SadSprite;
    
    public void ChangeEmotionImage(Sprite newEmotion)
    {
        EmotionImage.sprite = newEmotion;
    }
    
}
