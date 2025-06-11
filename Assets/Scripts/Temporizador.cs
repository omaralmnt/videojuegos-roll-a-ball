using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Temporizador : MonoBehaviour
{
    public float tiempoRestante = 120f;
    public Text textoTimer;       // Asignar desde el Inspector
    public Text textoGanar;       // Asignar desde el Inspector
    public string escenaMenu = "MenuPrincipal";

    private bool juegoTerminado = false;

    void Update()
    {
        if (!juegoTerminado)
        {
            tiempoRestante -= Time.deltaTime;

            if (tiempoRestante <= 0f)
            {
                tiempoRestante = 0f;
                juegoTerminado = true;
                textoGanar.text = "Perdiste :(";
                StartCoroutine(EsperarYVolver());
            }

            MostrarTiempo(tiempoRestante);
        }
    }

    IEnumerator EsperarYVolver()
    {
        yield return new WaitForSeconds(5f);
        Application.LoadLevel(escenaMenu); // Usando Application.LoadLevel
    }

    void MostrarTiempo(float tiempo)
    {
        int minutos = Mathf.FloorToInt(tiempo / 60);
        int segundos = Mathf.FloorToInt(tiempo % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
