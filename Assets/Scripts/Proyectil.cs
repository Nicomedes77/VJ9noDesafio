using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed = 20f;
    public int damage;
    
    void Update()
    {
        transform.Translate(new Vector3(0,0,0.5f));

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            transform.localScale = transform.localScale * 2;
        }
    }
}
