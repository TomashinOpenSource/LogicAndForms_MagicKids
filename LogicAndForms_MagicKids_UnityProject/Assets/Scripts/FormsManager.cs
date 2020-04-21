using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormsManager : MonoBehaviour
{
    const int formsCount = 9;
    public Slider slider;
    public Transform FormHolder;
    public GameObject[] formsArray = new GameObject[formsCount];


    void Start()
    {
        slider.maxValue = formsCount;
        slider.value = 0;
        FormAppear((int)slider.value);
    }

    
    void Update()
    {
        
    }

    public void NextButtonPressed()
    {
        slider.value += slider.maxValue / formsCount;
        FormAppear((int)slider.value);
    }

    public void BackButtonPressed()
    {
        slider.value -= slider.maxValue / formsCount;
        FormAppear((int)slider.value);
    }

    void FormAppear(int index)
    {
        if (index < 0 || index >= formsCount) return;
        if (FormHolder.childCount > 0) foreach (Transform child in FormHolder) Destroy(child.gameObject);
        GameObject Form = Instantiate(formsArray[index], FormHolder);
    }
}
