using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawner : MonoBehaviour
{

    public GameObject player;

    private void Awake()
    {
        GameObject scenePlayer = GameObject.FindGameObjectWithTag("Player");
        if(scenePlayer == null)
        {
            var inst = Instantiate(player);
            inst.transform.position = this.transform.position;
        } else
        {
            scenePlayer.transform.position = this.transform.position;
        }
    }
}
