using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnerShuriken : MonoBehaviour
{
    private Shuriken shuriken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateBullet(){
        // Instantiate(shuriken, transform.position + new Vector3(0,1,0), Quaternion.identity);
        // shuriken = Instantiate(Resources.Load("shuriken"), transform.position + new Vector3(0,1.01f,0),Quaternion.identity);
        Instantiate(Resources.Load("shuriken"), transform.position + new Vector3(0,1.01f,0),Quaternion.identity);
        // GameObject shurikenGameObject =  Instantiate(Resources.Load("shuriken"), transform.position + new Vector3(0,1.01f,0),Quaternion.identity);
        // shuriken = shurikenGameObject.GetComponent<Shuriken>();
    }
}
