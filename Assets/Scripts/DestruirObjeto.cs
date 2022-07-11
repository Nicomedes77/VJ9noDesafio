using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public float tiempoADestruir = 2f;
    void Start()
    {
        Destroy(gameObject,tiempoADestruir); //destruye el "gameObject" luego de 5 segundos
    }
}
