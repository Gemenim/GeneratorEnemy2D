using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    private Vector3 _speed;

    public void SetDirection(Vector3 speed)
    {
        _speed = speed;
    }

    private void Update()
    {
        Vector3 moving = _speed * Time.deltaTime;
        transform.Translate(moving);

        if (transform.position.x > 20 || transform.position.y > 20 || transform.position.x < -20 || transform.position.y < -20)
            Destroy(gameObject);
    }
}
