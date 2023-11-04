using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // se declara un atributo Player
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        // inicializamos el objeto player
        player = GetComponent<Player>();// obtenermos el componente player de this gameobject
    }

    // Update is called once per frame
    void Update()
    {
        CaptureInput();
    }
// metodo para caturar los imput y mover al player mediante el metodo Move() del objeto Player
    public void CaptureInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        player.Move(horizontalInput, verticalInput);

        if (Input.GetButtonDown("Fire1"))
        {
            // es un metodo que permite instanciar gameObjects
            player.Fire();
        }
    }


}
