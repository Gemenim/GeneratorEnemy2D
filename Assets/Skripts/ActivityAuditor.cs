using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActivityAuditor : MonoBehaviour
{
    private GeneratorEnemy[] _enemyGenerator;

    private void Start()
    {
        _enemyGenerator = GetComponentsInChildren<GeneratorEnemy>();
    }

    private void Update()
    {
        if (CheckActivity())
        {
            int randomIndex = Random.Range(0, _enemyGenerator.Length);
            _enemyGenerator[randomIndex].TurnOn();
        }
    }
    private bool CheckActivity()
    {
        bool isVerified = true;

        foreach (GeneratorEnemy enemyGenerator in _enemyGenerator)
        {
            if (enemyGenerator.IsActiv)
            {
                isVerified = false;
                break;
            }
        }

        return isVerified;
    }
}
