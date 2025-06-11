using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Referencia a nuestro jugador
    public GameObject jugador;

    // Para registrar la diferencia entre la posición de la cámara y la del jugador
    private Vector3 offset;

    // Se ejecuta al iniciar el juego
    void Start()
    {
        // Calcula la diferencia entre la posición de la cámara y la del jugador
        offset = transform.position - jugador.transform.position;
    }

    // Se ejecuta cada frame, pero después de que todo lo demás se haya procesado
    // Es ideal para seguir al jugador con la cámara
    void LateUpdate()
    {
        // Actualiza la posición de la cámara manteniendo el offset
        transform.position = jugador.transform.position + offset;
    }
}
