using UnityEngine;
using System.Collections;

public class Canon : MonoBehaviour
{
    public GameObject prefabBala;
    public Vector3 posicion;
    void Start()
    {

    }

    void Update()
    {
        CrearProyectil();        
    }

    void CrearProyectil()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(prefabBala , posicion , transform.rotation);
            StartCoroutine(Retardo());
            Instantiate(prefabBala , posicion , transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(prefabBala , posicion , transform.rotation);
            StartCoroutine(Retardo());
            Instantiate(prefabBala , posicion , transform.rotation);
            StartCoroutine(Retardo());
            Instantiate(prefabBala , posicion , transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(prefabBala , posicion , transform.rotation);
            StartCoroutine(Retardo());
            Instantiate(prefabBala , posicion , transform.rotation);
            StartCoroutine(Retardo());
            Instantiate(prefabBala , posicion , transform.rotation);
            StartCoroutine(Retardo());
            Instantiate(prefabBala , posicion , transform.rotation);
        }
        
    }

    IEnumerator Retardo()
    {
        yield return new WaitForSeconds(0.1f);
    }
}
