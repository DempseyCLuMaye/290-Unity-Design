using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 10.0f;
    public int damage = 1;

    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        PlayerCharacter player = collision.gameObject.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.Hurt(damage);
        }
        Destroy(gameObject);
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
