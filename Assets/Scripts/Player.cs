using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // declaramos atributo speed (velocidad) de tipo float
    [SerializeField] private float speed;
    private float limitRangeX;
    private float limitRangeY;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello ");
        transform.position = Vector3.zero;// new Vector3(0,0,0);
        speed = 10f;
        limitRangeX = 8f;
        limitRangeY = 4.15f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Move(float horizontalInput, float verticalInput)
    {/* mediante el componente transform y su propiedad Translate movemos al personaje
        usando los valore pasados por parametro horizontalInput y verticalInput*/

        // control para que el player no se salga de la pantalla en los laterales
        if (gameObject.transform.position.x < -limitRangeX)
        {
            gameObject.transform.position = new Vector3(-limitRangeX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (transform.position.x > limitRangeX)
        {
            transform.position = new Vector3(limitRangeX, transform.position.y, transform.position.z);
        }
        else
        {
            transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        }
        // control para que el player no salga de la pantalla arriba y abajo
        if (gameObject.transform.position.y < -limitRangeY)
        {
            gameObject.transform.position = new Vector3(transform.position.x, -limitRangeY, gameObject.transform.position.z);
        }
        else if (transform.position.y > limitRangeY)
        {
            transform.position = new Vector3(transform.position.x, limitRangeY, transform.position.z);
        }
        else
        {
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);
        }
    }
}
