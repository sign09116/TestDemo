using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text inputField, Show;
    float t=0;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            float.TryParse(inputField.text,out t);
            print(t);
            Show.text = t.ToString();
        }
    }
    
}
