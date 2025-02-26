using UnityEngine;
using TMPro;

public class ChangeFont : MonoBehaviour
{
    public TMP_Text textElement;
    public TMP_FontAsset newFont;

    public void ChangeTextFont()
    {
        textElement.font = newFont;
    }
}
