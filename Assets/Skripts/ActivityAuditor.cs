using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActivityAuditor : MonoBehaviour
{
    private GeneratorEnemy[] _enemyGenerator;
    private float _cooldown = 2;

    private void Start()
    {
        _enemyGenerator = GetComponentsInChildren<GeneratorEnemy>();
        var chooseSpawnerJob = ChooseSpawner();
        StartCoroutine(chooseSpawnerJob);
    }

    private IEnumerator ChooseSpawner()
    {
        while (true)
        {
            if (CheckActivity())
            {
                int randomIndex = Random.Range(0, _enemyGenerator.Length);
                _enemyGenerator[randomIndex].TurnOn();
            }

            var cooldown = new WaitForSeconds(_cooldown);
            yield return cooldown;
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
