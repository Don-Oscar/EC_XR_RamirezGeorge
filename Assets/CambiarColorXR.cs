using UnityEngine;

public class CambiarColorXR : MonoBehaviour
{
    private Renderer objetoRenderer;
    private bool cambiado = false;

    void Start()
    {
        objetoRenderer = GetComponent<Renderer>();
    }

    public void CambiarColor()
    {
        if (objetoRenderer == null)
            return;

        if (!cambiado)
        {
            objetoRenderer.material.color = Color.red;
            cambiado = true;
        }
        else
        {
            objetoRenderer.material.color = Color.white;
            cambiado = false;
        }
    }
}
