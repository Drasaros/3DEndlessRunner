using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public GameObject obstaclepreferb;
    
    void Start()
    {
        print("cube");
        int randomchild = Random.Range(0, 2);
        GameObject obstacle = Instantiate(obstaclepreferb, transform.GetChild(randomchild).position, Quaternion.identity);
        obstacle.transform.SetParent(this.transform);
    }

}
