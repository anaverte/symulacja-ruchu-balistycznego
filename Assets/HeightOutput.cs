using UnityEngine;
using UnityEngine.UI;
public class HeightOutput : MonoBehaviour
{
    public Transform player;
    public Text height;
    void Update()
    {
        height.text=player.position.y.ToString();
    }
}
