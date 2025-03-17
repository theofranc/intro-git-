using UnityEngine;

public class EX3 : MonoBehaviour
{
    private float Intenciter=0f;
    void Update()
    {
        
             GetComponent<Light>().intensity = Intenciter += 1f;
        if (Intenciter == 20f)
        {

        }
        
        
        
    }
}
