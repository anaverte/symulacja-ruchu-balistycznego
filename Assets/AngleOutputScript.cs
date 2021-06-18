using UnityEngine;
using UnityEngine.UI;
public class AngleOutputScript : MonoBehaviour
{
    public Text kat;
    // Update is called once per frame
    void Update()
    {
        kat.text = GameObject.Find("Sphere").GetComponent<SphereMovement>().beta.ToString();
    }
}