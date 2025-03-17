using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

public class LightSwitch : MonoBehaviour
{ public Color Emisisioncolor;
    private void OnMouseDown()
    { 
        Debug.Log("Clique on " + name);

        //Premi�re option : tout  d�sactiver //
        //gameObject.SetActive(false);

        //deuxi�me option : d�sactiver que la light//
        //GetComponent<Light>().enabled = false;

        GetComponent<Light>().intensity = 0.5f;
        GetComponent<Light>().color = new Color(0.5f, 0.5f, 0.5f);
        // changer la couleur de l'abedoe //
        GetComponent<MeshRenderer>().material.color = new Color(1,1,0);
        // changer la couleur de l'emissi//
        GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Emisisioncolor);
        // r�cup�rer la couleurs de la lumi�res//
        Color lightColor = GetComponent<Light>().color;
      //modifie cette couleurs en changeant chaque composant r,g,b//
        lightColor.r = 0f - lightColor.r;
        lightColor.g = 0f - lightColor.g;
        lightColor.b = 0f - lightColor.b;
    }
}
