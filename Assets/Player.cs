using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
        DisplayDatePattern1(dateTime);
        DisplayDatePattern2(dateTime);
        DisplayDatePattern3(dateTime);
        DisplayDatePattern3_2(dateTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
