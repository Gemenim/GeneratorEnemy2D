using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    private Vector3 _speed;
    private float _maxPosition = 20.0f;

    public void SetDirection(Vector3 speed)
    {
        _speed = speed;
    }

    private void Update()
    {
        Vector3 moving = _speed * Time.deltaTime;
        transform.Translate(moving);

        if (transform.position.x > _maxPosition || transform.position.y > _maxPosition
            || transform.position.x < -_maxPosition || transform.position.y < -_maxPosition)
            Destroy(gameObject);
    }
}
