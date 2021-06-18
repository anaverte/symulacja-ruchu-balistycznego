using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public double angle, ray, speed;
   

    public void Text_Angle_Changed(string newText)
    {
        angle = Convert.ToDouble(newText);
       // angle = float.Parse(newText);
       // Debug.Log(angle);

    }
    public void Text_Ray_Changed(string newText)
    {ray= Convert.ToDouble(newText);
        //ray = float.Parse(newText);
        // Debug.Log(ray);

    }
    public void Text_Speed_Changed(string newText)
    {speed= Convert.ToDouble(newText);
        // speed = float.Parse(newText);
        // Debug.Log(speed);

    }

}