using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello ");
        transform.position = Vector3.zero;// new Vector3(0,0,0);
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput*  Time.deltaTime );
        transform.Translate(Vector3.up * speed * verticalInput *  Time.deltaTime );
    }
}
