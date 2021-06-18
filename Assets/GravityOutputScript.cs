using UnityEngine;
using UnityEngine.UI;
public class GravityOutputScript : MonoBehaviour
{
    public Text gravity;
    // Update is called once per frame
    void Update()
    {
        gravity.text = GameObject.Find("Sphere").GetComponent<SphereMovement>().g.ToString();
    }
}
