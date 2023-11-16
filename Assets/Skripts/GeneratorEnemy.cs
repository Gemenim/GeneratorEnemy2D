using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorEnemy : MonoBehaviour
{
    [SerializeField] private MoverEnemy _enemy;
    [SerializeField] private float _cooldown;

    private bool _isActiv = false;
    private float _maxSpeedX = 5.0f;
    private float _maxSpeedY = 5.0f;
    private float _minSpeedX = -5.0f;
    private float _minSpeedY = -5.0f;

    public bool IsActiv => _isActiv;

    public void TurnOn()
    {
        _isActiv = true;
    }

    private void Start()
    {
        var creatEnemyJob = CreatEnemy();
        StartCoroutine(creatEnemyJob);
    }

    private IEnumerator CreatEnemy()
    {
        while (true)
        {
            if (_isActiv)
            {
                var newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
                float speedX = Random.Range(_minSpeedX, _maxSpeedX);
                float speedY = Random.Range(_minSpeedY, _maxSpeedY);
                Vector3 speed = new Vector3(speedX, speedY, 0);
                newEnemy.SetDirection(speed);
                _isActiv = false;
            }

            var coldown = new WaitForSeconds(_cooldown);
            yield return coldown;
        }
    }
}
