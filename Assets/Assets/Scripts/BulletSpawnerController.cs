using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerController : MonoBehaviour
{
    public PlayerController Player;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(Bullet, Player.transform);
        }
    }
}
