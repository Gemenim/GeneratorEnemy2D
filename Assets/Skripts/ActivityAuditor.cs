using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActivityAuditor : MonoBehaviour
{
    private GameObject[] _gameObjects;

    private void Start()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("EnemyGenerator");
        _gameObjects = gameObjects;
    }

    private void Update()
    {
        if (CheckActivity())
        {
            int randomIndex = Random.Range(0, _gameObjects.Length);
            _gameObjects[randomIndex].GetComponent<GeneratorEnemy>().TurnOn();
        }
    }

    private bool CheckActivity()
    {
        bool isVerified = true;

        foreach (GameObject gameObject in _gameObjects)
        {
            if (gameObject.GetComponent<GeneratorEnemy>().IsActiv)
            {
                isVerified = false;
                break;
            }
        }

        return isVerified;
    }
}
