
using TMPro;
using UnityEngine;

public class SizeDisplayUI : MonoBehaviour
{
    public TextMeshProUGUI sizeText;

    public PlayerController playercontroller;
   
    void Update()
    {
        sizeText.text = "Size: " + playercontroller.size;
    }
}
