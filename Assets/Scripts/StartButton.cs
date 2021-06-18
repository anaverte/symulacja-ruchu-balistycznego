
using UnityEngine;
using UnityEngine.UI;
using System;

public class StartButton : MonoBehaviour
{
    public Button startButton;
  
    void Start()
    {
        startButton.onClick.AddListener(TaskOnClick);
        
    }
    void TaskOnClick() {
        //Debug.Log(GameObject.Find("Canvas").GetComponent<NewBehaviourScript>().angle);
        GameObject.Find("Sphere").GetComponent<SphereMovement>().x = 0;
        GameObject.Find("Sphere").GetComponent<SphereMovement>().y = 0;
        GameObject.Find("Sphere").GetComponent<SphereMovement>().v = GameObject.Find("Canvas").GetComponent<NewBehaviourScript>().speed;
        GameObject.Find("Sphere").GetComponent<SphereMovement>().alfa = GameObject.Find("Canvas").GetComponent<NewBehaviourScript>().angle;
        GameObject.Find("Sphere").GetComponent<SphereMovement>().r = GameObject.Find("Canvas").GetComponent<NewBehaviourScript>().ray;
        GameObject.Find("Sphere").GetComponent<SphereMovement>().vx = GameObject.Find("Sphere").GetComponent<SphereMovement>().v * Math.Cos(GameObject.Find("Sphere").GetComponent<SphereMovement>().alfa * Mathf.Deg2Rad);
        GameObject.Find("Sphere").GetComponent<SphereMovement>().vy = GameObject.Find("Sphere").GetComponent<SphereMovement>().v * Math.Sin(GameObject.Find("Sphere").GetComponent<SphereMovement>().alfa * Math.PI / 180);
        GameObject.Find("Sphere").GetComponent<SphereMovement>().g = GameObject.Find("Sphere").GetComponent<SphereMovement>().GM / Math.Pow(GameObject.Find("Sphere").GetComponent<SphereMovement>().R, 2);
        // GameObject.Find("Sphere").GetComponent<SphereMovement>().Uruchomione();
        GameObject.Find("Sphere").GetComponent<SphereMovement>().ruszaj=true;
    }
  
}
