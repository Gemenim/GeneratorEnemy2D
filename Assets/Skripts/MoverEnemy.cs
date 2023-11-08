using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    private float _speedX;
    private float _speedY;

    public void SetDirection(float speedX, float speedY)
    {
        _speedX = speedX;
        _speedY = speedY;
    }

    private void Update()
    {
        float positionX = _speedX * Time.deltaTime;
        float positionY = _speedY * Time.deltaTime;
        transform.Translate(positionX, positionY, 0);

        if (transform.position.x > 20 || transform.position.y > 20 || transform.position.x < -20 || transform.position.y < -20)
            Destroy(gameObject);
    }
}
