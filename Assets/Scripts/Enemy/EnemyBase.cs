using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 10;

    public Animator animator;
    public string triggerAttack = "Attack";
    public string triggerDeath = "Death";

    public HealthBase health;

    private void Awake()
    {
        if (health != null)
        {
            health.OnKill += OnEnemyKill;
        }
    }

    private void OnEnemyKill()
    {
        health.OnKill -= OnEnemyKill;
        PlayDeathAnimation();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);
        var health = collision.gameObject.GetComponent<HealthBase>();

        if (health != null)
        {
            health.Damage(damage);
            PlayAttackAnimation();
        }
    }

    private void PlayAttackAnimation()
    {
        animator.SetTrigger(triggerAttack);
    }

    private void PlayDeathAnimation()
    {
        animator.SetTrigger(triggerDeath);
    }

    public void Damage(int amout)
    {
        health.Damage(amout);
    }
}