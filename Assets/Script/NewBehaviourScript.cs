using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyGame;
//namespace

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(1);//
        GameData gameData = new GameData();
        //GameObject g = GetComponent<GameObject>();
        //Cube cube = GetComponent<Cube>
        Transform t = GetComponent<Transform>();
        Collider colliders = GetComponent<Collider>();
        print(colliders);
        print(t);
    }

    // Update is called once per frame
    void Update()
    {
        print(2);
    }
}

namespace MyGame
{
    class GameData
    {

    }
}
