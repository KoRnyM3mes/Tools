using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Ui;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Int Data")]
public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntData obj)
    {
        if (value >= obj.value)
        {
            
        }
        else
        {
            value = obj.value;
        }
    }
    public void SetVale(IntData obj)
    {
        value = obj.value;
    }
    public void UpdateValue(int num)
    {
        value += num;
    }

    public void ReplaceValue(int num)
    {
        value = num;
    }

    public void DisplayImage(Image img)
    [
        img.fillAmount = value;
    ]

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
