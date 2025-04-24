using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformrespawn : MonoBehaviour
{
    Vector3 respawnpoint;
    public static Platformrespawn instance;
    public GameObject PlatformRespawn;
    public List<GameObject> Platformlist = new List<GameObject>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        platformrespawn();
    }

    private void Update()
    {
        for(int i = 0;i < Platformlist.Count; i++ )
        {
            if (!Platformlist[i].activeInHierarchy)
            {
                print("into");
                Platformlist[i].SetActive(true);
                Platformlist[i].transform.position = respawnpoint;
                respawnpoint += new Vector3(0, 0, 10);
               
            }
        }
    }

    public void platformrespawn()
    {
        for( int i = 0; i < 5; i++)
        {
            GameObject platform = Instantiate(PlatformRespawn, respawnpoint, Quaternion.identity);
            respawnpoint += new Vector3(0, 0, 10);
            Platformlist.Add(platform);
            
         
        }
    }
}
