using UnityEngine;


public class SelectionOutline : MonoBehaviour
{
    private int m_defaultLayer;
    private string m_highlightLayerName = "Outline";
    private int m_highlightLayer;

    private void Awake()
    {
        m_defaultLayer = gameObject.layer;
        m_highlightLayer = LayerMask.NameToLayer(m_highlightLayerName);
    }

    public void ToggleOutline(bool isHighlighted)
    {
        gameObject.layer = isHighlighted ? m_highlightLayer : m_defaultLayer;
    }
}
