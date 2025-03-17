using UnityEngine;

public class EX1 : MonoBehaviour
{
    public Color on;
    public Color off;
    public float intenciter;
    private void OnMouseDown()
    {
        if (GetComponent<Light>().enabled == false)
        {
            GetComponent<Light>().enabled = true;
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", on);
            GetComponent<Light>().intensity = intenciter;
        }
        else if  (GetComponent<Light>().enabled == true)
        {
            GetComponent<Light>().enabled = false;
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", off);
        }
    }
}
