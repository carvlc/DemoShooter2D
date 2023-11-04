using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shuriken : MonoBehaviour
{

    [SerializeField]private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
