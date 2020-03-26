using UnityEngine;
public class OpacityChanger : MonoBehaviour
{
    public Material target;
    public void UpdateOpacity(float alphaValue)
    {
        Debug.Log(alphaValue);
        Color color = target.color;
        color.a = alphaValue;
        target.color = color;
    }
}