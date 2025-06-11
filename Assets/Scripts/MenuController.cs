using UnityEngine;

public class MenuController : MonoBehaviour
{

    public void IrAOpciones()
    {
        Application.LoadLevel("Opciones");
    }
  
    public void CargarNivel(string nombreNivel)
    {
        Application.LoadLevel(nombreNivel);
    }

    public void VolverAlMenu()
    {
        Application.LoadLevel("MenuPrincipal");
    }
}
