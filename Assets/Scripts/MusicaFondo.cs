using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    public AudioClip musica;
    public float volumen = 0.5f;
    
    private AudioSource fuenteAudio;
    private static MusicaFondo instancia; // Singleton para controlar una sola instancia
    
    void Awake()
    {
        // Si ya existe una instancia, destruir esta
        if (instancia != null && instancia != this)
        {
            Destroy(gameObject);
            return;
        }
        
        // Establecer esta como la instancia única
        instancia = this;
        DontDestroyOnLoad(gameObject);
        
        // Configurar el AudioSource
        fuenteAudio = gameObject.AddComponent<AudioSource>();
        fuenteAudio.clip = musica;
        fuenteAudio.loop = true;
        fuenteAudio.playOnAwake = true;
        fuenteAudio.volume = volumen;
        fuenteAudio.Play();
    }
    
    // Método público para cambiar la música
    public void CambiarMusica(AudioClip nuevaMusica)
    {
        if (fuenteAudio != null)
        {
            fuenteAudio.Stop();
            fuenteAudio.clip = nuevaMusica;
            fuenteAudio.Play();
        }
    }
    
    // Método para detener la música
    public void DetenerMusica()
    {
        if (fuenteAudio != null)
        {
            fuenteAudio.Stop();
        }
    }
    
    // Método para reanudar la música
    public void ReanudarMusica()
    {
        if (fuenteAudio != null && !fuenteAudio.isPlaying)
        {
            fuenteAudio.Play();
        }
    }
}