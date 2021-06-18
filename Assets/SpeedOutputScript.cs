using UnityEngine;
using UnityEngine.UI;
public class SpeedOutputScript : MonoBehaviour
{
    public Text speed;
    // Update is called once per frame
    void Update()
    {
        speed.text = GameObject.Find("Sphere").GetComponent<SphereMovement>().v.ToString();
    }
}
