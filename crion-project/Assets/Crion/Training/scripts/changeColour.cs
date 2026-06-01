using UnityEngine;
using System.Collections;
public class changeColour : MonoBehaviour
{
    private Renderer m_wallRenderer;
    private Color m_originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_wallRenderer = GetComponent<Renderer>();
        m_originalColor = m_wallRenderer.material.color;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        StartCoroutine(ChangeToRedAndBack());
    }

    IEnumerator ChangeToRedAndBack()
    {
        m_wallRenderer.material.color = Color.yellow;
        yield return new WaitForSeconds(1f);
        m_wallRenderer.material.color = m_originalColor;
        }
}
