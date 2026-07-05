using TMPro;
using UnityEngine;

public class pengetekstting : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    void Update()
    {
        textComponent.text = ("Penge: " + PengeManager.instance.pinge);
    }
}
