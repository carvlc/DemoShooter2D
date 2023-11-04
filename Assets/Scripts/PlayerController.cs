using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();// obtenermos el componente player de this gameobject
    }

    // Update is called once per frame
    void Update()
    {
        CaptureInput();
    }

    public void CaptureInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        player.Move(horizontalInput, verticalInput);
    }
}
