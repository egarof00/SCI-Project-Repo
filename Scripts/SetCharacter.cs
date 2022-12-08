using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCharacter : MonoBehaviour
{
    public Image CharacterImage;
    public GameObject PopupPanel;
    // FIXME: later make it so that popup only opens first time game is loaded
    private bool isFirstTime = true;


    public void Start()
    {
        if (isFirstTime)
        {
            PopupPanel.SetActive(true);
        }
        else
        {
            PopupPanel.SetActive(false);
        }
    }

    public void SetCharacterImage(Sprite newCharacter)
    {
        CharacterImage.sprite = newCharacter;
    }

    public void MakePopupInactive()
    {
        PopupPanel.SetActive(false);
        isFirstTime = false;
    }
}

