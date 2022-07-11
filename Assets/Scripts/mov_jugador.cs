using UnityEngine;

public class mov_jugador : MonoBehaviour
{
    public int life = 3;
    public float speed = 0;
    public float dir = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void MovePlayer()
    {
       // transform.position += new Vector3(dirX * speed , dirY * speed , dirZ * speed); // Vector3(x,y,z)
        Debug.Log("Jugador moviendose");
    }

    void getLifePlayer()
    {
        life++;
        Debug.Log("Jugador gana vida");
    }

    void hurtPlayer()
    {
        life--;
        Debug.Log("Jugador es dañado");
    }
}


