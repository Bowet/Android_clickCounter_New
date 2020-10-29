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
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            i++;
            CountText.text = i.ToString();
        }
    }
    }

