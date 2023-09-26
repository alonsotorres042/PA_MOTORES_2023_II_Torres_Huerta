using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public int EnemyCapacity = 3;
    public EnemyControl[] EnemyArray;
    // Start is called before the first frame update
    void Start()
    {
        EnemyArray = new EnemyControl[EnemyCapacity];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
