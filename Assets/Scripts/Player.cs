using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // declaramos atributo speed (velocidad) de tipo float
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello ");
        transform.position = Vector3.zero;// new Vector3(0,0,0);
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Move(float horizontalInput, float verticalInput)
    {
        /* mediante el componente transform y su propiedad Translate movemos al personaje
        usando los valore pasados por parametro horizontalInput y verticalInput*/
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);
    }
}
