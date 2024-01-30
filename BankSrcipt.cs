using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textAnswer : MonoBehaviour 
{
public Text Alphabet;
public void firstgame (string alphabet) 
{
    Alphabet. text = alphabet;
    string firstGameResult = alphabet;
}
}

public class BankSrcipt : MonoBehaviour
{
    public TMP_InputField inputField;
    public static int inputValue;
    public string inputText;

    public void ReadInputField()
    {
        inputText = inputField.text;


        if(string.IsNullOrEmpty(inputText))
        {
            TextClick7.text = inputText;
        }

        if(int.TryParse(inputText, out inputValue))
        {
            if(inputValue % 10 == 0)
            {
                
                inputValue /= 10;
                TextClick7.text = inputValue.ToString();
            }
            else
                TextClick7.text = "Введите число кратное 10(Например: 100, 200 и т.д)";

        }

    }

    public void ShowMobileKeyboard()
    {
        TouchScreenKeyboard.Open("inputField.text", TouchScreenKeyboardType.Default);
    }

    public TextMeshProUGUI TextClick7;
    public TextMeshProUGUI TextClick;
    public static int mouseClick2 = 0;
    public static int j = 0, i = 0, h = 0, o = 0;
    public static bool isBuy10 = false;
    private void Start() 
    {
        mouseClick2 = PlayerPrefs.GetInt("mouseClick2", ClickMouseCount.mouseClicc);
    }
    public void BUY()
    {
        if(ClickMouseCount.mouseClicc >= inputValue)
        {
            mouseClick2 -= inputValue * 10;
            j++;
            isBuy10 = true;
            ClickMouseCount.mouseClicc = mouseClick2;
            PlayerPrefs.SetInt("ClickMouseCount.mouseClicc", ClickMouseCount.mouseClicc);
            PlayerPrefs.SetInt("mouseClick2", mouseClick2);
            TextClick.text = ClickMouseCount.mouseClicc.ToString();
        }
    }
    private void Update()
    {
        
        if(isBuy10 == false)
            mouseClick2 = ClickMouseCount.mouseClicc;
        TextClick.text = mouseClick2.ToString();
    }

}
