using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI CreditsText;
    public TextMeshProUGUI EmotionText;

    // DONT FORGET: make emotions uppercase - might need to convert credits int to a string
    public void ChangeTextField(TextMeshProUGUI textField, string newText)
    {
        textField.text = newText;
    }
}
