using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Vector3 direction;

    public float timeToDestroy = 2f;

    public float side = 1;

    public int damageAmout = 1;

    private void Awake()
    {
        Destroy(gameObject, timeToDestroy);
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * side);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.transform.GetComponent<EnemyBase>();

        if (enemy != null)
        {
            enemy.Damage(damageAmout);
            Destroy(gameObject);
        }
    }
}