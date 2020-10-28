using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;

public class TouchtoConsole : MonoBehaviour
{
    public int i;
    public Text CountText;


    private void Start()
    {
       // CountText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        foreach (Touch peter in Input.touches)
        {
            if (peter.phase == TouchPhase.Began)
            {
                i++;
            }
        }
        CountText.text = i.ToString();
    }
}
