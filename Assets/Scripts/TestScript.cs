using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    public float speed = 2f;
    public float tiempoEspera = 2;
    public float tiempoEsperaPortal = 1f;    
    public float tiempoRestante;
    public float tiempoRestantePortal =1f;
    public GameObject ParedColor;   
    int numeroRandomX = 0;
    int numeroRandomY = 0;
    int numeroRandomZ = 0;        
    Vector3 posInicial;
    bool escala = true;    // true = jugador tamaño normal / false = jugador tamaño pequeño
    
    public Animator anim; //variable para manejar las animaciones

    //variables para manejo de sonidos
    public AudioSource audios;
    public AudioClip clipLadrido;

/*
COMO CREAR NUMEROS ALEATORIOS

numeroRandom = Random.Range(0,20);
new Vector3(numeroRandom,numeroRandom,numeroRandom);

*/

    void Start()
    {
        posInicial = transform.position;
    }


    void Update()
    {
        MovimientoJugador();
/*        
        if(transform.position.y < -10)
        {
            Respawn();
        }
*/
    }

    void StartAudioClip(AudioClip clip)
    {
        audios.clip = clip;
        audios.Play();
        Debug.Log("Poniendo play al mejor sonido del mundo / ladrido");
    }

    void OnTriggerEnter(Collider col)
    {

        if(col.transform.gameObject.tag == "Monedas")
        {
            Debug.Log("Captura moneda");
            Destroy(col.transform.gameObject);
            StartAudioClip(clipLadrido);
        }

        if(col.transform.gameObject.tag == "Daño")
        {
            Debug.Log("El jugador se lastima");
            //Respawn();
        }        

    }


    void OnTriggerExit(Collider col)
    {
         if(col.transform.gameObject.tag == "Portal")
        {
                if(escala == false)
                {
                    transform.localScale = transform.localScale * 2;
                    escala = true;                
                }
                else if(escala == true)
                { 
                    transform.localScale = transform.localScale / 2; 
                    escala = false; 
                }
        }   
    }
/*
    void OnTriggerStay(Collider col)
    {
         if(col.transform.gameObject.tag == "ParedColor")
        {
            tiempoRestante -= Time.deltaTime;
            if(tiempoRestante <= 0)
            {
                RespawnPared();
                ResetearTemporizador();
            }
        }           
    }

    void Respawn()
    {
        transform.position = posInicial;
    }

    void RespawnPared()
    {
        ParedColor.transform.position = new Vector3(Random.Range(0,5) , 0 , Random.Range(0,5));
        Quaternion rot = Quaternion.LookRotation(ParedColor.transform.position);
        ParedColor.transform.rotation = rot;
    }
*/
    void MovimientoJugador()
    {
        /*
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Has presionado la tecla espacio");
            transform.Translate(new Vector3(0,0,0.1f));
        }
        */
    /*
        FORMA CLASICA DE QUE SE MUEVA UN JUGADOR CON INPUTS

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 inputPlayer = new Vector3(hor,0,ver);

        transform.Translate(new Vector3(hor,0,ver) * speed * Time.deltaTime);
        */

    // FORMA PARA DARLE MOVIMIENTO CON ANIMACIONES
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 inputPlayer = new Vector3(hor,0,ver);

        transform.Translate(inputPlayer * speed * Time.deltaTime);

        if(inputPlayer != Vector3.zero) //controla si el jugador apretó algun botón
        {
            //Debug.Log("el jugador corre");
            anim.SetBool("estaCorriendo",true);
        }
        else
        {
            //Debug.Log("el jugador NO corre");
            anim.SetBool("estaCorriendo",false);
        }
    }
/*
    void ResetearTemporizador()
    {
        tiempoRestante = tiempoEspera;
    }

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if(tiempoRestante <= 0)
        {
            Debug.Log("La espera terminó");
        }
    }
*/
 /* 
    void ResetearDisparo()
    {
        delay = tiempoEspera;
    }

    void Disparar()
    {
        delay -= Time.deltaTime;
        if(delay <= 0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(proyectilPrefab , transform.position , transform.rotation);
            }
            else
            {
                Instantiate(proyectilPrefab , transform.position , transform.rotation);
            }
            ResetearDisparo();
        }
        

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilPrefab , transform.position , transform.rotation);
        }

    }
*/
}
